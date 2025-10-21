using LettoreVideo.Controlli;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media.Animation;


namespace LettoreVideo
{
    public partial class OverlayForm : Form
    {
        Form _owner = new Form();
        bool IsMute = false;

        public OverlayForm()
        {
            InitializeComponent();

         
            #region LETTOREVIDEO

            btnMusicalePlay.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_PLAY();
            };

            btnMusicaleStopRosso.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_STOP();
            };

            btnMusicaDaCapo.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_DA_CAPO();
            };

            btnMusicalePrecedente.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_PRECEDENTE();
            };

            btnMusicaleIndietroVeloce.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_INDIETRO_VELOCE();
            };

            btnMusicxalePausa.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_PAUSA();
            };

            btnMusicaleAvantiVeloce.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_AVANTI_VELOCE();
            };

            btnMusicaleAvantiVeloce.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_AVANTI_VELOCE();
            };

            btnMusicaleNext.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_PROSSIMO();
            };

            btnVolume.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                {
                    //VIDEO_STOP();

                    if (IsMute)
                    {
                        btnVolume.Image = picVolumeUP.Image;
                    }
                    else
                    {
                        btnVolume.Image = picVolumeMute.Image;
                    }

                    IsMute = !IsMute;

                    main.External_MUTE(IsMute);
                }
            };

            mediaSeekBar1.ValueChanged += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                {
                    long _length = main.GetLenght();

                    if (_length > 0 && mediaSeekBar1.IsDragging)
                    {
                        long newTime = mediaSeekBar1.Value * _length / mediaSeekBar1.Maximum;

                        main.External_POSITION_MOVIE(newTime);
                    }
                }
            };

            knobVelocita.ValueChanged += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                {
                    float _value = 0;

                    switch (knobVelocita.Value)
                    {
                        case 0:
                            _value = 1;
                            break;

                        case int n when n > 0:
                            _value = 1 * knobVelocita.Value;
                            Application.DoEvents();
                            break;

                        case int n when n < 0:
                            int newValue = 10 + knobVelocita.Value;
                            _value = (float)Decimal.Divide(1, Decimal.Divide(10, newValue));
                            Application.DoEvents(); break;
                    }
                    main.External_IMPOSTSA_VELOCITA(_value);

                   
                }
            };
            #endregion LETTOREVIDEO

            #region GESTORE
            btnOpenFile.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_OPEN_FILE();
            };

            btnOpenDirectory.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_OPEN_DIR();
            };

            btnShowList.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_SHOW_LIST();
                    
            };

            btnClear.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_CLAER();

            };

            btnSave.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_SAVE();

            };

            btnGeationeArchivio.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_GESTIONE_ARCHIVIO();

            };

            btnScegliFromArchivio.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_SCEGLI_VIDEO_DA_ARCHIVIO();

            };

            #endregion GESTORE



        }

        #region f()

        public void SetOwner(Form owner)
        {
            if (owner != null)
            {
                _owner.Owner = owner;
            }
        }

        public void SetSeekBarMinimum(int pMinimum)
        {
            mediaSeekBar1.Minimum = pMinimum;
        }

        public void SetSeekBarMaximum(int pMaximum)
        {
            mediaSeekBar1.Maximum = pMaximum;
        }

        public int GetSeekBarMaximum()
        {
            return mediaSeekBar1.Maximum;
        }

        public void SetSeekBarValue(int pValue)
        {
            mediaSeekBar1.Value = pValue;
        }
        public int GetSeekBarValue()
        {
            return mediaSeekBar1.Value;
        }

        public bool GetSeekBarIsDragging()
        {
            return mediaSeekBar1.IsDragging;
        }

        public void SetContaBrani(string pValue)
        {
            txtContaBrani.Text = pValue;
        }

        public void SetTotalTime(string pValue)
        {
            txtTotalTime.Text = pValue;
        }

        public void SetElapsedTime(string pValue)
        {
            txtElapsedTime.Text = pValue;
        }

        public int GetVelocita()
        {
            return knobVelocita.Value;
        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {

        }
        #endregion f()

        /*

         

              private void knobVelocita_ValueChanged(object sender, KnobGioshControl.ValueChangedEventArgs e)
              {

              }

              private void picOpenFile_Click(object sender, EventArgs e)
              {

              }

              private void picOpenDirectory_Click(object sender, EventArgs e)
              {

              }

              private void picShowList_Click(object sender, EventArgs e)
              {

              }

              private void picClear_Click(object sender, EventArgs e)
              {

              }

              private void picSaveArchivio_Click(object sender, EventArgs e)
              {

              }

              private void picGeationeArchivio_Click(object sender, EventArgs e)
              {

              }

              private void picScegliFromArchivio_Click(object sender, EventArgs e)
              {

              }
        */
    }
}
