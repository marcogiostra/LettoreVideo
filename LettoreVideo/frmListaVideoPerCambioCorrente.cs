using LettoreVideo.Classi;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LettoreVideo
{
    public partial class frmListaVideoPerCambioCorrente : Form
    {
        #region DICHIARAZIONI
        #region PARAMETRI
        private List<VideoFile> _VIDs = new List<VideoFile>();
        private int _Curentindex { get; set; }
        #endregion PARAMATRI

        #region RETURN
        public int rIndiceCorrente { get; private set; } = -1;
        #endregion RETURN
        #endregion DICHIARAZIONI

        #region Class
        public frmListaVideoPerCambioCorrente(List<VideoFile> pVIDs, int pCurrentIndex)
        {
            _VIDs = pVIDs;
            _Curentindex = pCurrentIndex;

            InitializeComponent();
        }
        private void frmListaVideoPerCambioCorrente_Load(object sender, EventArgs e)
        {
            this.Tag = "KO";
            timer1.Enabled = true;
        }
        #endregion Class

        #region f()
        private void Popola()
        {
            lstPlayList.DataSource = null;   // reset binding
            lstPlayList.DataSource = _VIDs;
            lstPlayList.DisplayMember = "Titolo";
            lstPlayList.ValueMember = "ID";

            lstPlayList.SelectedIndex = _Curentindex;
        }
        #endregion f()

        #region PULSANTERIA
        private void picClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        #endregion PULSANTERIA

        private void playlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstPlayList.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                rIndiceCorrente = index;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Popola();
            lstPlayList.Focus();
        }
    }
}
