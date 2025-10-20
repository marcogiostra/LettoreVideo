using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LettoreVideo
{
    public partial class OverLayForm : Form
    {
        public enum OverlayType
        {
            Top,
            Right,
            Botton,
            Left
        }

        #region DICHIARAZIONI

        #region PARAMETRI
        private frmVideo _parentForm;
        private OverlayType _type;
        private int _overlayPixelMisure;
        private double _opacity;
        #endregion PARAMTRI

        //private TextBox txtInput;
        #endregion DICHIARAZIONI

        public OverLayForm(frmVideo pParentForm, OverlayType pType, int pOverlayPixelMisure, double pOpacity)
        {
            //memorizza i paramtri
            _parentForm = pParentForm;
            _type = pType;
            _overlayPixelMisure = pOverlayPixelMisure;
            _opacity = pOpacity;
            if (_opacity > 1)
                _opacity = 1;
            else if (_opacity <= 0)
                    _opacity = 0.5;

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.BackColor = Color.Black;
            this.Opacity = 0.7; // semi trasparente

            switch (_type)
            {
                case OverlayType.Top:
                    this.Height =   _overlayPixelMisure;   //per esempio 80;
                    break;

                case OverlayType.Right:
                    this.Width = _overlayPixelMisure;   //per esempio 200;
                    break;

                case OverlayType.Botton:
                    this.Height = _overlayPixelMisure;   //per esempio 60;
                    break;

                case OverlayType.Left:
                    this.Width = _overlayPixelMisure;   //per esempio 200;
                    break;
            }



            //InitializeComponent();

            /*
            // esempio di pulsanti
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                FlowDirection = FlowDirection.LeftToRight
            };

            Button okBtn = new Button { Text = "OK-Top", Width = 100 };
            okBtn.Click += (s, e) => parentForm.DoOkFromTop();

            txtInput = new TextBox { Width = 150 };

            panel.Controls.Add(new Label { Text = "Overlay Top", ForeColor = Color.White, AutoSize = true });
            panel.Controls.Add(txtInput);
            panel.Controls.Add(okBtn);

            this.Controls.Add(panel);
            */


        }

        /*esempio di valorizzazione di un controllo
         * 
         * public string InputText
        {
            get => txtInput.Text;
            set => txtInput.Text = value;
        }
         */
    }
}
