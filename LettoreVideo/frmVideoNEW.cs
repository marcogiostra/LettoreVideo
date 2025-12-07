using LettoreVideo.Classi;
using LettoreVideo.Controlli;
using LettoreVideo.Utility;
using LibVLCSharp.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LettoreVideo
{
    public enum VideoPlayAction
    {
        Pause = 0,
        Play = 1,
        Stop = 2,

        FastBackward5 = 30,
        FastBackward10 = 31,
        FastBackward30 = 32,
        FastNext5 = 40,
        FastNext10 = 41,
        FastNext30 = 42,

        Previous = 5,
        Next = 6,
        DaCapo = 7


    }

    public enum ScreenMode
    {
        Normal = 0,
        Full = 1,
        Minimize = 2
    }

    public partial class frmVideoNEW : Form
    {

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
        public LibVLCSharp.Shared.MediaPlayer _mp;
        public Media media;

        public bool isFullscreen = false;
        public bool isPlaying = false;
        public Size oldVideoSize;
        public Size oldFormSize;
        public Point oldVideoLocation;
        public List<Traccia> AUDIOs = new List<Traccia>();
        #endregion VIDEO

        #region OVERLAYS
        private Timer timerMouse;

        float fadeSpeed = 0.1f;  // opacità
        int moveSpeed = 25;      // velocità base
        bool topVisible = false;
        bool bottomVisible = false;

        private OverlayTop overlayButtonTop;
        private bool topVisibile = false;

        private OverlayBottom overlayButtonBottom;
        private bool bottonVisibile = false;

        private OverlayTitle ot;

        #endregion OVERLAYS

        #region VIDEO_SCREEN_MODE
        private ScreenMode MYScreenMode = ScreenMode.Normal;
        private Rectangle lastBounds;
        #endregion VIDEO_SCREEN_MODE

        #endregion DICHIARAZIONI

        #region Class
        public frmVideoNEW()
        {
            InitializeComponent();


            InizializzaLista();

            //Inizializzazione VLC
            InizializzaVLC();


            //Inizializza la lettura del file di configurazione
            config.cfgFile = "MyConfig.config";
            dirVideo = config.GetValue("//appDIR//add[@key='DIR_VIDEO']");

            Icon myIcon = global::LettoreVideo.Properties.Resources.lettorevideoMG;
            this.Icon = myIcon;

            // Forza l'icona sulla taskbar
            TaskbarIconHelper.SetTaskbarIcon(this, myIcon);


            // OverlayForm
            overlayButtonBottom = new OverlayBottom();
            overlayButtonBottom.Owner = this;
            overlayButtonBottom.SetOwner(this);
            overlayButtonBottom.ShowInTaskbar = false;
            //
            overlayButtonTop = new OverlayTop();
            overlayButtonTop.Owner = this;
            overlayButtonTop.SetOwner(this);
            overlayButtonTop.ShowInTaskbar = false;
            //
            ot = new OverlayTitle();
            ot.Owner = this;
            ot.SetOwner(this);
            ot.Visible = false;
            ot.ShowInTaskbar = false;


            // Timer mouse per animazione Quadrante
            timerMouse = new Timer { Interval = 50 };
            timerMouse.Tick += timerMouse_Tick;


        }


        private void frmVideoNEW_Load(object sender, EventArgs e)
        {
            VID_DBs = JsonOperation.Laod_DB(DataFolder);

            timer2.Enabled = true;
      

        }

        private void frmVideoNEW_FormClosing(object sender, FormClosingEventArgs e)
        {
            VideoAction(VideoPlayAction.Stop);
        }

        private void frmVideoNEW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (isPlaying)
                    VideoAction(VideoPlayAction.Pause);
                else
                    VideoAction(VideoPlayAction.Play);
            }
        }

        private void frmVideoNEW_Resize(object sender, EventArgs e)
        {
     

            try
            {
                if (overlayButtonBottom != null)
                {
                    overlayButtonBottom.Width = this.Width;
                    if (!bottonVisibile)
                        overlayButtonBottom.Top = this.Height;
                }
            }
            catch (Exception) { }

            try
            {
                if (overlayButtonTop != null)
                {
                    overlayButtonTop.Width = this.Width;

                    // Se non è visibile, posizionalo fuori dallo schermo in alto
                    if (!topVisibile)
                        overlayButtonTop.Top = -overlayButtonTop.Height;
                }
            }
            catch (Exception) { }

            timerOT.Enabled = true;


        }






        #endregion Class

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

        private void AggiornaBranoSuovato()
        {
            string tempValue = string.Empty;

            if (Index > -1 && Totale > 0)
                tempValue = (Index + 1).ToString() + " / " + Totale.ToString();
            else
                tempValue = "0 video";

            overlayButtonBottom.SetContaBrani(tempValue);

        }
        private void PlayCameraClick()
        {
            string soundPath = Path.Combine(Application.StartupPath, "camera_click_16bit.wav");

            if (File.Exists(soundPath))
            {
                var player = new System.Media.SoundPlayer(soundPath);
                player.Play();
            }
            else
            {
                MessageBox.Show("File audio non trovato:\n" + soundPath);
            }

        }


        #region f()_VIDEO
        private void InizializzaVLC()
        {
            Core.Initialize();



            oldVideoSize = videoView1.Size;
            oldFormSize = this.Size;
            oldVideoLocation = videoView1.Location;
            //VLC stuff
            //_libVLC = new LibVLC();
            _libVLC = new LibVLC("--no-video-title-show", "--vout=directx", "--no-overlay");
            Application.DoEvents();
            _mp = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
            Application.DoEvents();
            videoView1.MediaPlayer = _mp;
            Application.DoEvents();
        }

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

                    case VideoPlayAction.FastBackward5:
                        _mp.Time -= 5000;
                        break;

                    case VideoPlayAction.FastBackward10:
                        _mp.Time -= 10000;
                        break;


                    case VideoPlayAction.FastBackward30:
                        _mp.Time -= 30000;
                        break;


                    case VideoPlayAction.FastNext5:
                        _mp.Time -= 5000;
                        break;

                    case VideoPlayAction.FastNext10:
                        _mp.Time -= 10000;
                        break;

                    case VideoPlayAction.FastNext30:
                        _mp.Time -= 30000;
                        break;

                    case VideoPlayAction.Previous:
                        if (Index == 0)
                        {
                            _mp.Position = 0.00f;
                        }
                        else
                        {
                            AUDIOs = new List<Traccia>();
                            overlayButtonBottom.ComboClear();
                            Index -= 1;
                            if (File.Exists(VIDs[Index].Filename))
                            {
                                _mp.Dispose();
                                isPlaying = false;
                                AggiornaBranoSuovato();
                                _mp = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
                                videoView1.MediaPlayer = _mp;
                                ot.ShowTitolo(VIDs[Index].Titolo);
                                //_videoTitle = VIDs[Index].Titolo;
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
                        break;

                    case VideoPlayAction.Next:
                        if (Index < VIDs.Count - 1)
                        {
                            AUDIOs = new List<Traccia>();
                            overlayButtonBottom.ComboClear();
                            Index += 1;
                            if (File.Exists(VIDs[Index].Filename))
                            {
                                _mp.Dispose();
                                isPlaying = false;
                                AggiornaBranoSuovato();
                                _mp = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
                                videoView1.MediaPlayer = _mp;
                                ot.ShowTitolo(VIDs[Index].Titolo);
                                //_videoTitle = VIDs[Index].Titolo;
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
            int velocita = overlayButtonBottom.GetVelocita();

            //_mp.SetRate((float)Decimal.Divide(1, Decimal.Divide(10, updw.Value)));
            switch (velocita)
            {
                case 0:
                    _mp.SetRate(1);
                    Application.DoEvents();
                    break;

                case int n when n > 0:
                    _mp.SetRate(1 * velocita);
                    Application.DoEvents();
                    break;

                case int n when n < 0:
                    int newValue = 10 + velocita;
                    _mp.SetRate((float)Decimal.Divide(1, Decimal.Divide(10, newValue)));
                    Application.DoEvents();
                    break;
            }
            _mp.Play(new Media(_libVLC, file));
            isPlaying = true;
            Application.DoEvents();

            if (AUDIOs.Count == 0)
                GetTracce();

        }

        private async void GetTracce()
        {
            AUDIOs = new List<Traccia>();
            overlayButtonBottom.ComboClear();

            // Attendi il caricamento delle tracce
            await Task.Delay(500);

            // Ottieni il media
            var media = _mp.Media;
            if (media == null)
                return;

            // Ottieni le tracce e filtra audio
            var tracks = media.Tracks;
            var audioTracks = tracks.Where(t => t.TrackType == TrackType.Audio).ToList();

            // Mostra le tracce
            foreach (var t in audioTracks)
            {
                Traccia trc = new Traccia();
                trc.id = t.Id;
                trc.Description = t.Description;

                AUDIOs.Add(trc);
                //Console.WriteLine($"ID: {t.Id} - Nome: {t.Description} - Lingua: {t.Language}");
            }
            overlayButtonBottom.ComboLoadTracce(AUDIOs);

            // Esempio: seleziona la prima traccia audio
            if (audioTracks.Count > 0)
            {
                _mp.SetAudioTrack(audioTracks[0].Id);
                overlayButtonBottom.ComboSelelectIndex(audioTracks[0].Id);
            }
        }

        #region f()_MACRO_OPERAZIONI_VIDEO
        private void VIDEO_DA_CAPO()
        {
            VideoAction(VideoPlayAction.DaCapo);
        }

        private void VIDEO_PRECEDENTE()
        {
            if (isPlaying)
                VideoAction(VideoPlayAction.Previous);
        }

        private void VIDEO_INDIETRO_VELOCE(int pSecondi)
        {
            switch (pSecondi)
            {
                case 5:
                    VideoAction(VideoPlayAction.FastBackward5);
                    break;
                case 10:
                    VideoAction(VideoPlayAction.FastBackward10);
                    break;
                case 30:
                    VideoAction(VideoPlayAction.FastBackward30);
                    break;
            }
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
                        _mp = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
                        videoView1.MediaPlayer = _mp;
                        ot.ShowTitolo(VIDs[Index].Titolo);
                        //_videoTitle = VIDs[Index].Titolo;
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

        private void VIDEO_AVANTI_VELOCE(int pSecondi)
        {
            switch (pSecondi)
            {
                case 5:
                    VideoAction(VideoPlayAction.FastNext5);
                    break;
                case 10:
                    VideoAction(VideoPlayAction.FastNext10);
                    break;
                case 30:
                    VideoAction(VideoPlayAction.FastNext30);
                    break;
            }
        }

        private void VIDEO_NEXT()
        {
            if (isPlaying)
                VideoAction(VideoPlayAction.Next);
        }
        #endregion f()_MACRO_OPERAZIONI_VIDEO

        #endregion f()_VIDEO

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

        #region f()_OVERLAY
        private void ApplyFade(Form frm, bool visible)
        {
            if (visible)
            {
                if (frm.Opacity < 0.7)
                    frm.Opacity += fadeSpeed;
                else
                    frm.Opacity = 0.7;
            }
            else
            {
                if (frm.Opacity > 0.0)
                    frm.Opacity -= fadeSpeed;
                else
                    frm.Opacity = 0.0;
            }
        }

        private void UpdateClickThrough(Form frm)
        {
            if (frm.Opacity <= 0.0)
                frm.Enabled = false;   // non riceve click
            else
                frm.Enabled = true;    // normale
        }


        private int SmoothStep(int current, int target)
        {
            int distance = target - current;
            return current + (distance / 4); // (5) più grande → più veloce
        }
        #endregion f()_OVERLAY



        #region f()_SCREEN

        // -------------------------
        // Modalità FULL senza taskbar
        // -------------------------
        private void EnterFullScreen()
        {
            lastBounds = this.Bounds;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen.Bounds;     // schermo intero
            this.TopMost = true;

            videoView1.Dock = DockStyle.Fill;

            // Nascondo il floating sotto lo schermo
            HideFloatingFormBelowScreen();
            //HideFloatingBehindTaskbar();
            overlayButtonBottom.SendBehindTaskbar();
        }



        // -------------------------
        // Modalità FULL con taskbar
        // -------------------------
        private void EnterFullWithTaskbar()
        {
            lastBounds = this.Bounds;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen.WorkingArea; // fino sopra la taskbar
            this.TopMost = true;

            videoView1.Dock = DockStyle.Fill;

            // Mostro il floating sopra la taskbar
            ShowFloatingFormAboveTaskbar();
            overlayButtonBottom.BringToFrontOfTaskbar();

        }



        // -------------------------
        // Modalità MINI (angolo alto destro)
        // -------------------------
        private void EnterMiniMode()
        {
            int miniWidth = 400;
            int miniHeight = 225;

            lastBounds = this.Bounds;

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;

            var area = Screen.PrimaryScreen.WorkingArea;

            this.Size = new Size(miniWidth, miniHeight);
            this.Location = new Point(
                area.Right - miniWidth - 10,
                area.Top + 10
            );

            videoView1.Dock = DockStyle.Fill;

            // floating sopra la taskbar
            ShowFloatingFormAboveTaskbar();
        }



        // -------------------------
        // Ripristina modalità normale
        // -------------------------
        private void ExitModes()
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;

            if (!lastBounds.IsEmpty)
                this.Bounds = lastBounds;

            videoView1.Dock = DockStyle.Fill;

            // floating sopra la taskbar
            ShowFloatingFormAboveTaskbar();
        }



        // -------------------------
        // Floating Nascosto sotto lo schermo
        // -------------------------
        private void HideFloatingFormBelowScreen()
        {
            int screenBottom = Screen.PrimaryScreen.Bounds.Bottom;

            overlayButtonBottom.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - overlayButtonBottom.Width) / 2,
                screenBottom
            );
        }



        // -------------------------
        // Floating visibile sopra la taskbar
        // -------------------------
        private void ShowFloatingFormAboveTaskbar()
        {
            int workingBottom = Screen.PrimaryScreen.WorkingArea.Bottom;

            overlayButtonBottom.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - overlayButtonBottom.Width) / 2,
                workingBottom - overlayButtonBottom.Height - 5
            );
        }

        private void HideFloatingBehindTaskbar()
        {
            int screenBottom = Screen.PrimaryScreen.Bounds.Bottom;

            overlayButtonBottom.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - overlayButtonBottom.Width) / 2,
                screenBottom
            );
        }

        private void ShowFloatingAboveTaskbar()
        {
            int workingBottom = Screen.PrimaryScreen.WorkingArea.Bottom;

            overlayButtonBottom.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - overlayButtonBottom.Width) / 2,
                workingBottom - overlayButtonBottom.Height - 5
            );
        }

        #endregion f()_SCREEN
        #endregion f()

        #region TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            overlayButtonBottom.SetSeekBarMinimum(0);
            overlayButtonBottom.SetSeekBarMaximum(1000);


            // Time restituisce millisecondi trascorsi
            long current = _mp.Time;
            long total = _mp.Length;


            if (current > 0 && total >= 0)
            {
                TimeSpan durata = TimeSpan.FromMilliseconds(current);
                overlayButtonBottom.SetElapsedTime(durata.ToString(@"hh\:mm\:ss"));
                //
                TimeSpan ts = TimeSpan.FromMilliseconds(total);
                string testo = ts.ToString(@"hh\:mm\:ss");
                overlayButtonBottom.SetTotalTime(testo);
                Application.DoEvents();
           
                if (_mp.Length > 0 && !overlayButtonBottom.GetSeekBarIsDragging())
                {
                    overlayButtonBottom.SetSeekBarValue((int)(_mp.Time * overlayButtonBottom.GetSeekBarMaximum() / _mp.Length));
                    Application.DoEvents();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            overlayButtonTop.Owner = this;
            overlayButtonTop.TopMost = true;
            overlayButtonTop.Location = new Point(0, -this.Height); // fuori dallo schermo in alto
            overlayButtonTop.Width = this.Width;
            overlayButtonTop.BringToFront();
            overlayButtonTop.Show();
      

            overlayButtonBottom.Show();
            frmVideoNEW_Resize(null, null);
            timerMouse.Start();



        }

        private void timerMouse_Tick(object sender, EventArgs e)
        { 
            Point mouse = Cursor.Position;

            int formTop = this.Bounds.Top;
            int formBottom = this.Bounds.Bottom;

            int overlayTopHeight = overlayButtonTop.Height;
            int overlayBottomHeight = overlayButtonBottom.Height;

            int triggerTop = formTop + 50;
            int triggerBottom = formBottom - 80;


            // LOGICA
            topVisible = (mouse.Y <= triggerTop);
            bottomVisible = (mouse.Y >= triggerBottom);

            // ----------------------
            //   POSIZIONI TARGET
            // ----------------------
            int topShownY = this.Top;
            int topHiddenY = this.Top - overlayButtonTop.Height;

            int bottomShownY = this.Bottom - overlayButtonBottom.Height;
            int bottomHiddenY = this.Bottom;

            // ----------------------
            //   EASING TOP
            // ----------------------
            int topTarget = topVisible ? topShownY : topHiddenY;
            overlayButtonTop.Top = SmoothStep(overlayButtonTop.Top, topTarget);

            // ----------------------
            //   EASING BOTTOM
            // ----------------------
            int bottomTarget = bottomVisible ? bottomShownY : bottomHiddenY;
            overlayButtonBottom.Top = SmoothStep(overlayButtonBottom.Top, bottomTarget);

            // ----------------------
            //   FADE
            // ----------------------
            ApplyFade(overlayButtonTop, topVisible);
            ApplyFade(overlayButtonBottom, bottomVisible);

            // ----------------------
            //   CLICK-THROUGH
            // ----------------------
            UpdateClickThrough(overlayButtonTop);
            UpdateClickThrough(overlayButtonBottom);
            

    
        }

        private void timerOT_Tick(object sender, EventArgs e)
        {
            timerOT.Enabled = false;
            ot.Width = this.Width;
            ot.Top = this.Height * 3 / 4;
            ot.Show();
            ot.Visible = false;
            ot.BringToFront();

        }

        #endregion TIMER

        #region EXTERNAL

        #region EXTERNAL_TOP
        public void External_CLOSE_FORM()
        {
            VIDEO_STOP();
            this.Close();
        }
        public void External_OPEN_FILE()
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
                            vid.FilenameOriginale = PathHelper.GetRelativeOrDriveTrimmed(filename);
                            // Ottieni la directory che contiene il file
                            string directory = Path.GetDirectoryName(filename);
                            // Prendi solo il nome dell'ultima cartella
                            string folderName = Path.GetFileName(directory);
                            vid.Categoria = folderName;
                            vid.Specifica = folderName;
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
        public void External_OPEN_DIR()
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

            try
            {

                //prepara la cartella iniziale
                if (string.IsNullOrEmpty(dirVideo))
                    dirVideo = "C:\\";
                else
                {
                    if (Directory.Exists(dirVideo))
                        dirVideo = dirVideo + "\\";
                    else
                        dirVideo = "C:\\";
                }

                using (var form = new FormFolderPicker())
                {
                    form.ultimaCartella = dirVideo;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = form.CartellaSelezionata;
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
                                    vid.FilenameOriginale = PathHelper.GetRelativeOrDriveTrimmed(vid.Filename);
                                    // Ottieni la directory che contiene il file
                                    string directory = Path.GetDirectoryName(file);
                                    // Prendi solo il nome dell'ultima cartella
                                    string folderName = Path.GetFileName(directory);
                                    vid.Categoria = folderName;
                                    vid.Specifica = folderName;
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

                            dirVideo = selectedPath;
                            //config.SetValue("//appDIR//add[@key='DIR_VIDEO']", dirVideo);
                            string appPath = AppDomain.CurrentDomain.BaseDirectory;
                            string configFile = Path.Combine(appPath, "MyConfig.config");
                            XDocument doc = XDocument.Load(configFile);
                            XElement dirVideoElement = doc.Root.Element("appDir")?
                                .Element("add");
                            if (dirVideoElement != null)
                            {
                                // Imposta il valore
                                dirVideoElement.SetAttributeValue("value", dirVideo);

                                // Salva il file
                                doc.Save(configFile);
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                            PRG.MsgBoxWarning("la cartella selezionata, non esiste o non è più raggiungibile!");
                            return;
                        }
                    }
                }




                /*

                var dialog = new VistaFolderBrowserDialog();
                dialog.Description = "Seleziona una cartella dove ci siano video da riprodurre";                
                dialog.UseDescriptionForTitle = true;
                dialog.SelectedPath = dirVideo;                
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;
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
                                vid.FilenameOriginale = PathHelper.GetRelativeOrDriveTrimmed(vid.Filename);
                                // Ottieni la directory che contiene il file
                                string directory = Path.GetDirectoryName(file);
                                // Prendi solo il nome dell'ultima cartella
                                string folderName = Path.GetFileName(directory);
                                vid.Categoria = folderName;
                                vid.Specifica = folderName;
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

                        dirVideo = selectedPath;
                        config.SetValue("//appDIR//add[@key='DIR_VIDEO']", dirVideo);
                    }
                    else
                    {
                        PRG.MsgBoxWarning("la cartella selezionata, non esiste o non è più raggiungibile!");
                        return;
                    }
                }

 */


            }
            catch (Exception ex)
            {
                PRG.MsgBoxERR(ex, "Errore caricamento nuovi video:\r\n\r\n");
            }
        }
        public void External_SHOW_LIST()
        {
            VIDEO_STOP();

            Form frmLista = Application.OpenForms
                          .OfType<frmLista>()
                          .FirstOrDefault();

            if (frmLista != null)
            {
                // Porta la finestra esistente in primo piano
                frmLista.BringToFront();
                frmLista.Focus();
                return;
            }

            frmLista f = new frmLista(VIDs);
            f.ShowDialog(this);
            if (f.Tag.ToString() == "OK")
            {
                VIDs = f.rListaFinale;
                Totale = VIDs.Count;
                Index = Totale > 0 ? 0 : -1;

                AggiornaBranoSuovato();
            }    
            f.Close();
        }
        public void External_CLEAR()
        {
            VIDEO_STOP();

            Index = -1;
            VIDs = new List<VideoFile>();
            Totale = VIDs.Count();
            AggiornaBranoSuovato();
        }
        public void External_SAVE()
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
                        vFdb.Categoria = f.Categoria;
                        vFdb.Specifica = f.Specifica;
                        vFdb.File = f.File;
                        vFdb.Filename = f.Filename;
                        vFdb.FilenameOriginale = f.FilenameOriginale;
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
                    JsonOperation.Save_DB(VID_DBs, DataFolder);
                }
                catch (Exception ex)
                {
                    PRG.MsgBoxERR(ex, "Errore salvataggio nuovi video in archivio:\r\n\r\n");
                    return;
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
 
        public void External_SCEGLI_VIDEO_DA_ARCHIVIO()
        {
            VIDEO_STOP();

            Form frmScegliFiles = Application.OpenForms
                         .OfType<frmScegliFiles>()
                         .FirstOrDefault();

            if (frmScegliFiles != null)
            {
                // Porta la finestra esistente in primo piano
                frmScegliFiles.BringToFront();
                frmScegliFiles.Focus();
                return;
            }

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
            else if (f.Tag.ToString() == "OK+PLAY")
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
                if (VIDs.Count > 0)
                    VIDEO_PLAY();
            }
            f.Close();
        }
        public void External_GESTIONE_CATEGORIE()
        {
            VIDEO_STOP();

            VIDs = new List<VideoFile>();

            frmGestioneFiles f = new frmGestioneFiles(ref VID_DBs);
            f.ShowDialog(this);
            if (f.Tag.ToString() == "OK")
            {

            }
            f.Close();

        }
        #endregion EXTERNAL_TOP

        #region EXTERNAL_BOTTOM
        #region LETTOREVIDEO
        public void External_DA_CAPO()
        {
            VIDEO_DA_CAPO();
        }
        public void External_PRECEDENTE()
        {
            VIDEO_PRECEDENTE();
        }
        public void External_INDIETRO_VELOCE(int pSecondi)
        {
            VIDEO_INDIETRO_VELOCE(pSecondi);
        }
        public void External_PAUSA()
        {
            VIDEO_PAUSA();
        }
        public void External_PLAY()
        {
            VIDEO_PLAY();
        }
        public void External_STOP()
        {
            VIDEO_STOP();
        }
        public void External_AVANTI_VELOCE(int pSecondi)
        {
            VIDEO_AVANTI_VELOCE(pSecondi);
        }
        public void External_PROSSIMO()
        {
            VIDEO_NEXT();
        }
        public void External_MUTE(bool pIsMute)
        {
            _mp.Mute = pIsMute;
        }
        public void External_POSITION_MOVIE(long pNewTime)
        {
   
            if (_mp.Length > 0 && overlayButtonBottom.GetSeekBarIsDragging())
            {
                long newTime = overlayButtonBottom.GetSeekBarValue() * _mp.Length / overlayButtonBottom.GetSeekBarMaximum();
                _mp.Time = pNewTime;
            }
        }
        public void External_IMPOSTSA_VELOCITA(float pValue)
        {
            _mp.SetRate(pValue);
            Application.DoEvents();

        }
        public void External_SELECT_AUDIO_TRACK(int pIndex)
        {
            _mp.SetAudioTrack(pIndex);
        }
        public long GetLenght()
        {
            return _mp.Length;
        }
        #endregion LETTOREVIDEO

        #region EXTERNAL_FUNCTIONS
        public void External_PHOTO()
        {


            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                            "snapshot_lv_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png");

            bool result = _mp.TakeSnapshot(0, path, 0, 0);

            if (result)
            {
                // Suono di click della macchina fotografica
                PlayCameraClick();
            }
            else
            {
                // Suono di errore
                System.Media.SystemSounds.Hand.Play();
            }
        }

        public void External_TO_MAX()
        {
            MYScreenMode = ScreenMode.Full;
            EnterFullWithTaskbar();
            HideFloatingFormBelowScreen(); // subito dopo il cambi
        }

        public void External_FROM_MAX()
        {
            MYScreenMode = ScreenMode.Normal;
            EnterFullScreen();
            HideFloatingFormBelowScreen(); // sempre
        }

        #endregion EXTERNAL_FUNCTIONS

        #endregion EXTERNAL
        #endregion EXTERNAL_BOTTOM

    }
}

