using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LettoreVideo.Controlli
{
        public partial class SpeedRangeSelector : UserControl
    {
        // Event per notificare il cambio valore
        public event EventHandler<int> ValueChanged;

        // Range parametrico
        private int _minimum = -7;
        public int Minimum
        {
            get { return _minimum; }
            set
            {
                if (value != _minimum)
                {
                    _minimum = value;
                    if (SelectedValue < _minimum) SelectedValue = _minimum;
                    Invalidate();
                }
            }
        }

        private int _maximum = 7;
        public int Maximum
        {
            get { return _maximum; }
            set
            {
                if (value != _maximum)
                {
                    _maximum = value;
                    if (SelectedValue > _maximum) SelectedValue = _maximum;
                    Invalidate();
                }
            }
        }

        // Valore selezionato
        private int _selectedValue = 0;
        public int SelectedValue
        {
            get { return _selectedValue; }
            set
            {
                int newValue = Math.Max(_minimum, Math.Min(_maximum, value));
                if (newValue != _selectedValue)
                {
                    _selectedValue = newValue;
                    ValueChanged?.Invoke(this, _selectedValue);
                    Invalidate();
                }
            }
        }

        public SpeedRangeSelector()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.Size = new Size(260, 34);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int count = (Maximum - Minimum) + 1;
            if (count <= 0) return;

            int margin = 2;
            int totalMargins = margin * (count + 1);
            int availableWidth = Width - totalMargins;
            int btnWidth = Math.Max(12, availableWidth / count);
            int btnHeight = Math.Min(Height - 4, 22);
            int startX = margin;
            int y = (Height - btnHeight) / 2;

            float fontSize = Math.Max(6f, btnWidth * 0.45f);

            for (int val = Minimum; val <= Maximum; val++)
            {
                int index = val - Minimum;
                int x = startX + index * (btnWidth + margin);
                Rectangle rect = new Rectangle(x, y, btnWidth, btnHeight);

                bool selected = (val == SelectedValue);

                Color bg = selected
                    ? Color.FromArgb(190, 255, 255, 255)
                    : Color.FromArgb(60, 0, 0, 0);

                using (GraphicsPath path = RoundedRect(rect, 6))
                using (SolidBrush brush = new SolidBrush(bg))
                using (Pen pen = new Pen(Color.White, selected ? 1.5f : 0))
                {
                    g.FillPath(brush, path);
                    if (selected) g.DrawPath(pen, path);
                }

                // Font compatibile C# 7.3
                Font f = new Font(Font.FontFamily, fontSize, FontStyle.Regular);
                try
                {
                    TextRenderer.DrawText(
                        g,
                        val.ToString(),
                        f,
                        rect,
                        selected ? Color.Black : Color.White,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                    );
                }
                finally
                {
                    f.Dispose();
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            int count = (Maximum - Minimum) + 1;
            if (count <= 0) return;

            int margin = 2;
            int totalMargins = margin * (count + 1);
            int availableWidth = Width - totalMargins;
            int btnWidth = Math.Max(12, availableWidth / count);
            int btnHeight = Math.Min(Height - 4, 22);
            int startX = margin;
            int y = (Height - btnHeight) / 2;

            for (int val = Minimum; val <= Maximum; val++)
            {
                int index = val - Minimum;
                int x = startX + index * (btnWidth + margin);
                Rectangle rect = new Rectangle(x, y, btnWidth, btnHeight);

                if (rect.Contains(e.Location))
                {
                    SelectedValue = val; // usa la property
                    break;
                }
            }
        }

        private GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            GraphicsPath p = new GraphicsPath();
            int d = radius * 2;

            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();

            return p;
        }
    }


}
