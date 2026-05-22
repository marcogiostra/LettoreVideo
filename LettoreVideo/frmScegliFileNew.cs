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
    public partial class frmScegliFileNew : Form
    {
        #region DICHIARAZIONI
        #region PARAMETRI
        private frmVideoNEW _owner;
        private List<VideoFileDB> _VID_DBs = new List<VideoFileDB>();
        #endregion PARAMATRI

        private BindingList<VideoFileDB> _l;
        private BindingList<VideoFileDBCheck> _lista;

        GridColumn col_Selezionato;
        GridColumn col_File;
        GridColumn col_Titolo;
        GridColumn col_Categoria;
        GridColumn col_Specifica;
        GridColumn col_FilenName;
        GridColumn col_FilenNameOriginale;
        GridColumn col_Visto;

        private BindingList<VideoFileDBCheck> _items = new BindingList<VideoFileDBCheck>();

        #region RETURN
        public List<VideoFile> rListaFinale { get; private set; }
        #endregion RETURN

        #endregion DICHIARAZIONI





        #region Class


        public frmScegliFileNew(frmVideoNEW pOwner, ref List<VideoFileDB> pVID_DBs )
        {

            _owner = pOwner;
            _VID_DBs = pVID_DBs;

            InitializeComponent();

            _l = new BindingList<VideoFileDB>(pVID_DBs.Select(x => new VideoFileDB()
            {
                File = x.File,
                Titolo = x.Titolo,
                Categoria = x.Categoria,
                Specifica = x.Specifica,
                Filename = x.Filename,
                FilenameOriginale = x.FilenameOriginale,
                Visto = x.Visto,

            }).ToList());

            _lista = new BindingList<VideoFileDBCheck>(_l
            .Select(x => new VideoFileDBCheck
            {
                File = x.File,
                Titolo = x.Titolo,
                Categoria = x.Categoria,
                Specifica = x.Specifica,
                Filename = x.Filename,
                FilenameOriginale = x.FilenameOriginale,
                Visto = x.Visto,
                Selezionato = false

            }).ToList());


        }

        private void frmScegliFileNew_Load(object sender, EventArgs e)
        {
            this.Tag = "KO";

            InitGrid();

            timer1.Enabled = true;
        }
        #endregion Class


        #region f()
        private void InitGrid()
        {
            gridView1.OptionsBehavior.AutoPopulateColumns = false;
            gridView1.Columns.Clear();

            gridView1.Columns.AddVisible("Selezionato", "Sel");
            col_Selezionato = gridView1.Columns["Selezionato"];
            col_Selezionato.Visible = true;

            gridView1.Columns.AddVisible("File", "file");
            col_File = gridView1.Columns["File"];
            col_File.Visible = false;
            col_File.OptionsColumn.ReadOnly = true;

            gridView1.Columns.AddVisible("Titolo", "Titolo");
            col_Titolo = gridView1.Columns["Titolo"];
            col_Titolo.OptionsColumn.ReadOnly = true;

            gridView1.Columns.AddVisible("Categoria", "Categoria");
            col_Categoria = gridView1.Columns["Categoria"];
            col_Categoria.OptionsColumn.ReadOnly = true;

            gridView1.Columns.AddVisible("Specifica", "Specifica");
            col_Specifica = gridView1.Columns["Specifica"];
            col_Specifica.OptionsColumn.ReadOnly = true;

            gridView1.Columns.AddVisible("Filename", "Filename");
            col_FilenName = gridView1.Columns["Filename"];
            col_FilenName.Visible = false;
            col_FilenName.OptionsColumn.ReadOnly = true;

            gridView1.Columns.AddVisible("FilenameOriginale", "FilenameOriginale");
            col_FilenNameOriginale = gridView1.Columns["FilenameOriginale"];
            col_FilenNameOriginale.Visible = false;
            col_FilenNameOriginale.OptionsColumn.ReadOnly = true;

            gridView1.Columns.AddVisible("Visto", "Visto");
            col_Visto = gridView1.Columns["Visto"];
            col_Visto.OptionsColumn.ReadOnly = true;

        }
        private void Populate()
        {
            gridControl1.DataSource = _lista;
        }

        private void AddSelectedItemToList()
        {
            foreach(VideoFileDBCheck v in _lista)
            {
                if (v.Selezionato)
                {
                    VideoFileDBCheck riga = v;

                    _items.Add(v);

                    v.Selezionato = false;
                }
            }

  
        }

        #endregion f()


        #region PULSANTERIA
        private void picPlus_Click(object sender, EventArgs e)
        {
            AddSelectedItemToList();
            lblTotale.Text = _items.Count.ToString();
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            _items = new BindingList<VideoFileDBCheck>(_items.GroupBy(x => x.FilenameOriginale).Select(g => g.First()).ToList());

            if (_items.Count> 0)
            {
                int index = 0;
                BindingList<VideoFileDB> _listaDBSelezionati = new BindingList<VideoFileDB>( _items.Cast<VideoFileDB>().ToList());
                BindingList<VideoFile> _listaSelezionati = new BindingList<VideoFile>(_listaDBSelezionati
               .Select(x => new VideoFile
               {
                   File = x.File,
                   Titolo = x.Titolo,
                   Categoria = x.Categoria,
                   Specifica = x.Specifica,
                   Filename = x.Filename,
                   FilenameOriginale = x.FilenameOriginale,
                   Visto = x.Visto,
                   Saved = true,
                   ID = ++index

               }).ToList());
                List<VideoFile> listaR = _listaSelezionati.ToList();
                rListaFinale = listaR;
                this.Tag = "OK";
                this.Close();
            }

           
        }

        private void picSaveAndPlay_Click(object sender, EventArgs e)
        {
            _items = new BindingList<VideoFileDBCheck>(_items.GroupBy(x => x.FilenameOriginale).Select(g => g.First()).ToList());

            if (_items.Count > 0)
            {
                int index = 0;
                BindingList<VideoFileDB> _listaDBSelezionati = new BindingList<VideoFileDB>(_items.Cast<VideoFileDB>().ToList());
                BindingList<VideoFile> _listaSelezionati = new BindingList<VideoFile>(_listaDBSelezionati
               .Select(x => new VideoFile
               {
                   File = x.File,
                   Titolo = x.Titolo,
                   Categoria = x.Categoria,
                   Specifica = x.Specifica,
                   Filename = x.Filename,
                   FilenameOriginale = x.FilenameOriginale,
                   Visto = x.Visto,
                   Saved = true,
                   ID = ++index

               }).ToList());
                List<VideoFile> listaR = _listaSelezionati.ToList();
                rListaFinale = listaR;
                this.Tag = "OK+PLAY";
                this.Close();
            }
          
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Populate();
        }
        #endregion PULSANTERIA

        /*
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            VideoFileDBCheck riga = (VideoFileDBCheck)gridView1.GetRow(e.RowHandle);

        }
        */
    }
}

