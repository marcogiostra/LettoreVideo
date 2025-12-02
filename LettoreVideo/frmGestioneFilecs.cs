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
    public partial class frmGestioneFilecs : MaterialForm
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

        public frmGestioneFilecs(ref List<VideoFileDB> pVID_DBs)
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

            lstFiles.ContextMenuStrip = cms;
        }

        private void frmGestioneFilecs_Load(object sender, EventArgs e)
        {
            this.Tag = "KO";
            timer1.Enabled = true;

        }
        #endregion Class

        #region f()

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
                    foreach (var vid in _VID_DBs)
                    {
                        if (vid.FilenameOriginale == filenameOriginale)
                        {
                            vid.Categoria = answer;
                            break;
                        }
                    }
                    JsonOperation.Save_DB(_VID_DBs,DataFolder);
                    PopateListView();

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
                    foreach (var vid in _VID_DBs)
                    {
                        if (vid.FilenameOriginale == filenameOriginale)
                        {
                            vid.Specifica = answer;
                            break;
                        }
                    }
                    JsonOperation.Save_DB(_VID_DBs, DataFolder);
                    PopateListView();

                }

            }
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler eliminare il file selezionato?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2 ) == DialogResult.Yes)
            {
                if (lstFiles.SelectedItems.Count > 0)
                {
                    int selectedIndex = lstFiles.SelectedIndices[0];
                    foreach (var vid in _VID_DBs)
                    {
                        if (vid.FilenameOriginale == lstFiles.SelectedItems[0].SubItems[3].Text)
                        {
                            // Elimina il file fisico se esiste
                            string filePath = Path.Combine(DataFolder, vid.FilenameOriginale);
                            _VID_DBs.Remove(vid);
                            break;
                        }
                    }
                    JsonOperation.Save_DB(_VID_DBs, DataFolder);
                    PopateListView();
                }
            }
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

        private void cms_Opening(object sender, CancelEventArgs e)
        {
            // Se non ci sono item → annullo il menu
            if (lstFiles.Items.Count == 0)
                e.Cancel = true;
        }

  
    }
}