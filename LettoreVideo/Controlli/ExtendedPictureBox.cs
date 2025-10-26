using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LettoreVideo.Controlli
{

    public partial class ExtendedPictureBox : UserControl
    {
        private Image normalImage;
        private Image hoverImage;
        private Image clickImage;
        private bool isMouseDown;
        private bool isMouseInside;
        private bool autoResize = true;
        private bool useFormBackColor = true;
        private bool debugMode = false;
        private Cursor customCursor = Cursors.Hand;
        private Image lastDisplayedImage = null;

        public event EventHandler ImageChanged;

        public ExtendedPictureBox()
        {
            this.InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);

            // Non impostiamo BackColor = Transparent perché può confondere l'hit-test;
            // disegniamo manualmente lo sfondo del form nel OnPaintBackground.
            this.BackColor = SystemColors.Control;

            this.MouseEnter += ExtendedPictureBox_MouseEnter;
            this.MouseLeave += ExtendedPictureBox_MouseLeave;
            this.MouseMove += ExtendedPictureBox_MouseMove;
            this.MouseDown += ExtendedPictureBox_MouseDown;
            this.MouseUp += ExtendedPictureBox_MouseUp;

            this.Cursor = customCursor;
        }

        // --- Proprietà ---
        [Category("Appearance")]
        public Image ImageNormal
        {
            get => normalImage;
            set
            {
                normalImage = value;
                if (autoResize && value != null)
                    this.Size = value.Size;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Image ImageHover { get => hoverImage; set { hoverImage = value; Invalidate(); } }

        [Category("Appearance")]
        public Image ImageClick { get => clickImage; set { clickImage = value; Invalidate(); } }

        [Category("Behavior")]
        public bool AutoResize { get => autoResize; set => autoResize = value; }

        [Category("Appearance")]
        [DefaultValue(true)]
        public bool UseFormBackColor { get => useFormBackColor; set { useFormBackColor = value; Invalidate(); } }

        [Category("Appearance")]
        public Cursor CustomCursor { get => customCursor; set { customCursor = value ?? Cursors.Default; this.Cursor = customCursor; } }

        [Category("Behavior")]
        [DefaultValue(false)]
        public bool DebugMode { get => debugMode; set { debugMode = value; Invalidate(); } }

        // --- Mouse handlers con debug ---
        private void ExtendedPictureBox_MouseEnter(object s, EventArgs e)
        {
            isMouseInside = true;
            DebugWrite("MouseEnter");
            Invalidate();
        }

        private void ExtendedPictureBox_MouseMove(object s, MouseEventArgs e)
        {
            DebugWrite($"MouseMove ({e.X},{e.Y})");
            // non facciamo test per pixel: hover valido su tutto il rettangolo
            if (!isMouseDown && isMouseInside) Invalidate();
        }

        private void ExtendedPictureBox_MouseLeave(object s, EventArgs e)
        {
            isMouseInside = false;
            DebugWrite("MouseLeave");
            Invalidate();
        }

        private void ExtendedPictureBox_MouseDown(object s, MouseEventArgs e)
        {
            isMouseDown = true;
            DebugWrite($"MouseDown ({e.Button})");
            Invalidate();
        }

        private void ExtendedPictureBox_MouseUp(object s, MouseEventArgs e)
        {
            isMouseDown = false;
            DebugWrite("MouseUp");
            Invalidate();
            //OnClick(EventArgs.Empty);
        }

        private void DebugWrite(string msg)
        {
            if (debugMode)
                Debug.WriteLine($"[ExtendedPictureBox] {msg}");
        }

        // --- Disegno background: replica del form (colore o background image) ---
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (useFormBackColor)
            {
                Form f = this.FindForm();
                if (f != null)
                {
                    // Se il form ha BackgroundImage, dipingiamo la porzione corrispondente
                    if (f.BackgroundImage != null)
                    {
                        // calcola offset della nostra area relativa al form
                        Point screen = this.PointToScreen(Point.Empty);
                        Point formClient = f.PointToClient(screen);

                        Rectangle src = new Rectangle(formClient, this.Size);
                        Rectangle dest = new Rectangle(0, 0, this.Width, this.Height);

                        e.Graphics.DrawImage(f.BackgroundImage, dest, src, GraphicsUnit.Pixel);
                        return;
                    }
                    else
                    {
                        e.Graphics.Clear(f.BackColor);
                        return;
                    }
                }
            }

            base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Image img = normalImage;
            if (isMouseDown)
                img = clickImage ?? hoverImage ?? normalImage;
            else if (isMouseInside)
                img = hoverImage ?? normalImage;

            // Se l'immagine visualizzata è diversa da prima, solleva ImageChanged
            if (img != lastDisplayedImage)
            {
                lastDisplayedImage = img;
                ImageChanged?.Invoke(this, EventArgs.Empty);
            }

            if (img != null)
            {
                // solo Zoom come richiesto: mantiene proporzioni
                Rectangle dest = GetZoomRectangle(img, this.ClientRectangle);
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                e.Graphics.DrawImage(img, dest);
            }

            if (debugMode)
            {
                using (Pen p = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private Rectangle GetZoomRectangle(Image img, Rectangle client)
        {
            if (img == null) return client;
            float ratioX = (float)client.Width / img.Width;
            float ratioY = (float)client.Height / img.Height;
            float ratio = Math.Min(ratioX, ratioY);
            int newW = (int)(img.Width * ratio);
            int newH = (int)(img.Height * ratio);
            return new Rectangle((client.Width - newW) / 2, (client.Height - newH) / 2, newW, newH);
        }
    }
}


