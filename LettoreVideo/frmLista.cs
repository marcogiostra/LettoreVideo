using LettoreVideo.Classi;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LettoreVideo
{
    public partial class frmLista : MaterialForm
    {

        #region DICHIARAZIONI
        #region PARAMETRI
        private List<VideoFile> _VIDs = new List<VideoFile>();
        #endregion PARAMATRI

        private readonly MaterialSkinManager materialSkinManager;
        private System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
        private int lastIndex = -1;

        #region RETURN
        public List<VideoFile> rListaFinale { get; private set; }
        public int rIndiceCorrente { get; private set; } = -1;
        #endregion RETURN
        #endregion DICHIARAZIONI

        #region Class
        public frmLista(List<VideoFile> pVIDs)
        {
            _VIDs = pVIDs;

            InitializeComponent();

            //Configuro MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // Dark Mode
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Orange200, TextShade.WHITE
            );

            bool isDark = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK;
            checkedListBox1.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            checkedListBox1.ForeColor = isDark ? Color.White : Color.Black;
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            AggiornaCheckedListBox();
            this.Tag = "KO";
        }

        #endregion Class

        #region PULSANTERIA
        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picSave_Click(object sender, EventArgs e)
        {
            rListaFinale = _VIDs;  
            if (_VIDs.Count > 0)
                rIndiceCorrente = checkedListBox1.SelectedIndex; // indice corrente
            else
                rIndiceCorrente = -1;
            this.Tag = "OK";
            this.Close();
        }

        private void picDown_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            if (index >= 0 && index < _VIDs.Count - 1)
            {
                // swap nella lista
                var tmp = _VIDs[index];
                _VIDs[index] = _VIDs[index + 1];
                _VIDs[index + 1] = tmp;

                AggiornaCheckedListBox();
                checkedListBox1.SelectedIndex = index + 1; // mantieni selezione
            }
        }

        private void picUp_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            if (index > 0)
            {
                // swap nella lista
                var tmp = _VIDs[index];
                _VIDs[index] = _VIDs[index - 1];
                _VIDs[index - 1] = tmp;

                AggiornaCheckedListBox();
                checkedListBox1.SelectedIndex = index - 1; // mantieni selezione
            }
        }

        private void picCestino_Click(object sender, EventArgs e)
        {
            // Colleziono gli item selezionati (CheckedItems) in una lista temporanea
            var daEliminare = checkedListBox1.CheckedItems.Cast<VideoFile>().ToList();

            if (daEliminare.Count == 0)
                return;

            // Rimuovo dalla lista originale
            foreach (var item in daEliminare)
            {
                _VIDs.Remove(item);
            }

            // Rinfresco il CheckedListBox
            AggiornaCheckedListBox();
        }

        private void picCheckAll_Click(object sender, EventArgs e)
        {
            CheckAllItems(checkedListBox1);
        }

        private void picUncheckAll_Click(object sender, EventArgs e)
        {
            UncheckAllItems(checkedListBox1);
        }
        #endregion PULSANTERIA

        #region f()
        private void AggiornaCheckedListBox()
        {
            checkedListBox1.DataSource = null;   // reset binding
            checkedListBox1.DataSource = _VIDs;
            checkedListBox1.DisplayMember = "Titolo";
            checkedListBox1.ValueMember = "ID";
        }

        private void CheckAllItems(CheckedListBox clb)
        {
            for (int i = 0; i < clb.Items.Count; i++)
                clb.SetItemChecked(i, true);
        }

        private void UncheckAllItems(CheckedListBox clb)
        {
            for (int i = 0; i < clb.Items.Count; i++)
                clb.SetItemChecked(i, false);
        }

        #endregion f()

        private void checkedListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int index = checkedListBox1.IndexFromPoint(e.Location);
            if (index >= 0 && index < checkedListBox1.Items.Count)
            {
                if (index != lastIndex) // evita di ricreare tooltip di continuo
                {
                    var item = (VideoFile)checkedListBox1.Items[index];
                    Point p = new Point(e.X, e.Y - 20); // sopra al cursore
                    string _tip = "cat:" + item.Categoria + " -  gruppo:" + item.Specifica;
                    toolTip1.Show(_tip, checkedListBox1, p, 800);
                    //toolTip1.SetToolTip(checkedListBox1, item.Cartella);
                    lastIndex = index;
                }
            }
            else
            {
                toolTip1.SetToolTip(checkedListBox1, string.Empty);
                lastIndex = -1;
            }
        }

   
    }
}
