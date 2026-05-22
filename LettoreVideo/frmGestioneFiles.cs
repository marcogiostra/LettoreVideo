using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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

        private BindingList<VideoFileDB> _lista;


        GridColumn col_File;
        GridColumn col_Titolo;
        GridColumn col_Categoria;
        GridColumn col_Specifica;
        GridColumn col_FilenName;
        GridColumn col_FilenNameOriginale;
        GridColumn col_Visto;
        #endregion DICHIARAZIONI

        #region Class


        public frmGestioneFiles(frmVideoNEW pOwner, ref List<VideoFileDB> pVID_DBs )
        {
           

            _owner = pOwner;
            _VID_DBs = pVID_DBs;
          

            InitializeComponent();

            
        }

  

        private void frmGestioneFilecs_Load(object sender, EventArgs e)
        {
            this.Tag = "KO";
            
            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView1.Columns.Clear();

            gridView1.Columns.AddVisible("File", "file");
            col_File = gridView1.Columns["File"];
            col_File.Visible = false;

            gridView1.Columns.AddVisible("Titolo", "Titolo");
            col_Titolo = gridView1.Columns["Titolo"];

            gridView1.Columns.AddVisible("Categoria", "Categoria");
            col_Categoria = gridView1.Columns["Categoria"];

            gridView1.Columns.AddVisible("Specifica", "Specifica");
            col_Specifica = gridView1.Columns["Specifica"];

            gridView1.Columns.AddVisible("Filename", "Filename");
            col_FilenName = gridView1.Columns["Filename"];
            col_FilenName.Visible = false;

            gridView1.Columns.AddVisible("FilenameOriginale", "FilenameOriginale");
            col_FilenNameOriginale = gridView1.Columns["FilenameOriginale"];
            col_FilenNameOriginale.Visible = false;

            gridView1.Columns.AddVisible("Visto", "Visto");
            col_Visto = gridView1.Columns["Visto"];

            



            timer1.Enabled = true;
        }
        #endregion Class

        #region f()


        public void Populate(List<VideoFileDB> pVID_DBs)
        {

            _lista = new BindingList<VideoFileDB>(pVID_DBs
            .Select(x => new VideoFileDB()
            {
                File = x.File,
                Titolo = x.Titolo,
                Categoria = x.Categoria,
                Specifica = x.Specifica,
                Filename = x.Filename,
                FilenameOriginale = x.FilenameOriginale,
                Visto = x.Visto,

            })
            .ToList()
    );

            gridControl1.DataSource = _lista;
       
            isLoading = false;
        }

 
        #endregion f()

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Populate(_VID_DBs);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

        #region MENU
        private void cms_Opening(object sender, CancelEventArgs e)
        {
            // Se non ci sono item → annullo il menu
            if (_lista.Count == 0)
                e.Cancel = true;
        }
   
  
        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler escludere il filmato selezionato dall'archivio?", "Conferma esclusione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2 ) == DialogResult.Yes)
            {
                VideoFileDB  riga = (VideoFileDB)gridView1.GetFocusedRow();

                if (riga == null)
                    return;

                _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.Deleteting, riga.FilenameOriginale , string.Empty);


            }
        }
    
     
        #endregion MENU
      
        #region PULSANTERIA
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion PULSANTERIA

        #region GRIDVIEW
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            VideoFileDB riga = (VideoFileDB)gridView1.GetRow(e.RowHandle);

            foreach (VideoFileDB item in _VID_DBs)
            {
                if (item.FilenameOriginale == riga.FilenameOriginale)
                {
                    if (item.Titolo != riga.Titolo && !string.IsNullOrEmpty(riga.Titolo))
                    {
                        item.Titolo = riga.Titolo;
                        _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.Titolo, riga.FilenameOriginale, item.Titolo);
                    }

                    if (item.Categoria != riga.Categoria && !string.IsNullOrEmpty(riga.Categoria))
                    {
                        item.Categoria = riga.Categoria;
                        _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.Categoria, riga.FilenameOriginale, item.Categoria);
                    }

                    if (item.Specifica != riga.Specifica && !string.IsNullOrEmpty(riga.Specifica))
                    {
                        item.Specifica = riga.Specifica;
                        _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.SottoCateogria, riga.FilenameOriginale, item.Specifica);
                    }

                    if (item.Visto != riga.Visto )
                    {
                        item.Visto = riga.Visto;
                        _owner.External_UPDATE_ITEM_ARCHIVIO(TipoUpdateItem.FlagVisto, riga.FilenameOriginale, item.Visto ? "SI" : "NO");
                    }                   
                    break;
                }
            }
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            // Solo sulle righe
            if (e.MenuType != GridMenuType.Row)
                return;

            // Blocca menu DevExpress
            e.Allow = false;

            // Focus riga cliccata
            gridView1.FocusedRowHandle =           e.HitInfo.RowHandle;

            // Mostra menu standard WinForms
            cms.Show(Cursor.Position);
        }
        #endregion GRIDVIEW
    }
}