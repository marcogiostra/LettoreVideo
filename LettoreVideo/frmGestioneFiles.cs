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
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo
{
    public partial class frmGestioneFiles : Form
    {
        #region DICHIARAZIONI
        #region PARAMETRI
        private frmVideoNEW _owner;
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

        #region LISTAVISDEO_DB
        private List<VideoFileDB> VID_DBs = new List<VideoFileDB>();
        private string DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        private IEnumerable<VideoFileDB> filteredVIDs;
        #endregion LISTAVIDEO_DB

        private bool isLoading = true;

        #endregion DICHIARAZIONI

        #region Class
    

        public frmGestioneFiles(frmVideoNEW pOwner, ref List<VideoFileDB> pVID_DBs )
        {
            _owner = pOwner;
            _VID_DBs = pVID_DBs;

            InitializeComponent();

            lstFiles.ContextMenuStrip = cms;
        }

        private void frmGestioneFilecs_Load(object sender, EventArgs e)
        {
            this.Tag = "KO";
            timer1.Enabled = true;

        }
        #endregion Class

        #region f()

 
        public void UpdateListView()
        {
            PopateListView();
        }
        private void PopateListView()
        {
            lstFiles.Items.Clear();

            _VID_DBs = new List<VideoFileDB>(_VID_DBs.OrderBy(f => f.Titolo));

            foreach (VideoFileDB vid in _VID_DBs)
            {
                ListViewItem item = new ListViewItem(vid.Titolo);
                item.SubItems.Add(vid.Categoria);
                item.SubItems.Add(vid.Specifica);
                item.SubItems.Add(vid.FilenameOriginale);
                item.SubItems.Add(vid.Visto ? "SI" : "NO");
                lstFiles.Items.Add(item);
            }

            isLoading = false;
            FilterListView();
        }

        private void FilterListView()
        {
            if (isLoading)
                return;

            lstFiles.Items.Clear();
            //IEnumerable<VideoFileDB> filteredVIDs = _VID_DBs;
            filteredVIDs = _VID_DBs;
            if (rbtnOnlySI.Checked)
            {   
                filteredVIDs = filteredVIDs.Where(vid => vid.Visto);
            }
            else if (rbtnOnlyNO.Checked)
            {
                filteredVIDs = filteredVIDs.Where(vid => !vid.Visto);
            }
            else
                filteredVIDs = filteredVIDs.Where(vid => !string.IsNullOrEmpty(vid.FilenameOriginale));
            foreach (VideoFileDB vid in filteredVIDs)
            {
                ListViewItem item = new ListViewItem(vid.Titolo);
                item.SubItems.Add(vid.Categoria);
                item.SubItems.Add(vid.Specifica);
                item.SubItems.Add(vid.FilenameOriginale);
                item.SubItems.Add(vid.Visto ? "SI" : "NO");
                lstFiles.Items.Add(item);
            }
        }
        #endregion f()

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            PopateListView();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region LISTVIEW
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
        private void lstFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = lstFiles.HitTest(e.Location);

                if (hit.Item != null)
                    lstFiles.FocusedItem = hit.Item;   // seleziona l'item
                else
                    lstFiles.ContextMenuStrip = null; // niente popup
            }
        }

        private void lstFiles_MouseUp(object sender, MouseEventArgs e)
        {
            // Ripristino il menu dopo il click
            if (lstFiles.ContextMenuStrip == null)
                lstFiles.ContextMenuStrip = cms;
        }
        #endregion LISTVIEW

        #region MENU
        private void cms_Opening(object sender, CancelEventArgs e)
        {
            // Se non ci sono item → annullo il menu
            if (lstFiles.Items.Count == 0)
                e.Cancel = true;
        }
        private void tsmiModificaCateogria_Click(object sender, EventArgs e)
        {
            string categoria = string.Empty;
            if (lstFiles.SelectedItems.Count > 0)
            {
                int selectedIndex = lstFiles.SelectedIndices[0];

                categoria = lstFiles.SelectedItems[0].SubItems[1].Text;
                string filenameOriginale = lstFiles.SelectedItems[0].SubItems[3].Text;

                string answer = MyInputBox.Show("Aggiorna la categoria:", "Modifica dati", categoria).Trim();
                if (answer != string.Empty && answer  != categoria)
                {

                    _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.Categoria, filenameOriginale, answer);
                }

            }

        }
        private void tsmiUpdateSpecifica_Click(object sender, EventArgs e)
        {
            string specifica = string.Empty;
            if (lstFiles.SelectedItems.Count > 0)
            {
                int selectedIndex = lstFiles.SelectedIndices[0];

                specifica = lstFiles.SelectedItems[0].SubItems[2].Text;
                string filenameOriginale = lstFiles.SelectedItems[0].SubItems[3].Text;

                string answer = MyInputBox.Show("Aggiorna la sottocategoria:", "Modifica dati", specifica).Trim();
                if (answer != string.Empty && answer != specifica)
                {
                    _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.SottoCateogria, filenameOriginale, answer);
                }

            }
        }
        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler escludere il filmato selezionato dall'archivio?", "Conferma esclusione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2 ) == DialogResult.Yes)
            {
                int selectedIndex = lstFiles.SelectedIndices[0];
                string filenameOriginale = lstFiles.SelectedItems[0].SubItems[3].Text;
                _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.Deleteting, filenameOriginale, string.Empty);


            }
        }
        private void tsmiUpdateVisto_Click(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItems.Count > 0)
            {
                int selectedIndex = lstFiles.SelectedIndices[0];

                string filenameOriginale = lstFiles.SelectedItems[0].SubItems[3].Text;
                string answer = lstFiles.SelectedItems[0].SubItems[4].Text;
                _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.FlagVisto, filenameOriginale, answer);
            }
        }
        private void tsmiUpdateTitolo_Click(object sender, EventArgs e)
        {
            string titolo = string.Empty;
            if (lstFiles.SelectedItems.Count > 0)
            {
                int selectedIndex = lstFiles.SelectedIndices[0];

                titolo = lstFiles.SelectedItems[0].SubItems[0].Text;
                string filenameOriginale = lstFiles.SelectedItems[0].SubItems[3].Text;

                string answer = MyInputBox.Show("Aggiorna il titolo categoria:", "Modifica dati", titolo).Trim();
                if (answer != string.Empty && answer != titolo)
                {
                    _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.Titolo, filenameOriginale, answer);
                }

            }
        }
        #endregion MENU

        #region ZONA_FILTRO
        private void rbtnOnlySI_CheckedChanged(object sender, EventArgs e)
        {
            FilterListView();
        }

        private void rbtnALL_CheckedChanged(object sender, EventArgs e)
        {
            FilterListView();
        }

        private void rbtnOnlyNO_CheckedChanged(object sender, EventArgs e)
        {
            FilterListView();
        }
        #endregion ZONA_FILTRO

        #region PULSANTERIA
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion PULSANTERIA
    }
}