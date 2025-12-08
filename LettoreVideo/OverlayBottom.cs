using LettoreVideo.Classi;
using LettoreVideo.Controlli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media.Animation;


namespace LettoreVideo
{
    public partial class OverlayBottom : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string className, string windowText);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int X, int Y, int cx, int cy, uint uFlags);

        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const uint SWP_NOMOVE = 0x0002;
        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOACTIVATE = 0x0010;

        //----------------


        Form _owner = new Form();
        bool IsMute = false;
        bool isPopolatingCombo = false;
        public OverlayBottom()
        {
            InitializeComponent();

            foreach (Control ctrl in this.Controls)
            {
                Console.WriteLine($"Nome: {ctrl.Name}, Tipo: {ctrl.GetType().Name}");

                // esempio di azione
                if (ctrl is ExtendedPictureBox ext)
                {
                    ext.DebugMode = false;
                    ext.UseFormBackColor = false;

                }
            }


            #region LETTOREVIDEO


            picMusicalePlay.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                {
                    main.External_PLAY();
                }
            };

            picMusicalePause.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                {
                    main.External_PAUSA();
                }
            };
           
            picMusicaleStop.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_STOP();
            };

            picMusicaleDaCapo.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_DA_CAPO();
            };

            picMusicalePrecedente.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_PRECEDENTE();
            };

            picMusicaleIndietro5.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_INDIETRO_VELOCE(5);
            };

            picMusicaleIndietro10.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_INDIETRO_VELOCE(10);
            };

            picMusicaleIndietro30.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_INDIETRO_VELOCE(30);
            };

            picMusicaleAvanti5.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_AVANTI_VELOCE(5);
            };

            picMusicaleAvanti10.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_AVANTI_VELOCE(10);
            };

            picMusicaleAvanti30.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_AVANTI_VELOCE(30);
            };

            picMusicaleNext.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_PROSSIMO();
            };

            picVolume.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                {
                    //VIDEO_STOP();

                    if (IsMute)
                    {
                        picVolume.ImageNormal = pic_es_si.ImageNormal;
                        picVolume.ImageHover = pic_es_si.ImageHover;
                        picVolume.ImageClick = pic_es_si.ImageClick;
                        Application.DoEvents();
                    }
                    else
                    {
                        picVolume.ImageNormal = pic_es_no.ImageNormal;
                        picVolume.ImageHover = pic_es_no.ImageHover;
                        picVolume.ImageClick = pic_es_no.ImageClick;
                        Application.DoEvents();
                    }

                    IsMute = !IsMute;

                    main.External_MUTE(IsMute);
                }
            };
            lblContaBrani.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                {
                    if (lblContaBrani.Text != "0 video")
                    {
                        main.External_CHOOSE_INDEX_CURRENT();
                    }
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
            
            speedVideo.ValueChanged += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                {
                    float _value = 0;

                    switch (speedVideo.SelectedValue)
                    {
                        case 0:
                            _value = 1;
                            break;

                        case int n when n > 0:
                            _value = 1 * speedVideo.SelectedValue;
                            Application.DoEvents();
                            break;

                        case int n when n < 0:
                            int newValue = 10 + speedVideo.SelectedValue;
                            _value = (float)Decimal.Divide(1, Decimal.Divide(10, newValue));
                            Application.DoEvents(); break;
                    }
                    main.External_IMPOSTSA_VELOCITA(_value);

                   
                }
            };
            
            #endregion LETTOREVIDEO


            #region FUNCTIONS
            picPhoto.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_PHOTO();
            };

            picToMax.Click += (s, e) =>
            {
                picToMax.Visible = false;
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_TO_MAX();
            };

            picFromMax.Click += (s, e) =>
            {
                picToMax.Visible = false;
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_FROM_MAX();
            };

            picTitle.Click += (s, e) =>
            {
                picToMax.Visible = false;
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_SHOW_TITLE_AGAIN();
            };
            #endregion FUNCTIONS



        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {
          
        }

        #region f()

        public void ComboClear()
        {
            isPopolatingCombo = true;
            cmbAudio.SelectedIndex =  - 1;
            cmbAudio.Items.Clear();
            cmbAudio.Visible = false;
            isPopolatingCombo = false;
        }
        public void ComboSelelectIndex(int pIndex)
        {
            isPopolatingCombo = true;
            cmbAudio.SelectedIndex = pIndex - 1;
            isPopolatingCombo = false;
        }

        public void ComboLoadTracce(List<Traccia> pAUDIOs)
        {
            isPopolatingCombo = true;
            cmbAudio.Items.Clear();
            foreach (Traccia t in pAUDIOs)
            {
                cmbAudio.Items.Add(t);
            }
            cmbAudio.SelectedIndex = -1;
            isPopolatingCombo = false;
            cmbAudio.Visible = pAUDIOs.Count > 1;
        }

        
        public void SetComboAudioItem(int  pValue)
        {
            cmbAudio.Items.Add(pValue);
        }
        
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
            lblContaBrani.Text = pValue;
        }

        public void SetTotalTime(string pValue)
        {
            lblTotalTime.Text = pValue;
        }

        public void SetElapsedTime(string pValue)
        {
            lblElapsedTime.Text = pValue;
        }

        public int GetVelocita()
        {
            return 0; // speedVideo.SelectedValue;
        }
        #endregion f()


        private void OverlayForm_Resize(object sender, EventArgs e)
        {
            int _width = this.Width;
            int spazio = 10;

            picMusicalePlay.Left = (_width - picMusicalePlay.Width) / 2;
            picMusicalePause.Location = new Point(picMusicalePlay.Left + picMusicalePlay.Width + spazio, picMusicalePlay.Top);
            picMusicaleAvanti5.Location = new Point(picMusicalePause.Left + picMusicalePause.Width + spazio, picMusicalePlay.Top);
            picMusicaleAvanti10.Location = new Point(picMusicaleAvanti5.Left + picMusicaleAvanti5.Width + spazio, picMusicalePlay.Top);
            picMusicaleAvanti30.Location = new Point(picMusicaleAvanti10.Left + picMusicaleAvanti10.Width + spazio, picMusicalePlay.Top);
            picMusicaleIndietro5.Location = new Point(picMusicalePlay.Left - spazio - picMusicaleIndietro5.Width, picMusicalePlay.Top);
            picMusicaleIndietro10.Location = new Point(picMusicaleIndietro5.Left - spazio - picMusicaleIndietro10.Width, picMusicalePlay.Top);
            picMusicaleIndietro30.Location = new Point(picMusicaleIndietro10.Left - spazio - picMusicaleIndietro30.Width, picMusicalePlay.Top);
            picMusicalePrecedente.Location = new Point(picMusicaleIndietro30.Left , picMusicaleIndietro30.Top + picMusicaleIndietro30.Width + spazio);
            picMusicaleNext.Location = new Point(picMusicaleAvanti30.Left, picMusicaleAvanti30.Top + picMusicaleAvanti30.Width + spazio);
            picMusicaleDaCapo.Location = new Point(picMusicalePlay.Left, picMusicalePlay.Top + picMusicalePlay.Width + spazio);
            picMusicaleStop.Location = new Point(picMusicalePause.Left, picMusicalePause.Top + picMusicalePause.Width + spazio);
            //
            lblElapsedTime.Location = new Point(mediaSeekBar1.Left, picMusicalePlay.Top);
            lblTotalTime.Location = new Point(mediaSeekBar1.Right - lblTotalTime.Width, picMusicalePlay.Top);
            //
            picVolume.Location = new Point(lblElapsedTime.Left + ((lblElapsedTime.Width - picVolume.Width ) / 2), lblElapsedTime.Top + lblElapsedTime.Height + spazio);
            lblContaBrani.Location = new Point(picMusicaleIndietro10.Left, picMusicalePrecedente.Top + (picMusicalePrecedente.Height - lblContaBrani.Height) / 2);
            speedVideo.Location = new Point(picVolume.Right + spazio + spazio, picVolume.Top + 2);
            //
            picToMax.Location = new Point(lblTotalTime.Left - spazio - picToMax.Width, picMusicalePlay.Top);
            picFromMax.Location = new Point(lblTotalTime.Left - spazio - picToMax.Width, picMusicalePlay.Top);
            picPhoto.Location = new Point(picToMax.Left - spazio - picPhoto.Width, picMusicalePlay.Top);
            picTitle.Location = new Point(picPhoto.Left - spazio - picTitle.Width, picMusicalePlay.Top);
            //
            cmbAudio.Location = new Point(lblTotalTime.Right - cmbAudio.Width, picMusicaleNext.Top + (picMusicaleNext.Height - cmbAudio.Height) / 2);
        }

        private void cmbAudio_KeyDown(object sender, KeyEventArgs e)
        {
            // Permetti solo le frecce e la combinazione Alt+Freccia per aprire la lista
            if (e.KeyCode != Keys.Up &&
                e.KeyCode != Keys.Down &&
                !((e.KeyCode == Keys.Down || e.KeyCode == Keys.Up) && e.Alt))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void cmbAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isPopolatingCombo)
                if (this.Owner is frmVideoNEW main)
                    main.External_SELECT_AUDIO_TRACK(cmbAudio.SelectedIndex + 1);

        }

        private void cmbAudio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ActiveControl = null; // rimuove il focus dalla combo
        }

        private void cmbAudio_DropDownClosed(object sender, EventArgs e)
        {
            this.ActiveControl = null;  
        }

        public void SendBehindTaskbar()
        {
            var taskbar = FindWindow("Shell_TrayWnd", null);

            SetWindowPos(this.Handle, taskbar,
                0, 0, 0, 0,
                SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);
        }

        public void BringToFrontOfTaskbar()
        {
            this.TopMost = true;
            this.TopMost = false; // opzionale, se non vuoi che rimanga sempre davanti
            this.Activate();
            this.BringToFront();
        }
    }
}
