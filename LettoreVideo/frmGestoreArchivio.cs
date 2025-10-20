using LettoreVideo.Classi;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LettoreVideo
{
    public partial class frmGestoreArchivio : MaterialForm
    {
        #region DICHIARAZIONI
        #region PARAMETRI
        private List<VideoFileDB> _VID_DBs = new List<VideoFileDB>();
        #endregion PARAMATRI

        private readonly MaterialSkinManager materialSkinManager;
        private System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
        private int lastIndex = -1;

        #region RETURN
        public List<VideoFileDB> rListaFinale { get; private set; }
        #endregion RETURN

        #region LISTAVIDEO_DB
        private List<VideoFileDB> VID_DBs = new List<VideoFileDB>();
        private string DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        #endregion LISTAVIDEO_DB
        #endregion DICHIARAZIONI

        #region Class
        public frmGestoreArchivio(List<VideoFileDB> pVID_DBs)
        {
            _VID_DBs = pVID_DBs;
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

        private void frmGestoreArchivio_Load(object sender, EventArgs e)
        {
            AggiornaCheckedListBox();
            this.Tag = "KO";
        }
        #endregion Class

        #region PULSANTIERA
        private void picSave_Click(object sender, EventArgs e)
        {
       
            try
            {
                string DbFile = Path.Combine(DataFolder, "db.json");
                //string json = JsonConvert.SerializeObject(VID_DBs, Formatting.Indented);
                //File.WriteAllText(DbFile, json);

                Export exportObj = new Export { Data = _VID_DBs };

                string json = JsonConvert.SerializeObject(exportObj, Formatting.Indented);
                File.WriteAllText(DbFile, json);

                PRG.MsgBoxExcvlamation("Il salvataggio ha avuto successo!");
            }
            catch (Exception ex)
            {
                PRG.MsgBoxERR(ex, "Errore nella procedura di salvataggio nuovi file in archivio:\r\n\r\n");
                return;
            }
            rListaFinale = _VID_DBs;
            this.Tag = "OK";
            this.Close();

        }

        private void picCheckAll_Click(object sender, EventArgs e)
        {
            CheckAllItems(checkedListBox1);
        }

        private void picUncheckAll_Click(object sender, EventArgs e)
        {
            UncheckAllItems(checkedListBox1);
        }

        private void picCestino_Click(object sender, EventArgs e)
        {
            // Colleziono gli item selezionati (CheckedItems) in una lista temporanea
            var daEliminare = checkedListBox1.CheckedItems.Cast<VideoFileDB>().ToList();

            if (daEliminare.Count == 0)
                return;

            // Rimuovo dalla lista originale
            foreach (var item in daEliminare)
            {
                _VID_DBs.Remove(item);
            }

            // Rinfresco il CheckedListBox
            AggiornaCheckedListBox();
        }
        #endregion PULSANTIERA

        #region f()
        private void AggiornaCheckedListBox()
        {
            checkedListBox1.DataSource = null;   // reset binding
            checkedListBox1.DataSource = _VID_DBs;
            checkedListBox1.DisplayMember = "Titolo";
            checkedListBox1.ValueMember = "FileName";
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

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion f()


        private void checkedListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int index = checkedListBox1.IndexFromPoint(e.Location);
            if (index >= 0 && index < checkedListBox1.Items.Count)
            {
                if (index != lastIndex) // evita di ricreare tooltip di continuo
                {
                    var item = (VideoFileDB)checkedListBox1.Items[index];
                    Point p = new Point(e.X, e.Y - 20); // sopra al cursore
                    toolTip1.Show(item.Cartella, checkedListBox1, p, 800);
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
