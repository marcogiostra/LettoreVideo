using System.Drawing;
using System.Windows.Forms;

namespace LettoreVideo
{
    partial class OverlayBottom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblContaBrani = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.cmbAudio = new System.Windows.Forms.ComboBox();
            this.picTitle = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picToMax = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picFromMax = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picPhoto = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picVolume = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.pic_es_no = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.pic_es_si = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleDaCapo = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleStop = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleNext = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicalePrecedente = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleIndietro30 = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleIndietro10 = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleIndietro5 = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleAvanti30 = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleAvanti10 = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicaleAvanti5 = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picMusicalePlay = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.mediaSeekBar1 = new LettoreVideo.Controlli.MediaSeekBar();
            this.picMusicalePause = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.speedVideo = new LettoreVideo.Controlli.SpeedRangeSelector();
            this.SuspendLayout();
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.BackColor = System.Drawing.Color.Black;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(21, 45);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(60, 15);
            this.lblTotalTime.TabIndex = 177;
            this.lblTotalTime.Text = "00:00:00";
            this.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContaBrani
            // 
            this.lblContaBrani.BackColor = System.Drawing.Color.Black;
            this.lblContaBrani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaBrani.ForeColor = System.Drawing.Color.White;
            this.lblContaBrani.Location = new System.Drawing.Point(750, 75);
            this.lblContaBrani.Name = "lblContaBrani";
            this.lblContaBrani.Size = new System.Drawing.Size(74, 15);
            this.lblContaBrani.TabIndex = 178;
            this.lblContaBrani.Text = "0 video";
            this.lblContaBrani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTime.ForeColor = System.Drawing.Color.White;
            this.lblElapsedTime.Location = new System.Drawing.Point(21, 25);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(60, 15);
            this.lblElapsedTime.TabIndex = 179;
            this.lblElapsedTime.Text = "00:00:00";
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAudio
            // 
            this.cmbAudio.BackColor = System.Drawing.Color.Black;
            this.cmbAudio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAudio.ForeColor = System.Drawing.Color.White;
            this.cmbAudio.FormattingEnabled = true;
            this.cmbAudio.Location = new System.Drawing.Point(474, 61);
            this.cmbAudio.Margin = new System.Windows.Forms.Padding(0);
            this.cmbAudio.Name = "cmbAudio";
            this.cmbAudio.Size = new System.Drawing.Size(259, 29);
            this.cmbAudio.TabIndex = 181;
            this.cmbAudio.Visible = false;
            this.cmbAudio.SelectedIndexChanged += new System.EventHandler(this.cmbAudio_SelectedIndexChanged);
            this.cmbAudio.SelectionChangeCommitted += new System.EventHandler(this.cmbAudio_SelectionChangeCommitted);
            this.cmbAudio.DropDownClosed += new System.EventHandler(this.cmbAudio_DropDownClosed);
            this.cmbAudio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAudio_KeyDown);
            // 
            // picTitle
            // 
            this.picTitle.AutoResize = true;
            this.picTitle.BackColor = System.Drawing.Color.Black;
            this.picTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTitle.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picTitle.ImageClick = global::LettoreVideo.Properties.Resources.b32_title_click;
            this.picTitle.ImageHover = global::LettoreVideo.Properties.Resources.b32_title_hover;
            this.picTitle.ImageNormal = global::LettoreVideo.Properties.Resources.b32_title_normal;
            this.picTitle.Location = new System.Drawing.Point(408, 23);
            this.picTitle.Margin = new System.Windows.Forms.Padding(4);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(32, 32);
            this.picTitle.TabIndex = 186;
            this.picTitle.TabStop = false;
            // 
            // picToMax
            // 
            this.picToMax.AutoResize = true;
            this.picToMax.BackColor = System.Drawing.Color.Black;
            this.picToMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picToMax.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picToMax.ImageClick = global::LettoreVideo.Properties.Resources.b32_to_max_click;
            this.picToMax.ImageHover = global::LettoreVideo.Properties.Resources.b32_to_max_hover;
            this.picToMax.ImageNormal = global::LettoreVideo.Properties.Resources.b32_to_max_normal;
            this.picToMax.Location = new System.Drawing.Point(448, 25);
            this.picToMax.Margin = new System.Windows.Forms.Padding(4);
            this.picToMax.Name = "picToMax";
            this.picToMax.Size = new System.Drawing.Size(32, 32);
            this.picToMax.TabIndex = 184;
            this.picToMax.TabStop = false;
            // 
            // picFromMax
            // 
            this.picFromMax.AutoResize = true;
            this.picFromMax.BackColor = System.Drawing.Color.Black;
            this.picFromMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFromMax.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picFromMax.ImageClick = global::LettoreVideo.Properties.Resources.b32_from_max_click;
            this.picFromMax.ImageHover = global::LettoreVideo.Properties.Resources.b32_from_max_hover;
            this.picFromMax.ImageNormal = global::LettoreVideo.Properties.Resources.b32_from_max_normal;
            this.picFromMax.Location = new System.Drawing.Point(488, 23);
            this.picFromMax.Margin = new System.Windows.Forms.Padding(4);
            this.picFromMax.Name = "picFromMax";
            this.picFromMax.Size = new System.Drawing.Size(32, 32);
            this.picFromMax.TabIndex = 185;
            this.picFromMax.TabStop = false;
            // 
            // picPhoto
            // 
            this.picPhoto.AutoResize = true;
            this.picPhoto.BackColor = System.Drawing.Color.Transparent;
            this.picPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhoto.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picPhoto.ImageClick = global::LettoreVideo.Properties.Resources.b32_photo_chick;
            this.picPhoto.ImageHover = global::LettoreVideo.Properties.Resources.b32_photo_hover;
            this.picPhoto.ImageNormal = global::LettoreVideo.Properties.Resources.b32_photo_normal;
            this.picPhoto.Location = new System.Drawing.Point(528, 25);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(32, 32);
            this.picPhoto.TabIndex = 182;
            this.picPhoto.TabStop = false;
            // 
            // picVolume
            // 
            this.picVolume.AutoResize = true;
            this.picVolume.BackColor = System.Drawing.Color.Black;
            this.picVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVolume.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picVolume.ImageClick = global::LettoreVideo.Properties.Resources.b32_suono_si_click;
            this.picVolume.ImageHover = global::LettoreVideo.Properties.Resources.b32_suono_si_hover;
            this.picVolume.ImageNormal = global::LettoreVideo.Properties.Resources.b32_suono_si_normal;
            this.picVolume.Location = new System.Drawing.Point(13, 65);
            this.picVolume.Margin = new System.Windows.Forms.Padding(4);
            this.picVolume.Name = "picVolume";
            this.picVolume.Size = new System.Drawing.Size(32, 32);
            this.picVolume.TabIndex = 171;
            this.picVolume.TabStop = false;
            // 
            // pic_es_no
            // 
            this.pic_es_no.AutoResize = true;
            this.pic_es_no.BackColor = System.Drawing.Color.Black;
            this.pic_es_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_es_no.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.pic_es_no.ImageClick = global::LettoreVideo.Properties.Resources.b32_suono_no_click;
            this.pic_es_no.ImageHover = global::LettoreVideo.Properties.Resources.b32_suono_no_hover;
            this.pic_es_no.ImageNormal = global::LettoreVideo.Properties.Resources.b32_suono_no_normal;
            this.pic_es_no.Location = new System.Drawing.Point(776, 25);
            this.pic_es_no.Margin = new System.Windows.Forms.Padding(4);
            this.pic_es_no.Name = "pic_es_no";
            this.pic_es_no.Size = new System.Drawing.Size(32, 32);
            this.pic_es_no.TabIndex = 170;
            this.pic_es_no.TabStop = false;
            this.pic_es_no.Visible = false;
            // 
            // pic_es_si
            // 
            this.pic_es_si.AutoResize = true;
            this.pic_es_si.BackColor = System.Drawing.Color.Black;
            this.pic_es_si.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_es_si.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.pic_es_si.ImageClick = global::LettoreVideo.Properties.Resources.b32_suono_si_click;
            this.pic_es_si.ImageHover = global::LettoreVideo.Properties.Resources.b32_suono_si_hover;
            this.pic_es_si.ImageNormal = global::LettoreVideo.Properties.Resources.b32_suono_si_normal;
            this.pic_es_si.Location = new System.Drawing.Point(719, 25);
            this.pic_es_si.Margin = new System.Windows.Forms.Padding(4);
            this.pic_es_si.Name = "pic_es_si";
            this.pic_es_si.Size = new System.Drawing.Size(32, 32);
            this.pic_es_si.TabIndex = 169;
            this.pic_es_si.TabStop = false;
            this.pic_es_si.Visible = false;
            // 
            // picMusicaleDaCapo
            // 
            this.picMusicaleDaCapo.AutoResize = true;
            this.picMusicaleDaCapo.BackColor = System.Drawing.Color.Black;
            this.picMusicaleDaCapo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleDaCapo.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleDaCapo.ImageClick = global::LettoreVideo.Properties.Resources.b32_dacapo_click;
            this.picMusicaleDaCapo.ImageHover = global::LettoreVideo.Properties.Resources.b32_dacapo_hover;
            this.picMusicaleDaCapo.ImageNormal = global::LettoreVideo.Properties.Resources.b32_dacapo_normal;
            this.picMusicaleDaCapo.Location = new System.Drawing.Point(421, 65);
            this.picMusicaleDaCapo.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleDaCapo.Name = "picMusicaleDaCapo";
            this.picMusicaleDaCapo.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleDaCapo.TabIndex = 166;
            this.picMusicaleDaCapo.TabStop = false;
            // 
            // picMusicaleStop
            // 
            this.picMusicaleStop.AutoResize = true;
            this.picMusicaleStop.BackColor = System.Drawing.Color.Black;
            this.picMusicaleStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleStop.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleStop.ImageClick = global::LettoreVideo.Properties.Resources.b32_stop_click;
            this.picMusicaleStop.ImageHover = global::LettoreVideo.Properties.Resources.b32_stop_hover;
            this.picMusicaleStop.ImageNormal = global::LettoreVideo.Properties.Resources.b32_stop_normal;
            this.picMusicaleStop.Location = new System.Drawing.Point(301, 63);
            this.picMusicaleStop.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleStop.Name = "picMusicaleStop";
            this.picMusicaleStop.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleStop.TabIndex = 165;
            this.picMusicaleStop.TabStop = false;
            // 
            // picMusicaleNext
            // 
            this.picMusicaleNext.AutoResize = true;
            this.picMusicaleNext.BackColor = System.Drawing.Color.Black;
            this.picMusicaleNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleNext.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleNext.ImageClick = global::LettoreVideo.Properties.Resources.b32_next_click;
            this.picMusicaleNext.ImageHover = global::LettoreVideo.Properties.Resources.b32_next_hover;
            this.picMusicaleNext.ImageNormal = global::LettoreVideo.Properties.Resources.b32_next_normal;
            this.picMusicaleNext.Location = new System.Drawing.Point(381, 65);
            this.picMusicaleNext.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleNext.Name = "picMusicaleNext";
            this.picMusicaleNext.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleNext.TabIndex = 163;
            this.picMusicaleNext.TabStop = false;
            // 
            // picMusicalePrecedente
            // 
            this.picMusicalePrecedente.AutoResize = true;
            this.picMusicalePrecedente.BackColor = System.Drawing.Color.Black;
            this.picMusicalePrecedente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicalePrecedente.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicalePrecedente.ImageClick = global::LettoreVideo.Properties.Resources.b32_previous_click;
            this.picMusicalePrecedente.ImageHover = global::LettoreVideo.Properties.Resources.b32_previous_hover;
            this.picMusicalePrecedente.ImageNormal = global::LettoreVideo.Properties.Resources.b32_previous_normal;
            this.picMusicalePrecedente.Location = new System.Drawing.Point(341, 61);
            this.picMusicalePrecedente.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicalePrecedente.Name = "picMusicalePrecedente";
            this.picMusicalePrecedente.Size = new System.Drawing.Size(32, 32);
            this.picMusicalePrecedente.TabIndex = 162;
            this.picMusicalePrecedente.TabStop = false;
            // 
            // picMusicaleIndietro30
            // 
            this.picMusicaleIndietro30.AutoResize = true;
            this.picMusicaleIndietro30.BackColor = System.Drawing.Color.Black;
            this.picMusicaleIndietro30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleIndietro30.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleIndietro30.ImageClick = global::LettoreVideo.Properties.Resources.b32_anti30_click;
            this.picMusicaleIndietro30.ImageHover = global::LettoreVideo.Properties.Resources.b32_anti30_hover;
            this.picMusicaleIndietro30.ImageNormal = global::LettoreVideo.Properties.Resources.b32_anti30_normal;
            this.picMusicaleIndietro30.Location = new System.Drawing.Point(588, 26);
            this.picMusicaleIndietro30.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleIndietro30.Name = "picMusicaleIndietro30";
            this.picMusicaleIndietro30.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleIndietro30.TabIndex = 161;
            this.picMusicaleIndietro30.TabStop = false;
            // 
            // picMusicaleIndietro10
            // 
            this.picMusicaleIndietro10.AutoResize = true;
            this.picMusicaleIndietro10.BackColor = System.Drawing.Color.Black;
            this.picMusicaleIndietro10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleIndietro10.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleIndietro10.ImageClick = global::LettoreVideo.Properties.Resources.b32_anti10_click;
            this.picMusicaleIndietro10.ImageHover = global::LettoreVideo.Properties.Resources.b32_anti10_hover;
            this.picMusicaleIndietro10.ImageNormal = global::LettoreVideo.Properties.Resources.b32_anti10_normal;
            this.picMusicaleIndietro10.Location = new System.Drawing.Point(88, 25);
            this.picMusicaleIndietro10.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleIndietro10.Name = "picMusicaleIndietro10";
            this.picMusicaleIndietro10.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleIndietro10.TabIndex = 160;
            this.picMusicaleIndietro10.TabStop = false;
            // 
            // picMusicaleIndietro5
            // 
            this.picMusicaleIndietro5.AutoResize = true;
            this.picMusicaleIndietro5.BackColor = System.Drawing.Color.Black;
            this.picMusicaleIndietro5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleIndietro5.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleIndietro5.ImageClick = global::LettoreVideo.Properties.Resources.b32_anti5_click;
            this.picMusicaleIndietro5.ImageHover = global::LettoreVideo.Properties.Resources.b32_anti5_hover;
            this.picMusicaleIndietro5.ImageNormal = global::LettoreVideo.Properties.Resources.b32_anti5_normal;
            this.picMusicaleIndietro5.Location = new System.Drawing.Point(128, 25);
            this.picMusicaleIndietro5.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleIndietro5.Name = "picMusicaleIndietro5";
            this.picMusicaleIndietro5.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleIndietro5.TabIndex = 159;
            this.picMusicaleIndietro5.TabStop = false;
            // 
            // picMusicaleAvanti30
            // 
            this.picMusicaleAvanti30.AutoResize = true;
            this.picMusicaleAvanti30.BackColor = System.Drawing.Color.Black;
            this.picMusicaleAvanti30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleAvanti30.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleAvanti30.ImageClick = global::LettoreVideo.Properties.Resources.b32_orario30_click;
            this.picMusicaleAvanti30.ImageHover = global::LettoreVideo.Properties.Resources.b32_orario30_hover;
            this.picMusicaleAvanti30.ImageNormal = global::LettoreVideo.Properties.Resources.b32_orario30_normal;
            this.picMusicaleAvanti30.Location = new System.Drawing.Point(328, 23);
            this.picMusicaleAvanti30.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleAvanti30.Name = "picMusicaleAvanti30";
            this.picMusicaleAvanti30.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleAvanti30.TabIndex = 158;
            this.picMusicaleAvanti30.TabStop = false;
            // 
            // picMusicaleAvanti10
            // 
            this.picMusicaleAvanti10.AutoResize = true;
            this.picMusicaleAvanti10.BackColor = System.Drawing.Color.Black;
            this.picMusicaleAvanti10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleAvanti10.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleAvanti10.ImageClick = global::LettoreVideo.Properties.Resources.b32_orario10_click;
            this.picMusicaleAvanti10.ImageHover = global::LettoreVideo.Properties.Resources.b32_orario10_hover;
            this.picMusicaleAvanti10.ImageNormal = global::LettoreVideo.Properties.Resources.b32_orario10_normal;
            this.picMusicaleAvanti10.Location = new System.Drawing.Point(288, 23);
            this.picMusicaleAvanti10.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleAvanti10.Name = "picMusicaleAvanti10";
            this.picMusicaleAvanti10.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleAvanti10.TabIndex = 157;
            this.picMusicaleAvanti10.TabStop = false;
            // 
            // picMusicaleAvanti5
            // 
            this.picMusicaleAvanti5.AutoResize = true;
            this.picMusicaleAvanti5.BackColor = System.Drawing.Color.Black;
            this.picMusicaleAvanti5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleAvanti5.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicaleAvanti5.ImageClick = global::LettoreVideo.Properties.Resources.b32_orario5_click;
            this.picMusicaleAvanti5.ImageHover = global::LettoreVideo.Properties.Resources.b32_orario5_hover;
            this.picMusicaleAvanti5.ImageNormal = global::LettoreVideo.Properties.Resources.b32_orario5_normal;
            this.picMusicaleAvanti5.Location = new System.Drawing.Point(248, 23);
            this.picMusicaleAvanti5.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleAvanti5.Name = "picMusicaleAvanti5";
            this.picMusicaleAvanti5.Size = new System.Drawing.Size(32, 32);
            this.picMusicaleAvanti5.TabIndex = 156;
            this.picMusicaleAvanti5.TabStop = false;
            // 
            // picMusicalePlay
            // 
            this.picMusicalePlay.AutoResize = true;
            this.picMusicalePlay.BackColor = System.Drawing.Color.Black;
            this.picMusicalePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicalePlay.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicalePlay.ImageClick = global::LettoreVideo.Properties.Resources.bi32_play_click;
            this.picMusicalePlay.ImageHover = global::LettoreVideo.Properties.Resources.bi32_play_hover;
            this.picMusicalePlay.ImageNormal = global::LettoreVideo.Properties.Resources.bi32_play_normal;
            this.picMusicalePlay.Location = new System.Drawing.Point(168, 25);
            this.picMusicalePlay.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicalePlay.Name = "picMusicalePlay";
            this.picMusicalePlay.Size = new System.Drawing.Size(32, 32);
            this.picMusicalePlay.TabIndex = 154;
            this.picMusicalePlay.TabStop = false;
            // 
            // mediaSeekBar1
            // 
            this.mediaSeekBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaSeekBar1.Location = new System.Drawing.Point(12, 2);
            this.mediaSeekBar1.Maximum = 100;
            this.mediaSeekBar1.Minimum = 0;
            this.mediaSeekBar1.Name = "mediaSeekBar1";
            this.mediaSeekBar1.Size = new System.Drawing.Size(881, 20);
            this.mediaSeekBar1.TabIndex = 150;
            this.mediaSeekBar1.Value = 0;
            // 
            // picMusicalePause
            // 
            this.picMusicalePause.AutoResize = true;
            this.picMusicalePause.BackColor = System.Drawing.Color.Black;
            this.picMusicalePause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicalePause.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picMusicalePause.ImageClick = global::LettoreVideo.Properties.Resources.b32_pausa_click;
            this.picMusicalePause.ImageHover = global::LettoreVideo.Properties.Resources.b32_pausa_hover;
            this.picMusicalePause.ImageNormal = global::LettoreVideo.Properties.Resources.b32_pausa_normal;
            this.picMusicalePause.Location = new System.Drawing.Point(208, 25);
            this.picMusicalePause.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicalePause.Name = "picMusicalePause";
            this.picMusicalePause.Size = new System.Drawing.Size(32, 32);
            this.picMusicalePause.TabIndex = 155;
            this.picMusicalePause.TabStop = false;
            // 
            // speedVideo
            // 
            this.speedVideo.BackColor = System.Drawing.Color.Transparent;
            this.speedVideo.Location = new System.Drawing.Point(69, 63);
            this.speedVideo.Maximum = 5;
            this.speedVideo.Minimum = -5;
            this.speedVideo.Name = "speedVideo";
            this.speedVideo.SelectedValue = 0;
            this.speedVideo.Size = new System.Drawing.Size(234, 28);
            this.speedVideo.TabIndex = 187;
            // 
            // OverlayBottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(903, 110);
            this.Controls.Add(this.speedVideo);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.picToMax);
            this.Controls.Add(this.picFromMax);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.cmbAudio);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.lblContaBrani);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.picVolume);
            this.Controls.Add(this.pic_es_no);
            this.Controls.Add(this.pic_es_si);
            this.Controls.Add(this.picMusicaleDaCapo);
            this.Controls.Add(this.picMusicaleStop);
            this.Controls.Add(this.picMusicaleNext);
            this.Controls.Add(this.picMusicalePrecedente);
            this.Controls.Add(this.picMusicaleIndietro30);
            this.Controls.Add(this.picMusicaleIndietro10);
            this.Controls.Add(this.picMusicaleIndietro5);
            this.Controls.Add(this.picMusicaleAvanti30);
            this.Controls.Add(this.picMusicaleAvanti10);
            this.Controls.Add(this.picMusicaleAvanti5);
            this.Controls.Add(this.picMusicalePlay);
            this.Controls.Add(this.mediaSeekBar1);
            this.Controls.Add(this.picMusicalePause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverlayBottom";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OverlayForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OverlayForm_Load);
            this.Resize += new System.EventHandler(this.OverlayForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private Controlli.MediaSeekBar mediaSeekBar1;
        private Controlli.ExtendedPictureBox picMusicalePlay;
        private Controlli.ExtendedPictureBox picMusicalePause;
        private Controlli.ExtendedPictureBox picMusicaleAvanti5;
        private Controlli.ExtendedPictureBox picMusicaleAvanti10;
        private Controlli.ExtendedPictureBox picMusicaleAvanti30;
        private Controlli.ExtendedPictureBox picMusicaleIndietro5;
        private Controlli.ExtendedPictureBox picMusicaleIndietro10;
        private Controlli.ExtendedPictureBox picMusicaleIndietro30;
        private Controlli.ExtendedPictureBox picMusicalePrecedente;
        private Controlli.ExtendedPictureBox picMusicaleNext;
        private Controlli.ExtendedPictureBox picMusicaleStop;
        private Controlli.ExtendedPictureBox picMusicaleDaCapo;
        private Controlli.ExtendedPictureBox pic_es_si;
        private Controlli.ExtendedPictureBox pic_es_no;
        private Controlli.ExtendedPictureBox picVolume;
        private Label lblTotalTime;
        private Label lblContaBrani;
        private Label lblElapsedTime;
        private ComboBox cmbAudio;
        private Controlli.ExtendedPictureBox picPhoto;
        private Controlli.ExtendedPictureBox picToMax;
        private Controlli.ExtendedPictureBox picFromMax;
        private Controlli.ExtendedPictureBox picTitle;
        private Controlli.SpeedRangeSelector speedVideo;
    }
}