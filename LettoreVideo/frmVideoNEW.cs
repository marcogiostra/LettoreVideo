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
using System.Windows.Forms;
using System.Windows.Media;

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

        #endregion VIDEO

        OverlayFormFlottante overlay;

       


        private bool quadranteVisibile = false;
        private int animStep = 10; // velocità di animazione (pixel per ti

        #endregion DICHIARAZIONI

        private OverlayForm2 overlay2;
        private Timer timerMouse;

       
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
          
            Icon myIcon = global::LettoreVideo.Properties.Resources.movie;
            this.Icon = myIcon;

            // Forza l'icona sulla taskbar
            TaskbarIconHelper.SetTaskbarIcon(this, myIcon);

            
            // OverlayForm
            overlay2 = new OverlayForm2();
            overlay2.Owner = this;
            overlay2.SetOwner(this);
            //overlay2.Top = this.Height;



            // Timer mouse per animazione Quadrante
            timerMouse = new Timer { Interval = 50 };
            timerMouse.Tick += timerMouse_Tick;
            //timerMouse.Start();
     

        }

 
        private void frmVideoNEW_Load(object sender, EventArgs e)
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
            //@@@timerMouse.Enabled = true;

  

  

          
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
            /*
            quadrante.Width = this.Width;
            if (!quadranteVisibile)
                quadrante.Top = this.Height;
            */

            try
            {
                if (overlay2 != null)
                {
                    overlay2.Width = this.Width;
                    if (!quadranteVisibile)
                        overlay2.Top = this.Height;
                }
             
            }
            catch (Exception) { }


          

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

            overlay2.SetContaBrani(tempValue);
            
        }
        #endregion f()

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
                            Index -= 1;
                            if (File.Exists(VIDs[Index].Filename))
                            {
                                _mp.Dispose();
                                isPlaying = false;
                                AggiornaBranoSuovato();
                                _mp = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
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
                                _mp = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
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
            int velocita = overlay2.GetVelocita();

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

        #region f()_Quadrante

        /*
        private void MostraQuadrante()
        {
            quadranteVisibile = true;
            Timer t = new Timer { Interval = 10 };
            t.Tick += (s, e) =>
            {
                if (quadrante.Top > this.Height - quadrante.Height)
                    quadrante.Top -= animStep;
                else
                {
                    quadrante.Top = this.Height - quadrante.Height;
                    t.Stop();
                    t.Dispose();
                }
            };
            t.Start();
        }

        private void NascondiQuadrante()
        {
            quadranteVisibile = false;
            Timer t = new Timer { Interval = 10 };
            t.Tick += (s, e) =>
            {
                if (quadrante.Top < this.Height)
                    quadrante.Top += animStep;
                else
                {
                    quadrante.Top = this.Height;
                    t.Stop();
                    t.Dispose();
                }
            };
            t.Start();
        }
        */

        private void MostraQuadrante()
        {
            quadranteVisibile = true;
            Timer t = new Timer { Interval = 10 };
            t.Tick += (s, e) =>
            {
                if (overlay2.Top > this.Height - overlay2.Height)
                    overlay2.Top -= animStep;
                else
                {
                    overlay2.Top = this.Height - overlay2.Height;
                    t.Stop();
                    t.Dispose();
                }
            };
            t.Start();
        }

        private void NascondiQuadrante()
        {
            quadranteVisibile = false;
            Timer t = new Timer { Interval = 10 };
            t.Tick += (s, e) =>
            {
                if (overlay2.Top < this.Height)
                    overlay2.Top += animStep;
                else
                {
                    overlay2.Top = this.Height;
                    t.Stop();
                    t.Dispose();
                }
            };
            t.Start();
        }
        #endregion f()_Quadrante

        #region TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            //mediaSeekBar1.Minimum = 0;
            //mediaSeekBar1.Maximum = 1000;
            overlay2.SetSeekBarMinimum (0);
            overlay2.SetSeekBarMaximum (1000);


            // Time restituisce millisecondi trascorsi
            long current = _mp.Time;
            long total = _mp.Length;


            if (current > 0 && total >= 0)
            {
                TimeSpan durata = TimeSpan.FromMilliseconds(current);
                overlay2.SetElapsedTime(durata.ToString(@"hh\:mm\:ss"));
                //
                TimeSpan ts = TimeSpan.FromMilliseconds(total);
                string testo = ts.ToString(@"hh\:mm\:ss");
                overlay2.SetTotalTime(testo);
                Application.DoEvents();

                /*
                if (_mp.Length > 0 && !mediaSeekBar1.IsDragging)
                {
                    mediaSeekBar1.Value = (int)(_mp.Time * mediaSeekBar1.Maximum / _mp.Length);
                    Application.DoEvents();
                }
                */
                if (_mp.Length > 0 && !overlay2.GetSeekBarIsDragging())
                {
                    overlay2.SetSeekBarValue((int)(_mp.Time * overlay2.GetSeekBarMaximum() / _mp.Length));
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
            overlay.Opacity = 0.7;

            
            overlay2.Show();
            frmVideoNEW_Resize(null, null);
            timerMouse.Start();
            

       


        }



        /*
        private void timerMouse_Tick(object sender, EventArgs e)
        {
            Point pos = Cursor.Position;
            Rectangle screenRect = Screen.PrimaryScreen.Bounds;

            // Se il cursore è vicino al fondo (ultimi 80px)
            if (pos.Y >= screenRect.Bottom - 80)
            {
                if (!quadranteVisibile)
                    MostraQuadrante();
            }
            else if (pos.Y < screenRect.Bottom - quadrante.Height - 100)
            {
                if (quadranteVisibile)
                    NascondiQuadrante();
            }
        }
        */

        private void timerMouse_Tick(object sender, EventArgs e)
        {
            Point pos = Cursor.Position;
            Rectangle screenRect = Screen.PrimaryScreen.Bounds;

            if (pos.Y >= screenRect.Bottom - 80)
            {
                if (!quadranteVisibile)
                    MostraQuadrante();
            }
            else if (pos.Y < screenRect.Bottom - overlay2.Height - 100)
            {
                if (quadranteVisibile)
                    NascondiQuadrante();
            }
        }

   
        #endregion TIMER

      
        #region EXTERNAL

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
        public void External_MUTE (bool pIsMute)
        {           
            _mp.Mute = pIsMute;
        }
        public void External_POSITION_MOVIE(long pNewTime)
        {
            /*
            if (_mp.Length > 0 && mediaSeekBar1.IsDragging)
            {
                long newTime = mediaSeekBar1.Value * _mp.Length / mediaSeekBar1.Maximum;
                _mp.Time = pNewTime;
            }
            */
            if (_mp.Length > 0 && overlay2.GetSeekBarIsDragging() )
            {
                long newTime = overlay2.GetSeekBarValue() * _mp.Length / overlay2.GetSeekBarMaximum();
                _mp.Time = pNewTime;
            }
        }

        public void External_IMPOSTSA_VELOCITA(float pValue)
        {
            _mp.SetRate(pValue);
            Application.DoEvents(); 

        }

        public long GetLenght()
        {
            return _mp.Length;  
        }
        #endregion LETTOREVIDEO

        #region GESTORE_ESTERNO

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
                Index = f.rIndiceCorrente;

                AggiornaBranoSuovato();
            }
            f.Close();
        }

        public void External_CLAER ()
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

        public void External_GESTIONE_ARCHIVIO()
        {
            VIDEO_STOP();

            Form frmGestoreArchivio = Application.OpenForms
                               .OfType<frmGestoreArchivio>()
                               .FirstOrDefault();

            if (frmGestoreArchivio != null)
            {
                // Porta la finestra esistente in primo piano
                frmGestoreArchivio.BringToFront();
                frmGestoreArchivio.Focus();
                return;
            }

            frmGestoreArchivio f = new frmGestoreArchivio(VID_DBs);
            f.ShowDialog(this);
            if (f.Tag.ToString() == "OK")
            {
                VID_DBs = f.rListaFinale;
            }
            f.Close();
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
            f.Close();
        }
        #endregion GESTORE_ESTERNO

        #endregion EXTERNAL

    }

  

}

