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
    public partial class frmScegliFiles : MaterialForm
    {
        #region DICHIARAZIONI
        #region PARAMETRI
        private List<VideoFileDB> _VID_DBs = new List<VideoFileDB>();
        #endregion PARAMATRI

        private List<VideoFile> _items = new List<VideoFile>();
        private int index = 0;

        private readonly MaterialSkinManager materialSkinManager;
        private System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
        private int lastIndex = -1;
        bool isDark = false;

        #region RETURN
        public List<VideoFile> rListaFinale { get; private set; }
        #endregion RETURN

        #region LISTaVISDEO_DB
        private List<VideoFileDB> VID_DBs = new List<VideoFileDB>();
        private string DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        #endregion LISTAVIDEO_DB
        #endregion DICHIARAZIONI

        #region Class
        public frmScegliFiles(List<VideoFileDB> pVID_DBs)
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

           

            isDark = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK;
            lstFiles.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            lstFiles.ForeColor = isDark ? Color.White : Color.Black;
            cmbCartelle.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            cmbCartelle.ForeColor = isDark ? Color.White : Color.Black;
            rbtnCartella.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            rbtnCartella.ForeColor = isDark ? Color.White : Color.Black;
            rbtnAll.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            rbtnAll.ForeColor = isDark ? Color.White : Color.Black;
            lblTotale.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            lblTotale.ForeColor = isDark ? Color.White : Color.Black;
            label2.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            label2.ForeColor = isDark ? Color.White : Color.Black;

            rbtnAll.Checked = false;
            rbtnCartella.Checked = false; ;
            var categorie = _VID_DBs.Select(v => v.Categoria).Distinct().ToList();
            cmbCartelle.DataSource = categorie;
            cmbCartelle.SelectedIndex = -1;
            rbtnCartella.Checked = true;
        }

        private void frmScegliFiles_Load(object sender, EventArgs e)
        {
            //AggiornaCheckedListBoxWithALL();
            this.Tag = "KO";
        }
        #endregion Class

        #region f()
        private void AggiornaCheckedListBoxWithALL()
        {
            lstFiles.Items.Clear();
            _VID_DBs = new List<VideoFileDB>(_VID_DBs.OrderBy(f => f.Titolo));

            foreach(VideoFileDB vid in _VID_DBs)
            {
                ListViewItem item = new ListViewItem(vid.Titolo);
                item.SubItems.Add(vid.Categoria);
                item.SubItems.Add(vid.Specifica);
                item.SubItems.Add(vid.FilenameOriginale);
                lstFiles.Items.Add(item);   
            }
        }

        private void CheckAllItems(ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
                item.Checked = true;
        }
        
    

        private void UncheckAllItems(ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
                item.Checked = false;
        }

        private void AddSelectedItemToList()
        {
            // Colleziono gli item selezionati (CheckedItems) in una lista temporanea
            var Stelezionati = lstFiles.CheckedItems.Cast<ListViewItem>().ToList(); 

            if (Stelezionati.Count == 0)
                return;

            // Rimuovo dalla lista originale
            foreach (var item in Stelezionati)
            {
                string col1 = item.SubItems[0].Text;
                string col2 = item.SubItems[1].Text;
                string col3 = item.SubItems[2].Text;
                string col4 = item.SubItems[3].Text;

                foreach (VideoFileDB vid in _VID_DBs)
                {
                    if (vid.FilenameOriginale == col4)
                    {
                        VideoFile v = new VideoFile();
                        v.Categoria = vid.Categoria;
                        v.Specifica = vid.Specifica;
                        v.Saved = true;
                        index++;
                        v.ID = index;
                        v.FilenameOriginale = vid.FilenameOriginale;
                        v.Filename = PathHelper.RestoreFullPath(vid.FilenameOriginale);
                        v.File = vid.File;
                        v.Titolo = vid.Titolo;

                        _items.Add(v);
                        lblTotale.Text = _items.Count.ToString();

                    }
                }
            
            }

            // Rinfresco il CheckedListBox
            if(rbtnAll.Checked)
                AggiornaCheckedListBoxWithALL();
            else
            {
                AggiornaCheckListBoxFromCartella();
            }
        }

        private void AggiornaCheckListBoxFromCartella()
        {
            if (!rbtnAll.Checked)
            {
                lstFiles.Items.Clear();
                if (cmbCartelle.SelectedIndex != -1)
                {
                    var selectedFolder = cmbCartelle.SelectedItem.ToString();
                    var filteredVideos = _VID_DBs.Where(v => v.Categoria == selectedFolder).ToList();

                    foreach (VideoFileDB vid in filteredVideos)
                    {
                        ListViewItem item = new ListViewItem(vid.Titolo);
                        item.SubItems.Add(vid.Categoria);
                        item.SubItems.Add(vid.Specifica);
                        item.SubItems.Add(vid.FilenameOriginale);
                        lstFiles.Items.Add(item);
                    }
                }
            }
            
            
        }
        #endregion f()

        #region PULSANTIERA
        private void picCheckAll_Click(object sender, EventArgs e)
        {
            CheckAllItems(lstFiles );
        }

        private void picUncheckAll_Click(object sender, EventArgs e)
        {

            UncheckAllItems(lstFiles);

        }

        private void picPlus_Click(object sender, EventArgs e)
        {
            AddSelectedItemToList(); 
            UncheckAllItems(lstFiles);
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            rListaFinale = _items;
            this.Tag = "OK";
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion PULSANTIERA

     
        private void cmbCartelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbtnCartella.Checked)
            {
                AggiornaCheckListBoxFromCartella();
            }
        }

        private void rbtnCartella_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCartella.Checked)
            {
                AggiornaCheckListBoxFromCartella();
            }
            else
            {
                AggiornaCheckedListBoxWithALL();

            }
        }

        private void lstFiles_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Colori coerenti con quelli che hai usato per gli altri controlli
            Color backColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            Color textColor = isDark ? Color.White : Color.Black;

            using (var brush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(brush, e.Bounds);

            TextRenderer.DrawText(
                e.Graphics,
                e.Header.Text,
                e.Font,
                e.Bounds,
                textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );
        }

        private void lstFiles_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Necessario ma non disegna nulla perché ci pensano le subitem
        }

        private void lstFiles_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true; // Usa il rendering standard per le righe
        }
    
    }
}

