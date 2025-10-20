using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo.Controlli
{
    public partial class MediaSeekBar : UserControl
    {
        private int minimum = 0;
        private int maximum = 100;
        private int value = 0;
        private bool isDragging = false;
        public bool IsDragging => isDragging;

        public event EventHandler ValueChanged;

        public int Minimum
        {
            get => minimum;
            set { minimum = value; Invalidate(); }
        }

        public int Maximum
        {
            get => maximum;
            set { maximum = value; Invalidate(); }
        }

        public int Value
        {
            get => this.value;
            set
            {
                if (value < minimum) this.value = minimum;
                else if (value > maximum) this.value = maximum;
                else this.value = value;

                Invalidate();
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public MediaSeekBar()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Height = 20;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int thumbSize = 12;
            int halfThumb = thumbSize / 2;

            // sfondo barra
            Rectangle rect = new Rectangle(halfThumb, Height / 3, Width - thumbSize, Height / 3);
            using (Brush b = new SolidBrush(Color.LightGray))
                g.FillRectangle(b, rect);

            // parte riempita (arancione)
            float percent = (float)(value - minimum) / (maximum - minimum);
            int filledWidth = (int)((Width - thumbSize) * percent) + halfThumb;
            Rectangle rectFill = new Rectangle(halfThumb, Height / 3, filledWidth - halfThumb, Height / 3);
            using (Brush b = new SolidBrush(Color.Orange))
                g.FillRectangle(b, rectFill);

            // thumb (pallino) - contorno grigio scuro, interno arancione
            int thumbX = filledWidth - halfThumb;
            int thumbY = Height / 2 - halfThumb;
            Rectangle thumb = new Rectangle(thumbX, thumbY, thumbSize, thumbSize);

            using (Brush b = new SolidBrush(Color.DarkGray))
                g.FillEllipse(b, thumb);
            using (Pen p = new Pen(Color.DarkGray, 2))
                g.DrawEllipse(p, thumb);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            isDragging = true;
            UpdateValueFromMouse(e.X);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isDragging)
                UpdateValueFromMouse(e.X);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isDragging = false;
        }

        private void UpdateValueFromMouse(int mouseX)
        {
            int thumbSize = 12;
            int halfThumb = thumbSize / 2;

            // Limita mouseX all'interno dei bordi
            int x = mouseX;
            if (x < halfThumb) x = halfThumb;
            if (x > Width - halfThumb) x = Width - halfThumb;

            // Percentuale relativa all'area effettiva della barra
            float percent = (float)(x - halfThumb) / (Width - thumbSize);
            int newValue = minimum + (int)((maximum - minimum) * percent);

            Value = newValue;
        }
    }
}
