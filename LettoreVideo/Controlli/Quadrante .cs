using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace LettoreVideo.Controlli
{
    
    // Usa il tipo completamente qualificato se hai ancora problemi:
    // [Designer(typeof(System.Windows.Forms.Design.ParentControlDesigner))]
    [Designer(typeof(ParentControlDesigner))]
    public partial class Quadrante : UserControl
    {
        public Quadrante()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.FromArgb(150, 0, 0, 0);
            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.DesignMode)
            {
                using (Pen pen = new Pen(Color.Gray, 1))
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                using (Brush brush = new SolidBrush(Color.FromArgb(30, Color.LightBlue)))
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
    
  
}
