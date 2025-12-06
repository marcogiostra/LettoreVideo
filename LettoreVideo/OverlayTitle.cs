using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo
{
    public partial class OverlayTitle : Form
    {
        Form _owner = new Form();

     

        public void ShowTitolo(string pTitolo)
        {
            lblTitle.Text = pTitolo;
            timer1.Enabled = true;
        }

        public OverlayTitle()
        {
            InitializeComponent();
        }
        public void SetOwner(Form owner)
        {
            if (owner != null)
            {
                _owner.Owner = owner;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Visible = true;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            this.Visible = false;

        }
    }
}
