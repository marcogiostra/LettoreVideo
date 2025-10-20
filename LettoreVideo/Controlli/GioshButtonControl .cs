using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace LettoreVideo.Controlli
{
    public partial class ArrowButtonControl : UserControl
    {
        public enum IconType
        {
            ArrowUp,
            RedX,
            MyPicture
        }

        private IconType currentIcon = IconType.ArrowUp;
        private bool isHovered = false;
        private bool isPressed = false;


        // Proprietà pubblica per scegliere l'icona
        public IconType DisplayIcon
        {
            get => currentIcon;
            set
            {
                currentIcon = value;
                this.Invalidate(); // ridisegna
            }
        }

        private Image myImage;
        private int pictureMargin = 10;

        public Image MyImage
        {
            get => myImage;
            set
            {
                myImage = value;
                if (myImage != null)
                {
                    this.Width = myImage.Width + (pictureMargin * 2);
                    this.Height = myImage.Height + (pictureMargin * 2);
                }
                this.Invalidate();
            }
        }

        public int PictureMargin
        {
            get => pictureMargin;
            set
            {
                pictureMargin = value;
                if (myImage != null)
                {
                    this.Width = myImage.Width + (pictureMargin * 2);
                    this.Height = myImage.Height + (pictureMargin * 2);
                }
                this.Invalidate();
            }
        }

        // Evento pubblico da gestire nel form
        public event EventHandler IconClick;


   
        public ArrowButtonControl()
        {
            this.Width = 40; 
            this.Height = 15;
            this.DoubleBuffered = true;

            // Eventi mouse
            this.MouseEnter += (s, e) => { isHovered = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { isHovered = false; isPressed = false; this.Invalidate(); };
            this.MouseDown += (s, e) => { isPressed = true; this.Invalidate(); };
            this.MouseUp += (s, e) =>
            {
                if (isPressed && isHovered)
                    IconClick?.Invoke(this, EventArgs.Empty);

                isPressed = false;
                this.Invalidate();
            };

        }

        private void ArrowButtonControl_MouseClick(object sender, MouseEventArgs e)
        {
            // Solleva evento personalizzato
            IconClick?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Color backColor = this.BackColor;
            Brush iconBrush = Brushes.Black;
            Pen iconPen = Pens.Black;

            if (currentIcon == IconType.ArrowUp)
            {
                if (isPressed)
                {
                    backColor = Color.FromArgb(25, 118, 210);   // Blue 700
                    iconBrush = Brushes.White;
                }
                else if (isHovered)
                {
                    backColor = Color.FromArgb(227, 242, 253);  // Blue 100
                    iconBrush = Brushes.Black;
                }
                else
                {
                    backColor = Color.White;
                    iconBrush = Brushes.Black;
                }
            }
            else if (currentIcon == IconType.RedX)
            {
                if (isPressed)
                {
                    backColor = Color.FromArgb(198, 40, 40);    // Red 800
                    iconPen = new Pen(Color.White, 6);
                }
                else if (isHovered)
                {
                    backColor = Color.FromArgb(255, 205, 210);  // Red 200
                    iconPen = new Pen(Color.Red, 6);
                }
                else
                {
                    backColor = Color.White;
                    iconPen = new Pen(Color.Red, 6);
                }
            }
            else if (currentIcon == IconType.MyPicture)
            {
                backColor = Color.White; // sfondo neutro dietro l’immagine
            }

            using (Brush backBrush = new SolidBrush(backColor))
            {
                g.FillRectangle(backBrush, this.ClientRectangle);
            }

            if (currentIcon == IconType.ArrowUp)
            {
                //DrawUpArrow(g, Brushes.Black, this.ClientRectangle);
                DrawUpArrow(g, iconBrush, this.ClientRectangle);
            }
            else if (currentIcon == IconType.RedX)
            {
                //DrawRedX(g, Pens.Red, this.ClientRectangle);
                DrawRedX(g, iconPen, this.ClientRectangle);
            }
            else if (currentIcon == IconType.MyPicture && myImage != null)
                g.DrawImage(myImage, pictureMargin, pictureMargin, myImage.Width, myImage.Height);


            // Bordo
            //g.DrawRectangle(Pens.DarkGray, 0, 0, this.Width - 1, this.Height - 1);
        }

  
        private void DrawUpArrow(Graphics g, Brush brush, Rectangle rect)
        {
            int arrowWidth = rect.Width / 2;
            int arrowHeight = rect.Height / 2;
            int centerX = rect.X + rect.Width / 2;
            int centerY = rect.Y + rect.Height / 2;

            Point[] points = new Point[3];
            points[0] = new Point(centerX, centerY - arrowHeight / 2); // punta
            points[1] = new Point(centerX - arrowWidth / 2, centerY + arrowHeight / 2);
            points[2] = new Point(centerX + arrowWidth / 2, centerY + arrowHeight / 2);

            g.FillPolygon(brush, points);
        }

        /*
        private void DrawRedX(Graphics g, Pen basePen, Rectangle rect)
        {
            int margin = rect.Width / 4;
            int topMargin = rect.Height / 4;

            int left = rect.Left + margin;
            int right = rect.Right - margin;
            int top = rect.Top + topMargin;
            int bottom = rect.Bottom - topMargin;

            using (Pen thickPen = new Pen(basePen.Color, 6))
            {
                thickPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                thickPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                g.DrawLine(thickPen, left, top, right, bottom);
                g.DrawLine(thickPen, right, top, left, bottom);
            }
        }
        */

        private void DrawRedX(Graphics g, Pen pen, Rectangle rect)
        {
            int margin = rect.Width / 4;
            int topMargin = rect.Height / 4;

            int left = rect.Left + margin;
            int right = rect.Right - margin;
            int top = rect.Top + topMargin;
            int bottom = rect.Bottom - topMargin;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            g.DrawLine(pen, left, top, right, bottom);
            g.DrawLine(pen, right, top, left, bottom);
        }
    }
}

/*


}

 */

