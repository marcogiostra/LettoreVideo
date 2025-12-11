using LettoreVideo.Classi;
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
    public partial class frmBookmarkStudio : Form
    {
        #region DICHIARAZIONI
        #region PARAMTRI
        private frmVideoNEW _ownerVIEWER;
        private LibVLCSharp.Shared.MediaPlayer _mp;
        private List<Bookmark> _Bookmarks = new List<Bookmark>();
        private  string _FilenameOriginale { get; set; }
        #endregion PARAMETRI

        #region RETURN
        public List<Bookmark> rBookmarks;
        #endregion RETURN
        Form _owner = new Form();
        /*
        private long  TimeCurrent 
        {
            get
            {
                try
                {
                    long total = _mp.Length; // durata totale in ms
                    if (total == 0) return 0;        // protezione divisione per zero

                    return (int)(_mp.Time * 1000 / total);

                }
                catch (Exception)
                {
                    return 0;
                }
            } 
        }
        private string TimeString 
        {
            get
            {
                long current = _mp.Time;
                long total = _mp.Length;


                if (current > 0 && total >= 0)
                {
                    TimeSpan durata = TimeSpan.FromMilliseconds(current);
                    return durata.ToString(@"hh\:mm\:ss");

                }
                else
                {
                    return string.Empty;
                }


            }
        }
        */

        #endregion DICHIARAZIONI

        #region Class
        public frmBookmarkStudio(frmVideoNEW pOwner, LibVLCSharp.Shared.MediaPlayer pMP, List<Bookmark> pBookmarks, string pFilenameOriginale)
        {
            _ownerVIEWER = pOwner;
            _mp = pMP;
            _Bookmarks = pBookmarks;
            _FilenameOriginale = pFilenameOriginale;    

            InitializeComponent();

            this.Location = new Point(pOwner.Width - this.Width - 200, (pOwner.Height - this.Height) / 2);


        }

        private void frmBookmarkStudio_Load(object sender, EventArgs e)
        {
            this.Tag = "KO";
            timer1.Enabled = true;

        }
        #endregion Class

        #region f()

        public void SetOwner(Form owner)
        {
            if (owner != null)
            {
                _owner.Owner = owner;
            }
        }
        private void Popola()
        {
            if (_Bookmarks == null)
                _Bookmarks = new List<Bookmark>();

            lstBookMark.DataSource = null;   // reset binding
            lstBookMark.DataSource = _Bookmarks;
            lstBookMark.DisplayMember = "TimeString";
            lstBookMark.ValueMember = "Time";

            lstBookMark.SelectedIndex = _Bookmarks.Count > 0 ? 0 : -1;
        }
        #endregion f()

        #region PULSANTIERA
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void picPlus_Click(object sender, EventArgs e)
        {
            long current = _mp.Time;
            long total = _mp.Length;
            if (current > 0 && total >= 0)
            {
                TimeSpan durata = TimeSpan.FromMilliseconds(current);
                string elapsedTime = durata.ToString(@"hh\:mm\:ss");

                Bookmark b = new Bookmark();
                b.Time = current;
                b.TimeString = elapsedTime;
                _Bookmarks.Add(b);
                _Bookmarks = _Bookmarks.OrderBy(i => i.Time).ToList();
                Popola();

            }
        }

      

        private void picCancella_Click(object sender, EventArgs e)
        {
            _Bookmarks.RemoveAt(lstBookMark.SelectedIndex);
        }
        private void picSave_Click(object sender, EventArgs e)
        {
            _ownerVIEWER.SalvaBookmarks(_FilenameOriginale, _Bookmarks); 
            this.Close();
        }
        #endregion PULSANTIERA

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Popola();
            lstBookMark.Focus();
        }

        private void frmBookmarkStudio_Resize(object sender, EventArgs e)
        {
        
            this.Location = new Point(_ownerVIEWER.Width - this.Width - 20, (_ownerVIEWER.Height - this.Height) / 2);
        }
    }
}

