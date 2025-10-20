//using static System.Net.Mime.MediaTypeNames;
using LettoreVideo.Classi;
using LettoreVideo.Controlli;
using LettoreVideo.Utility;
using LibVLCSharp.Shared;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LettoreVideo.OverLayForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LettoreVideo

{
    public enum VideoPlayAction
    {
        Pause = 0,
        Play = 1,
        Stop = 2,

        FastBackward = 3,
        FastNext = 4,

        Previous = 5,
        Next = 6,
        DaCapo = 7


    }

    public partial class frmVideo : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        /*OVERLAY_DICHIARAZIONI
        #region OVERLAY_DICHIARAZIONI
        private OverLayForm overlay;
        private OverLayForm.OverlayType overlayType;
        private int overlayPixelMisure;
        private Timer mouseTimer;
        #endregion OVERLAY_DICHIARAZIONI
        */

        #region DICHIARAZIONI
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        #region LISTAVIDEO
        private List<VideoFile> VIDs = new List<VideoFile>();
        private int Index { get; set; }
        private int Totale { get; set; }
        #endregion LISTAVIDEO

        #region LISTaVISDEO_DB
        private List<VideoFileDB> VID_DBs = new List<VideoFileDB>();
        private string DataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        #endregion LISTAVIDEO_DB

        #region CONFIG_ETC
        string dirVideo { get; set; }
        Config config = new Config();
        #endregion CONFIG_ETC

        #region VIDEO
        //VLC stuff
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public Media media;

        public bool isFullscreen = false;
        public bool isPlaying = false;
        public Size oldVideoSize;
        public Size oldFormSize;
        public Point oldVideoLocation;

        #endregion VIDEO

        OverlayFormFlottante overlay;

        bool IsMUte = false;

        #endregion DICHIARAZIONI

        #region Class
        public frmVideo()
        {
            InitializeComponent();

            InizializzaLista();


            //Configuro MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // Dark Mode
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Orange200, TextShade.WHITE
            );




            //Inizializzazione VLC
            InizializzaVLC();

            //Inizializza la lettura del file di configurazione
            config.cfgFile = "MyConfig.config";
            dirVideo = config.GetValue("//appDIR//add[@key='DIR_VIDEO']");

            // Crei un manager pe tooltip
            TooltipManager2 tooltip = new TooltipManager2();
            tooltip.SetTooltip(picOpenFile, "Seleziona nuovi file da aggiungere alla play-list.",false);
            tooltip.SetTooltip(picOpenDirectory, "Seleziona la cartella per aggiungere nuovi file da aggiungere alla play-list.", false);

            /* OVERLAY_INIZIALIZZAZIONE
            #region OVERLAY_INIZIALIZZAZIONE
            this.Move += (s, e) => UpdateOverlayPosition();
            this.Resize += (s, e) => UpdateOverlayPosition();
            overlayType = OverlayType.Top;
            overlayPixelMisure = 60;
            #endregion OVERLAY_INIZIALIZZAZIONE
            */

            Icon myIcon = LettoreVideo.Properties.Resources.Movie;
            this.Icon = myIcon;

            // Forza l'icona sulla taskbar
            TaskbarIconHelper.SetTaskbarIcon(this, myIcon);
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            try
            {
                // Controllo e creazione se non esiste
                if (!Directory.Exists(DataFolder))
                {
                    Directory.CreateDirectory(DataFolder);
                }               
                string DbFile = Path.Combine(DataFolder, "db.json");
                if (File.Exists(DbFile))
                {
                    string json = File.ReadAllText(DbFile);
                    Export exportObj = JsonConvert.DeserializeObject<Export>(json);
                    VID_DBs = exportObj.Data;

                }
            }
            catch (Exception ex)
            {
                PRG.MsgBoxERR(ex, "Errore nella procedura di lettura dei file dall'archivio:\r\n\r\n");

            }
            timer2.Enabled = true;
        }

        private void frmVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            VideoAction(VideoPlayAction.Stop);
        }

        private void frmVideo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (isPlaying)
                    VideoAction(VideoPlayAction.Pause);
                else
                    VideoAction(VideoPlayAction.Play);
            }
        }

        private void frmVideo_Resize(object sender, EventArgs e)
        {
            int margin = 5; // padding interno del FlowLayoutPanel
            int remainingWidth = flowLayoutPanelBotton.ClientSize.Width - mediaSeekBar1.Width - txtTotalTime.Width - margin * 4;

            mediaSeekBar1.Width = Math.Max(50, remainingWidth); // il penultimo cresce
            txtTotalTime.Location = new Point(flowLayoutPanelBotton.ClientSize.Width - txtTotalTime.Width - margin, txtTotalTime.Location.Y); // ultimo a destra
        }
        #endregion Class

        /* OVERLAY_EVENT_WITH_PROCEDURE
        #region OVERLAY_EVENT_WITH_PROCEDURE
        private void MouseTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (overlay == null) return;

                Point mousePos = this.PointToClient(Cursor.Position);

                if (overlayType == OverLayForm.OverlayType.Botton)
                {
                    if (mousePos.Y >= this.ClientSize.Height - overlayPixelMisure) // zona sensibile in basso
                    {
                        if (!overlay.Visible)
                        {
                            UpdateOverlayPosition();
                            overlay.Show();
                        }
                    }
                    else
                    {
                        if (overlay.Visible)
                            overlay.Hide();
                    }
                }
                else if (overlayType == OverLayForm.OverlayType.Right)
                {
                    if (mousePos.X >= this.ClientSize.Width - overlayPixelMisure) // zona sensibile a destra
                    {
                        if (!overlay.Visible)
                        {
                            UpdateOverlayPosition();
                            overlay.Show();
                        }
                    }
                    else
                    {
                        if (overlay.Visible)
                            overlay.Hide();
                    }
                }
                else if (overlayType == OverLayForm.OverlayType.Left)
                {
                    if (mousePos.X <= 60)
                    {
                        if (!overlay.Visible)
                        {
                            UpdateOverlayPosition();
                            overlay.Show();
                        }
                    }
                    else
                    {
                        if (overlay.Visible)
                            overlay.Hide();
                    }
                }
                else if (overlayType == OverLayForm.OverlayType.Top)
                {
                    if (mousePos.Y <= 60)
                    {
                        if (!overlay.Visible)
                        {
                            UpdateOverlayPosition();
                            overlay.Show();
                        }
                    }
                    else
                    {
                        if (overlay.Visible)
                            overlay.Hide();
                    }
                }    
            }
            catch (Exception) { }
           
        }
        private void UpdateOverlayPosition()
        {
            try
            {
                if (overlay == null) return;

                var screenPos = this.PointToScreen(Point.Empty);
                if (overlayType == OverLayForm.OverlayType.Botton)
                {
                    overlay.Location = new Point(screenPos.X, screenPos.Y + this.ClientSize.Height - overlay.Height);
                    overlay.Width = this.ClientSize.Width;
                }
                else if (overlayType == OverLayForm.OverlayType.Right)
                {
                    overlay.Location = new Point(screenPos.X + this.ClientSize.Width - overlay.Width,
                                                  screenPos.Y);
                    overlay.Height = this.ClientSize.Height;
                }
                else if (overlayType == OverLayForm.OverlayType.Left)
                {
                    overlay.Location = new Point(screenPos.X, screenPos.Y);
                    overlay.Height = this.ClientSize.Height;

                }
                else if (overlayType == OverLayForm.OverlayType.Top)
                {
                    overlay.Location = new Point(screenPos.X, screenPos.Y);
                    overlay.Width = this.ClientSize.Width;
                }

            }
            catch (Exception) { }
       
        }

        private void InizializzaOverLAy()
        {
            overlay = new OverLayForm(this, overlayType, overlayPixelMisure, 0.7);
            mouseTimer = new Timer { Interval = 200 };
            mouseTimer.Tick += MouseTimer_Tick;
            mouseTimer.Start();

        }
        #endregion OVERLAY_EVENT_W§ITH_PROCEDURE
        */

        #region f()_FONT

        public void LoadCustomFont()
        {
            // Recupera il font come risorsa incorporata
            var fontStream = GetType().Assembly.GetManifestResourceStream("LettoreVideo.digifacewide-regular.ttf");
            if (fontStream != null)
            {
                // Copia i dati del font in memoria
                byte[] fontData = new byte[fontStream.Length];
                fontStream.Read(fontData, 0, fontData.Length);
                fontStream.Close();

                // Crea un buffer in memoria
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                // Aggiungi il font alla collezione
                privateFontCollection.AddMemoryFont(fontPtr, fontData.Length);

                // Libera la memoria non gestita
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            }
            else
            {
                MessageBox.Show("Font non trovato nelle risorse incorporate.");
            }
        }

        #endregion f()_FONT

        #region f()

        public int VideoControlWidth()
        {
            return videoView1.Width;
        }
        private void InizializzaLista()
        {
             VIDs = new List<VideoFile>();
            Index = -1;
            Totale = 0;
            //NOTA: Totale = VIDs.Count;

        }

        private void InizializzaVLC()
        {
            Core.Initialize();
            oldVideoSize = videoView1.Size;
            oldFormSize = this.Size;
            oldVideoLocation = videoView1.Location;
            //VLC stuff
            _libVLC = new LibVLC();
            Application.DoEvents();
            _mp = new MediaPlayer(_libVLC);
            Application.DoEvents();
            videoView1.MediaPlayer = _mp;
            Application.DoEvents();
        }
        private void AggiornaBranoSuovato()
        {
            if (Index > -1 && Totale > 0)
                txtContaBrani.Text = (Index + 1).ToString() + " / " + Totale.ToString();
            else
                txtContaBrani.Text = "-";

        }
        #endregion f()

        #region PULSANTERIA
        #region VIDEOREGISTRATORE

        private void picMusicaDaCApo_Click(object sender, EventArgs e)
        {
            VIDEO_DA_CAPO();
        }

        private void picMusicalePrecedente_Click(object sender, EventArgs e)
        {
            VIDEO_PRECEDENTE();
        }

        private void picMusicaleIndietroVeloce_Click(object sender, EventArgs e)
        {
            VIDEO_INDIETRO_VELOCE();
        }

        private void picMusicalePlay_Click(object sender, EventArgs e)
        {
            VIDEO_PLAY();
        }

        private void picMusicxalePausa_Click(object sender, EventArgs e)
        {
            VIDEO_PAUSA();
        }

        private void picMusicaleStopRosso_Click(object sender, EventArgs e)
        {
            VIDEO_STOP();
        }

        private void picMusicaleAvantiVeloce_Click(object sender, EventArgs e)
        {
            VIDEO_AVANTI_VELOCE();
        }

        private void picMusicaleNext_Click(object sender, EventArgs e)
        {
            VIDEO_NEXT();
        }


        #endregion VIDEOREGISTRATORE

        #region f()_PULSANTERIA_VIDEO_REGISTRATORE
        private void VIDEO_DA_CAPO()
        {
            VideoAction(VideoPlayAction.DaCapo);
        }

        private void VIDEO_PRECEDENTE()
        {
            if (isPlaying)
                VideoAction(VideoPlayAction.Previous);
        }

        private void VIDEO_INDIETRO_VELOCE()
        {
            VideoAction(VideoPlayAction.FastBackward);
        }

        private void VIDEO_PLAY()
        {
            if (VIDs.Count > 0)
            {

                if (!isPlaying)
                {
                    if (File.Exists(VIDs[Index].Filename))
                    {
                        AggiornaBranoSuovato();
                        //
                        timer1.Enabled = true;
                        //
                        _mp = new MediaPlayer(_libVLC);
                        videoView1.MediaPlayer = _mp;
                        videoView1.MediaPlayer.TimeChanged += _mp_TimeChanged;
                        PlayFile(VIDs[Index].Filename);
                        Application.DoEvents();

                    }
                    else
                    {
                        if (VIDs.Count > 1)
                        {
                            PRG.MsgBox("Questo video non è disponibile.\r\nPassa ad un altro file!");

                        }
                        else
                        {
                            PRG.MsgBox("Questo video non è disponibil1!");
                        }
                        return;
                    }

                }
                else
                {
                    if (_mp.State != VLCState.Playing)
                        VideoAction(VideoPlayAction.Play);
                    else
                        VideoAction(VideoPlayAction.Pause);
                }
            }
        }

        private void VIDEO_PAUSA()
        {
            VideoAction(VideoPlayAction.Pause);
        }

        private void VIDEO_STOP()
        {
            VideoAction(VideoPlayAction.Stop);
        }

        private void VIDEO_AVANTI_VELOCE()
        {
            VideoAction(VideoPlayAction.FastNext);
        }

        private void VIDEO_NEXT()
        {
            if (isPlaying)
                VideoAction(VideoPlayAction.Next);
        }
        #endregion f()_PULSANTERIA_VIDEO_REGISTRATORE

        #endregion PULSANTERIA

        public void VideoAction(VideoPlayAction pVPA)
        {
            if (isPlaying)
            {
                switch (pVPA)
                {
                    case VideoPlayAction.Pause:
                        timer1.Enabled = false;
                        if (_mp.State == VLCState.Playing)
                        {
                            _mp.Pause();
                        }
                        break;



                    case VideoPlayAction.Play:
                        timer1.Enabled = true;
                        if (!(_mp.State == VLCState.Playing))
                        {
                            _mp.Play();
                        }
                        break;

                    case VideoPlayAction.Stop:
                        timer1.Enabled = false;
                        _mp.Dispose();
                        isPlaying = false;
                        break;

                    case VideoPlayAction.FastBackward:
                        _mp.Position -= 0.02f;
                        break;

                    case VideoPlayAction.FastNext:
                        _mp.Position += 0.02f;
                        break;

                    case VideoPlayAction.Previous:                        
                        if (Index == 0)
                        {
                            _mp.Position = 0.00f;
                        }
                        else
                        {
                            Index -= 1;
                            if (File.Exists(VIDs[Index].Filename))
                            {
                                _mp.Dispose();
                                isPlaying = false;
                                AggiornaBranoSuovato();
                                _mp = new MediaPlayer(_libVLC);
                                videoView1.MediaPlayer = _mp;
                                PlayFile(VIDs[Index].Filename);
                            }
                            else
                            {
                                if (VIDs.Count > 1)
                                {
                                    PRG.MsgBox("Questo video non è disponibile.\r\nPassa ad un altro file!");
                                }
                                else
                                {
                                    PRG.MsgBox("Questo video non è disponibil1!");
                                }
                                return;
                            }

                        }
                        break;

                    case VideoPlayAction.Next:
                        if (Index < VIDs.Count - 1)
                        {
                            Index += 1;
                            if (File.Exists(VIDs[Index].Filename))
                            {
                                _mp.Dispose();
                                isPlaying = false;
                                AggiornaBranoSuovato();
                                _mp = new MediaPlayer(_libVLC);
                                videoView1.MediaPlayer = _mp;
                                PlayFile(VIDs[Index].Filename);
                            }
                            else
                            {
                                if (VIDs.Count > 1)
                                {
                                    PRG.MsgBox("Questo video non è disponibile.\r\nPassa ad un altro file!");
                                }
                                else
                                {
                                    PRG.MsgBox("Questo video non è disponibil1!");
                                }
                                return;
                            }

                        }
                        break;

                    case VideoPlayAction.DaCapo:
                        _mp.Position = 0.00f;
                        if (_mp.State != VLCState.Playing)
                            VideoAction(VideoPlayAction.Play);
                        break;
                }

            }

        }

        public void PlayFile(string file)
        {
            //_mp.SetRate((float)Decimal.Divide(1, Decimal.Divide(10, updw.Value)));
            switch (knobVelocita.Value)
            {
                case 0:
                    _mp.SetRate(1);
                    Application.DoEvents();
                    break;

                case int n when n > 0:
                    _mp.SetRate(1 * knobVelocita.Value);
                    Application.DoEvents();
                    break;

                case int n when n < 0:
                    int newValue = 10 + knobVelocita.Value;
                    _mp.SetRate((float)Decimal.Divide(1, Decimal.Divide(10, newValue)));
                    Application.DoEvents(); 
                    break;
            }
            _mp.Play(new Media(_libVLC, file));
            isPlaying = true;
            Application.DoEvents();
        }


        private void _mp_TimeChanged(object sender, EventArgs e)
        {
            /*
            trackTime.Value = (int)(_mp.Time * 100 / _mp.Length);
            Application.DoEvents();
        */
        }

        
     

        private void updw_ValueChanged(object sender, EventArgs e)
        {
            /*
            _mp.SetRate((float)Decimal.Divide(1, Decimal.Divide(10, updw.Value)));
            Application.DoEvents();
            */
        }

     
        private void knobVelocita_ValueChanged(object sender, KnobGioshControl.ValueChangedEventArgs e)
        {
            switch (knobVelocita.Value)
            {
                case 0:
                    _mp.SetRate(1);
                    Application.DoEvents();
                    break;

                case int n when n > 0:
                    _mp.SetRate(1 *  knobVelocita.Value);
                    Application.DoEvents();
                    break;

                case int n when n < 0:
                    int newValue = 10 + knobVelocita.Value;
                    _mp.SetRate((float)Decimal.Divide(1, Decimal.Divide(10, newValue)));
                    Application.DoEvents(); break;
            }
        }

        





        private void mediaSeekBar1_ValueChanged(object sender, EventArgs e)
        {
            if (_mp.Length > 0 && mediaSeekBar1.IsDragging)
            {
                long newTime = mediaSeekBar1.Value * _mp.Length / mediaSeekBar1.Maximum;
                _mp.Time = newTime;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            mediaSeekBar1.Minimum = 0;
            mediaSeekBar1.Maximum = 1000;

            // Time restituisce millisecondi trascorsi
            long current = _mp.Time;
            long total = _mp.Length;


            if (current > 0 && total >= 0)
            {
                TimeSpan durata = TimeSpan.FromMilliseconds(current);
                txtEleapsedTime.Text = durata.ToString(@"hh\:mm\:ss"); 
                //
                TimeSpan ts = TimeSpan.FromMilliseconds(total);
                string testo = ts.ToString(@"hh\:mm\:ss");
                txtTotalTime.Text = testo;
                Application.DoEvents();

     
                if (_mp.Length > 0 && !mediaSeekBar1.IsDragging)
                {
                    mediaSeekBar1.Value = (int)(_mp.Time * mediaSeekBar1.Maximum / _mp.Length);
                    Application.DoEvents();
                }
           
            }
   
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            //InizializzaOverLAy();

            overlay = new OverlayFormFlottante(this);
            overlay.AttachToForm(this);
            overlay.BringToFront();


        }


        #region PULSANTERIA_SUPERIORE
        private void picOpenFile_Click(object sender, EventArgs e)
        {

            VIDEO_STOP();

            int index = 0;
            if (VIDs.Count > 1)
            {
                foreach (VideoFile v in VIDs)
                {
                    if (v.ID > index)
                        index = v.ID;
                }
            }

            List<VideoFile> _VIDs = new List<VideoFile>();  

            var fileContent = string.Empty;
            var filePath = string.Empty;
            var filenome = string.Empty;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Seleziona i video da metteer in lista per la riproduzione";
                    if (string.IsNullOrEmpty(dirVideo))
                        openFileDialog.InitialDirectory = "C:\\";
                    else
                    {
                        if (Directory.Exists(dirVideo))
                            openFileDialog.InitialDirectory = dirVideo + "\\";
                        else
                            openFileDialog.InitialDirectory = "C:\\";
                    }
                    openFileDialog.Filter = "Video (mp4, dvix, mkv, avi)|*.mp4;*.dvix;*.mkv;*.avi";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.DefaultExt = "mp4";
                    openFileDialog.RestoreDirectory = true;
                    openFileDialog.CheckFileExists = true;
                    openFileDialog.CheckPathExists = true;
                    openFileDialog.Multiselect = true;

                    bool pressedOK = false;
                    int countFile = 0;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pressedOK = true;
                        dirVideo = string.Empty;

                        countFile = openFileDialog.FileNames.Count();

                        foreach (string filename in openFileDialog.FileNames)
                        {
                            VideoFile vid = new VideoFile();
                            vid.Filename = filename;
                            // Ottieni la directory che contiene il file
                            string directory = Path.GetDirectoryName(filename);
                            // Prendi solo il nome dell'ultima cartella
                            string folderName = Path.GetFileName(directory);
                            vid.Cartella = folderName;
                            vid.File = Path.GetFileName(filename);
                            string tipoFile = Path.GetExtension(filename);
                            string veraEstensione = tipoFile.Substring(1, tipoFile.Length - 1);
                            if (veraEstensione.ToLower() == "mp4" || veraEstensione.ToLower() == "mkv" || veraEstensione.ToLower() == "dvix" || veraEstensione.ToLower() == "avi")
                            {
                                dirVideo = filename.Substring(0, filename.Length - vid.File.Length - 1);
                                vid.Titolo = vid.File.Substring(0, vid.File.Length - tipoFile.Length);
                                vid.Saved = false;
                                index++;
                                vid.ID = index;

                                _VIDs.Add(vid);

                            }
                        }
                        config.SetValue("//appDIR//add[@key='DIR_VIDEO']", dirVideo);
                    }

                    if (pressedOK && _VIDs.Count == 0)
                    {
                        if (countFile > 1)
                            PRG.MsgBoxWarning("Nessun dei file selezionati è valido!");
                        else
                            PRG.MsgBoxWarning("Il file selezionato è valido!");

                        return;

                    }

                    if (_VIDs.Count > 0)
                    {
                        if (VIDs.Count > 0)
                        {
                            if (PRG.MsgBoxYesNo("Esistono alcuni brani nella play list, li vuoi cancellare?"))
                            {
                                VIDs = new List<VideoFile>();
                                _VIDs = new List<VideoFile>();
                                foreach (VideoFile vid in _VIDs)
                                {
                                    VIDs.Add(vid);
                                }
                                Index = 0;
                                Totale = VIDs.Count;
                            }
                            else

                            {
                                Totale = VIDs.Count;
                                Index = VIDs.Count - 1;
                                foreach (VideoFile vid in _VIDs)
                                {
                                    VIDs.Add(vid);
                                }
                                index++;
                                Totale += _VIDs.Count;
                            }
                        }
                        else
                        {
                            foreach (VideoFile vid in _VIDs)
                            {
                                VIDs.Add(vid);
                            }
                            Index = 0;
                            Totale = VIDs.Count;
                        }


                        AggiornaBranoSuovato();
                    }



                }

            }
            catch (Exception ex)
            {
                PRG.MsgBoxERR(ex, "Errore caricamento nuovi video:\r\n\r\n");
            }

        }

        private void picOpenDirectory_Click(object sender, EventArgs e)
        {
            VIDEO_STOP();

            int index = 0;
            if (VIDs.Count > 1)
            {
                foreach(VideoFile v in VIDs)
                {
                    if (v.ID > index)
                        index = v.ID;
                }
            }

            List<VideoFile> _VIDs = new List<VideoFile>();

            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Seleziona una cartella";
                    fbd.ShowNewFolderButton = true;

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = fbd.SelectedPath;
                        if (Directory.Exists(selectedPath))
                        {
                            string[] files = Directory.GetFiles(selectedPath);

                            foreach (string file in files)
                            {
                                string estensione = Path.GetExtension(file);
                                string veraEstensione = estensione.Substring(1, estensione.Length - 1);
                                if (veraEstensione.ToLower() == "mp4" || veraEstensione.ToLower() == "mkv" || veraEstensione.ToLower() == "dvix" || veraEstensione.ToLower() == "avi")
                                {
                                    VideoFile vid = new VideoFile();
                                    vid.Filename = file;
                                    // Ottieni la directory che contiene il file
                                    string directory = Path.GetDirectoryName(file);
                                    // Prendi solo il nome dell'ultima cartella
                                    string folderName = Path.GetFileName(directory);
                                    vid.Cartella = folderName;
                                    vid.File = Path.GetFileName(file);
                                    string tipoFile = Path.GetExtension(file);
                                    dirVideo = file.Substring(0, file.Length - vid.File.Length - 1);
                                    vid.Titolo = vid.File.Substring(0, vid.File.Length - tipoFile.Length);
                                    vid.Saved = false;
                                    index++;
                                    vid.ID = index;

                                    _VIDs.Add(vid);
                                }
                            }
                            if (_VIDs.Count > 0)
                            {
                                if (VIDs.Count > 0)
                                {
                                    if (PRG.MsgBoxYesNo("Esistono alcuni brani nella play list, li vuoi cancellare?"))
                                    {
                                        VIDs = new List<VideoFile>();
                                        _VIDs = new List<VideoFile>();
                                        foreach (VideoFile vid in _VIDs)
                                        {
                                            VIDs.Add(vid);
                                        }
                                        Index = 0;
                                        Totale = VIDs.Count;
                                    }
                                    else
                                    {
                                        Totale = VIDs.Count;
                                        Index = VIDs.Count - 1;
                                        foreach (VideoFile vid in _VIDs)
                                        {
                                            VIDs.Add(vid);
                                        }
                                        index++;
                                        Totale += _VIDs.Count;
                                    }


                                }
                                else
                                {
                                    foreach (VideoFile vid in _VIDs)
                                    {
                                        VIDs.Add(vid);
                                    }
                                    Index = 0;
                                    Totale = VIDs.Count;
                                }


                                AggiornaBranoSuovato();
                            }

                        }
                        else
                        {
                            PRG.MsgBoxWarning("la cartella selezionata, non esiste o non è più raggiungibile!");
                            return;
                        }

                    }
                }

          
            }
            catch (Exception ex)
            {
                PRG.MsgBoxERR(ex, "Errore caricamento nuovi video:\r\n\r\n");
            }
        }

        private void picShowList_Click(object sender, EventArgs e)
        {
            VIDEO_STOP();
            frmLista f = new frmLista(VIDs);
            f.ShowDialog(this);
            if (f.Tag.ToString() == "OK")
            {
                VIDs = f.rListaFinale;
                Index = f.rIndiceCorrente;

                AggiornaBranoSuovato();
            }
            f.Close();
        }

        private void picSaveArchivio_Click(object sender, EventArgs e)
        {
            VIDEO_STOP();

            bool ItemAdded = false;
            bool ItemExist = false;

            foreach (VideoFile f in VIDs)
            {
                if (!f.Saved)
                {
                    if (!VID_DBs.Any(x => x.Filename == f.Filename))
                    {
                        f.Saved = true;

                        VideoFileDB vFdb = new VideoFileDB();
                        vFdb.Cartella = f.Cartella;
                        vFdb.File = f.File;
                        vFdb.Filename = f.Filename;
                        vFdb.Titolo = f.Titolo;

                        VID_DBs.Add(vFdb);
                        ItemAdded = true;
                    }
                    else
                    {
                        // esiste già un elemento con lo stesso ID
                        f.Saved = true;
                        ItemExist = true;
                    }


                  
                }
            }

            if (ItemAdded)
            {
                try
                {
                    string DbFile = Path.Combine(DataFolder, "db.json");
                    //string json = JsonConvert.SerializeObject(VID_DBs, Formatting.Indented);
                    //File.WriteAllText(DbFile, json);

                    Export exportObj = new Export { Data = VID_DBs };

                    string json = JsonConvert.SerializeObject(exportObj, Formatting.Indented);
                    File.WriteAllText(DbFile, json);

                    PRG.MsgBoxExcvlamation("Il salvataggio ha avuto successo!");
                }
                catch (Exception ex)
                {
                    PRG.MsgBoxERR(ex, "Errore nella procedura di salvataggio nuovi file in archivio:\r\n\r\n");
                }
            }
            else
            {
                if (!ItemExist)
                    PRG.MsgBoxWarning("Nessun nuovo file video da salvare!");
                else
                    PRG.MsgBoxWarning("Tutti i nuovi file esistono in archivio!");
            }
                
        }

        private void picGeationeArchivio_Click(object sender, EventArgs e)
        {
            VIDEO_STOP();

            frmGestoreArchivio f = new frmGestoreArchivio(VID_DBs);
            f.ShowDialog(this);
            if (f.Tag.ToString() == "OK")
            {
                VID_DBs = f.rListaFinale;
            }
            f.Close();
        }

        private void picVolume_Click(object sender, EventArgs e)
        {
            VIDEO_STOP();

            if (IsMUte)
            {
                picVolume.Image = picVolumeUP.Image;
                

            }
            else
            {
                picVolume.Image = picVolumeMute.Image;

            }

            IsMUte = !IsMUte;
            _mp.Mute = IsMUte;
        }

        private void picScegliFromArchivio_Click(object sender, EventArgs e)
        {
            VIDEO_STOP();

            frmScegliFiles f = new frmScegliFiles(VID_DBs);
            f.ShowDialog(this);
            if (f.Tag.ToString() == "OK")
            {
                int _index = VIDs.Count();
                VIDs = f.rListaFinale;
                if (VIDs.Count > 0)
                {

                    Index = _index;
                }
                else
                {

                    Index = -1;
                }
                Totale = VIDs.Count();
                AggiornaBranoSuovato();
            }
            f.Close();
        }
        private void picClear_Click(object sender, EventArgs e)
        {
            VIDEO_STOP();

            Index = -1;
            VIDs = new List<VideoFile>();
            Totale = VIDs.Count();
            AggiornaBranoSuovato();

        }

        #endregion PULSANTERIA_SUPERIORE
    }


}


