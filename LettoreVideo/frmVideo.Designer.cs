namespace LettoreVideo
{
    partial class frmVideo
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
            this.components = new System.ComponentModel.Container();
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtEleapsedTime = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtContaBrani = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelBotton = new System.Windows.Forms.FlowLayoutPanel();
            this.knobVelocita = new LettoreVideo.KnobGioshControl();
            this.picMusicaDaCApo = new System.Windows.Forms.PictureBox();
            this.picMusicalePrecedente = new System.Windows.Forms.PictureBox();
            this.picMusicaleIndietroVeloce = new System.Windows.Forms.PictureBox();
            this.picMusicxalePausa = new System.Windows.Forms.PictureBox();
            this.picMusicalePlay = new System.Windows.Forms.PictureBox();
            this.picMusicaleStopRosso = new System.Windows.Forms.PictureBox();
            this.picMusicaleAvantiVeloce = new System.Windows.Forms.PictureBox();
            this.picMusicaleNext = new System.Windows.Forms.PictureBox();
            this.picVolume = new System.Windows.Forms.PictureBox();
            this.mediaSeekBar1 = new LettoreVideo.Controlli.MediaSeekBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.picOpenFile = new System.Windows.Forms.PictureBox();
            this.picOpenDirectory = new System.Windows.Forms.PictureBox();
            this.picShowList = new System.Windows.Forms.PictureBox();
            this.picClear = new System.Windows.Forms.PictureBox();
            this.picSaveArchivio = new System.Windows.Forms.PictureBox();
            this.picGeationeArchivio = new System.Windows.Forms.PictureBox();
            this.picScegliFromArchivio = new System.Windows.Forms.PictureBox();
            this.picVolumeMute = new System.Windows.Forms.PictureBox();
            this.picVolumeUP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.flowLayoutPanelBotton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaDaCApo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicalePrecedente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaleIndietroVeloce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicxalePausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicalePlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaleStopRosso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaleAvantiVeloce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaleNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveArchivio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGeationeArchivio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScegliFromArchivio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeUP)).BeginInit();
            this.SuspendLayout();
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoView1.Location = new System.Drawing.Point(0, 0);
            this.videoView1.Margin = new System.Windows.Forms.Padding(4);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(1241, 554);
            this.videoView1.TabIndex = 2;
            this.videoView1.Text = "videoView1";
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.AcceptsTab = true;
            this.txtTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTime.BackColor = System.Drawing.Color.Black;
            this.txtTotalTime.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTime.ForeColor = System.Drawing.Color.Lime;
            this.txtTotalTime.Location = new System.Drawing.Point(1040, 11);
            this.txtTotalTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(113, 30);
            this.txtTotalTime.TabIndex = 64;
            this.txtTotalTime.Text = "00:00:00";
            this.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtEleapsedTime
            // 
            this.txtEleapsedTime.AcceptsTab = true;
            this.txtEleapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEleapsedTime.BackColor = System.Drawing.Color.Black;
            this.txtEleapsedTime.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEleapsedTime.ForeColor = System.Drawing.Color.Lime;
            this.txtEleapsedTime.Location = new System.Drawing.Point(486, 11);
            this.txtEleapsedTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtEleapsedTime.Name = "txtEleapsedTime";
            this.txtEleapsedTime.ReadOnly = true;
            this.txtEleapsedTime.Size = new System.Drawing.Size(113, 30);
            this.txtEleapsedTime.TabIndex = 65;
            this.txtEleapsedTime.Text = "00:00:00";
            this.txtEleapsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtContaBrani
            // 
            this.txtContaBrani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtContaBrani.BackColor = System.Drawing.Color.Black;
            this.txtContaBrani.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaBrani.ForeColor = System.Drawing.Color.Lime;
            this.txtContaBrani.Location = new System.Drawing.Point(4, 11);
            this.txtContaBrani.Margin = new System.Windows.Forms.Padding(4);
            this.txtContaBrani.Name = "txtContaBrani";
            this.txtContaBrani.ReadOnly = true;
            this.txtContaBrani.Size = new System.Drawing.Size(141, 30);
            this.txtContaBrani.TabIndex = 67;
            this.txtContaBrani.Text = "-";
            this.txtContaBrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanelBotton
            // 
            this.flowLayoutPanelBotton.Controls.Add(this.txtContaBrani);
            this.flowLayoutPanelBotton.Controls.Add(this.knobVelocita);
            this.flowLayoutPanelBotton.Controls.Add(this.picMusicaDaCApo);
            this.flowLayoutPanelBotton.Controls.Add(this.picMusicalePrecedente);
            this.flowLayoutPanelBotton.Controls.Add(this.picMusicaleIndietroVeloce);
            this.flowLayoutPanelBotton.Controls.Add(this.picMusicxalePausa);
            this.flowLayoutPanelBotton.Controls.Add(this.picMusicalePlay);
            this.flowLayoutPanelBotton.Controls.Add(this.picMusicaleStopRosso);
            this.flowLayoutPanelBotton.Controls.Add(this.picMusicaleAvantiVeloce);
            this.flowLayoutPanelBotton.Controls.Add(this.picMusicaleNext);
            this.flowLayoutPanelBotton.Controls.Add(this.picVolume);
            this.flowLayoutPanelBotton.Controls.Add(this.txtEleapsedTime);
            this.flowLayoutPanelBotton.Controls.Add(this.mediaSeekBar1);
            this.flowLayoutPanelBotton.Controls.Add(this.txtTotalTime);
            this.flowLayoutPanelBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelBotton.Location = new System.Drawing.Point(0, 511);
            this.flowLayoutPanelBotton.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelBotton.Name = "flowLayoutPanelBotton";
            this.flowLayoutPanelBotton.Size = new System.Drawing.Size(1241, 43);
            this.flowLayoutPanelBotton.TabIndex = 69;
            // 
            // knobVelocita
            // 
            this.knobVelocita.EndAngle = 405F;
            this.knobVelocita.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knobVelocita.KnobBackColor = System.Drawing.Color.White;
            this.knobVelocita.KnobPointerStyle = LettoreVideo.KnobGioshControl.KnobPointerStyles.line;
            this.knobVelocita.LargeChange = 1;
            this.knobVelocita.Location = new System.Drawing.Point(154, 5);
            this.knobVelocita.Margin = new System.Windows.Forms.Padding(5);
            this.knobVelocita.Maximum = 7;
            this.knobVelocita.Minimum = -7;
            this.knobVelocita.Name = "knobVelocita";
            this.knobVelocita.PointerColor = System.Drawing.Color.SlateBlue;
            this.knobVelocita.ScaleColor = System.Drawing.Color.Black;
            this.knobVelocita.ScaleDivisions = 11;
            this.knobVelocita.ScaleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.knobVelocita.ScaleSubDivisions = 4;
            this.knobVelocita.ShowLargeScale = false;
            this.knobVelocita.ShowSmallScale = false;
            this.knobVelocita.Size = new System.Drawing.Size(35, 35);
            this.knobVelocita.SmallChange = 1;
            this.knobVelocita.StartAngle = 135F;
            this.knobVelocita.TabIndex = 74;
            this.knobVelocita.Value = 0;
            this.knobVelocita.ValueChanged += new System.EventHandler<LettoreVideo.KnobGioshControl.ValueChangedEventArgs>(this.knobVelocita_ValueChanged);
            // 
            // picMusicaDaCApo
            // 
            this.picMusicaDaCApo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMusicaDaCApo.Image = global::LettoreVideo.Properties.Resources.bm_DaCapo;
            this.picMusicaDaCApo.Location = new System.Drawing.Point(198, 17);
            this.picMusicaDaCApo.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaDaCApo.Name = "picMusicaDaCApo";
            this.picMusicaDaCApo.Size = new System.Drawing.Size(24, 24);
            this.picMusicaDaCApo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMusicaDaCApo.TabIndex = 53;
            this.picMusicaDaCApo.TabStop = false;
            this.picMusicaDaCApo.Click += new System.EventHandler(this.picMusicaDaCApo_Click);
            // 
            // picMusicalePrecedente
            // 
            this.picMusicalePrecedente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMusicalePrecedente.Image = global::LettoreVideo.Properties.Resources.bm_Previous;
            this.picMusicalePrecedente.Location = new System.Drawing.Point(230, 17);
            this.picMusicalePrecedente.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicalePrecedente.Name = "picMusicalePrecedente";
            this.picMusicalePrecedente.Size = new System.Drawing.Size(24, 24);
            this.picMusicalePrecedente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMusicalePrecedente.TabIndex = 54;
            this.picMusicalePrecedente.TabStop = false;
            this.picMusicalePrecedente.Click += new System.EventHandler(this.picMusicalePrecedente_Click);
            // 
            // picMusicaleIndietroVeloce
            // 
            this.picMusicaleIndietroVeloce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMusicaleIndietroVeloce.Image = global::LettoreVideo.Properties.Resources.bm_IndietroVeloce;
            this.picMusicaleIndietroVeloce.Location = new System.Drawing.Point(262, 17);
            this.picMusicaleIndietroVeloce.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleIndietroVeloce.Name = "picMusicaleIndietroVeloce";
            this.picMusicaleIndietroVeloce.Size = new System.Drawing.Size(24, 24);
            this.picMusicaleIndietroVeloce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMusicaleIndietroVeloce.TabIndex = 55;
            this.picMusicaleIndietroVeloce.TabStop = false;
            this.picMusicaleIndietroVeloce.Click += new System.EventHandler(this.picMusicaleIndietroVeloce_Click);
            // 
            // picMusicxalePausa
            // 
            this.picMusicxalePausa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMusicxalePausa.ErrorImage = null;
            this.picMusicxalePausa.Image = global::LettoreVideo.Properties.Resources.bm_Pausa;
            this.picMusicxalePausa.Location = new System.Drawing.Point(294, 17);
            this.picMusicxalePausa.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicxalePausa.Name = "picMusicxalePausa";
            this.picMusicxalePausa.Size = new System.Drawing.Size(24, 24);
            this.picMusicxalePausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMusicxalePausa.TabIndex = 57;
            this.picMusicxalePausa.TabStop = false;
            this.picMusicxalePausa.Click += new System.EventHandler(this.picMusicxalePausa_Click);
            // 
            // picMusicalePlay
            // 
            this.picMusicalePlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMusicalePlay.Image = global::LettoreVideo.Properties.Resources.bm_Play;
            this.picMusicalePlay.Location = new System.Drawing.Point(326, 17);
            this.picMusicalePlay.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicalePlay.Name = "picMusicalePlay";
            this.picMusicalePlay.Size = new System.Drawing.Size(24, 24);
            this.picMusicalePlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMusicalePlay.TabIndex = 56;
            this.picMusicalePlay.TabStop = false;
            this.picMusicalePlay.Click += new System.EventHandler(this.picMusicalePlay_Click);
            // 
            // picMusicaleStopRosso
            // 
            this.picMusicaleStopRosso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMusicaleStopRosso.Image = global::LettoreVideo.Properties.Resources.bm_StopRosso;
            this.picMusicaleStopRosso.Location = new System.Drawing.Point(358, 17);
            this.picMusicaleStopRosso.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleStopRosso.Name = "picMusicaleStopRosso";
            this.picMusicaleStopRosso.Size = new System.Drawing.Size(24, 24);
            this.picMusicaleStopRosso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMusicaleStopRosso.TabIndex = 60;
            this.picMusicaleStopRosso.TabStop = false;
            this.picMusicaleStopRosso.Click += new System.EventHandler(this.picMusicaleStopRosso_Click);
            // 
            // picMusicaleAvantiVeloce
            // 
            this.picMusicaleAvantiVeloce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMusicaleAvantiVeloce.Image = global::LettoreVideo.Properties.Resources.bm_AvantiVeloce;
            this.picMusicaleAvantiVeloce.Location = new System.Drawing.Point(390, 17);
            this.picMusicaleAvantiVeloce.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleAvantiVeloce.Name = "picMusicaleAvantiVeloce";
            this.picMusicaleAvantiVeloce.Size = new System.Drawing.Size(24, 24);
            this.picMusicaleAvantiVeloce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMusicaleAvantiVeloce.TabIndex = 58;
            this.picMusicaleAvantiVeloce.TabStop = false;
            this.picMusicaleAvantiVeloce.Click += new System.EventHandler(this.picMusicaleAvantiVeloce_Click);
            // 
            // picMusicaleNext
            // 
            this.picMusicaleNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picMusicaleNext.Image = global::LettoreVideo.Properties.Resources.bm_Next;
            this.picMusicaleNext.Location = new System.Drawing.Point(422, 17);
            this.picMusicaleNext.Margin = new System.Windows.Forms.Padding(4);
            this.picMusicaleNext.Name = "picMusicaleNext";
            this.picMusicaleNext.Size = new System.Drawing.Size(24, 24);
            this.picMusicaleNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMusicaleNext.TabIndex = 59;
            this.picMusicaleNext.TabStop = false;
            this.picMusicaleNext.Click += new System.EventHandler(this.picMusicaleNext_Click);
            // 
            // picVolume
            // 
            this.picVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picVolume.Image = global::LettoreVideo.Properties.Resources.volumeup_bianco;
            this.picVolume.Location = new System.Drawing.Point(454, 17);
            this.picVolume.Margin = new System.Windows.Forms.Padding(4);
            this.picVolume.Name = "picVolume";
            this.picVolume.Size = new System.Drawing.Size(24, 24);
            this.picVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVolume.TabIndex = 73;
            this.picVolume.TabStop = false;
            this.picVolume.Click += new System.EventHandler(this.picVolume_Click);
            // 
            // mediaSeekBar1
            // 
            this.mediaSeekBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaSeekBar1.Location = new System.Drawing.Point(607, 16);
            this.mediaSeekBar1.Margin = new System.Windows.Forms.Padding(4);
            this.mediaSeekBar1.Maximum = 100;
            this.mediaSeekBar1.Minimum = 0;
            this.mediaSeekBar1.Name = "mediaSeekBar1";
            this.mediaSeekBar1.Size = new System.Drawing.Size(425, 25);
            this.mediaSeekBar1.TabIndex = 66;
            this.mediaSeekBar1.Value = 0;
            this.mediaSeekBar1.ValueChanged += new System.EventHandler(this.mediaSeekBar1_ValueChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.picOpenFile);
            this.flowLayoutPanel2.Controls.Add(this.picOpenDirectory);
            this.flowLayoutPanel2.Controls.Add(this.picShowList);
            this.flowLayoutPanel2.Controls.Add(this.picClear);
            this.flowLayoutPanel2.Controls.Add(this.picSaveArchivio);
            this.flowLayoutPanel2.Controls.Add(this.picGeationeArchivio);
            this.flowLayoutPanel2.Controls.Add(this.picScegliFromArchivio);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 486);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1241, 25);
            this.flowLayoutPanel2.TabIndex = 70;
            // 
            // picOpenFile
            // 
            this.picOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picOpenFile.Image = global::LettoreVideo.Properties.Resources.FrecciaOpen_Bluetto;
            this.picOpenFile.Location = new System.Drawing.Point(4, 4);
            this.picOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.picOpenFile.Name = "picOpenFile";
            this.picOpenFile.Size = new System.Drawing.Size(24, 12);
            this.picOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOpenFile.TabIndex = 54;
            this.picOpenFile.TabStop = false;
            this.picOpenFile.Click += new System.EventHandler(this.picOpenFile_Click);
            // 
            // picOpenDirectory
            // 
            this.picOpenDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picOpenDirectory.Image = global::LettoreVideo.Properties.Resources.FrecciaOpen_Fuctia;
            this.picOpenDirectory.Location = new System.Drawing.Point(36, 4);
            this.picOpenDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.picOpenDirectory.Name = "picOpenDirectory";
            this.picOpenDirectory.Size = new System.Drawing.Size(24, 12);
            this.picOpenDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOpenDirectory.TabIndex = 55;
            this.picOpenDirectory.TabStop = false;
            this.picOpenDirectory.Click += new System.EventHandler(this.picOpenDirectory_Click);
            // 
            // picShowList
            // 
            this.picShowList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picShowList.Image = global::LettoreVideo.Properties.Resources.ShowList;
            this.picShowList.Location = new System.Drawing.Point(68, 4);
            this.picShowList.Margin = new System.Windows.Forms.Padding(4);
            this.picShowList.Name = "picShowList";
            this.picShowList.Size = new System.Drawing.Size(24, 12);
            this.picShowList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picShowList.TabIndex = 56;
            this.picShowList.TabStop = false;
            this.picShowList.Click += new System.EventHandler(this.picShowList_Click);
            // 
            // picClear
            // 
            this.picClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picClear.Image = global::LettoreVideo.Properties.Resources.gomma;
            this.picClear.Location = new System.Drawing.Point(100, 4);
            this.picClear.Margin = new System.Windows.Forms.Padding(4);
            this.picClear.Name = "picClear";
            this.picClear.Size = new System.Drawing.Size(24, 12);
            this.picClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClear.TabIndex = 60;
            this.picClear.TabStop = false;
            this.picClear.Click += new System.EventHandler(this.picClear_Click);
            // 
            // picSaveArchivio
            // 
            this.picSaveArchivio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picSaveArchivio.Image = global::LettoreVideo.Properties.Resources.little_save_yellow;
            this.picSaveArchivio.Location = new System.Drawing.Point(132, 4);
            this.picSaveArchivio.Margin = new System.Windows.Forms.Padding(4);
            this.picSaveArchivio.Name = "picSaveArchivio";
            this.picSaveArchivio.Size = new System.Drawing.Size(24, 12);
            this.picSaveArchivio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSaveArchivio.TabIndex = 57;
            this.picSaveArchivio.TabStop = false;
            this.picSaveArchivio.Click += new System.EventHandler(this.picSaveArchivio_Click);
            // 
            // picGeationeArchivio
            // 
            this.picGeationeArchivio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picGeationeArchivio.Image = global::LettoreVideo.Properties.Resources.db;
            this.picGeationeArchivio.Location = new System.Drawing.Point(164, 4);
            this.picGeationeArchivio.Margin = new System.Windows.Forms.Padding(4);
            this.picGeationeArchivio.Name = "picGeationeArchivio";
            this.picGeationeArchivio.Size = new System.Drawing.Size(24, 12);
            this.picGeationeArchivio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGeationeArchivio.TabIndex = 58;
            this.picGeationeArchivio.TabStop = false;
            this.picGeationeArchivio.Click += new System.EventHandler(this.picGeationeArchivio_Click);
            // 
            // picScegliFromArchivio
            // 
            this.picScegliFromArchivio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picScegliFromArchivio.Image = global::LettoreVideo.Properties.Resources.FrecciaOpen_Arancione;
            this.picScegliFromArchivio.Location = new System.Drawing.Point(196, 4);
            this.picScegliFromArchivio.Margin = new System.Windows.Forms.Padding(4);
            this.picScegliFromArchivio.Name = "picScegliFromArchivio";
            this.picScegliFromArchivio.Size = new System.Drawing.Size(24, 12);
            this.picScegliFromArchivio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picScegliFromArchivio.TabIndex = 59;
            this.picScegliFromArchivio.TabStop = false;
            this.picScegliFromArchivio.Click += new System.EventHandler(this.picScegliFromArchivio_Click);
            // 
            // picVolumeMute
            // 
            this.picVolumeMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picVolumeMute.Image = global::LettoreVideo.Properties.Resources.volumeoff_giallo;
            this.picVolumeMute.Location = new System.Drawing.Point(644, 262);
            this.picVolumeMute.Margin = new System.Windows.Forms.Padding(4);
            this.picVolumeMute.Name = "picVolumeMute";
            this.picVolumeMute.Size = new System.Drawing.Size(24, 24);
            this.picVolumeMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVolumeMute.TabIndex = 72;
            this.picVolumeMute.TabStop = false;
            // 
            // picVolumeUP
            // 
            this.picVolumeUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picVolumeUP.Image = global::LettoreVideo.Properties.Resources.volumeup_bianco;
            this.picVolumeUP.Location = new System.Drawing.Point(604, 262);
            this.picVolumeUP.Margin = new System.Windows.Forms.Padding(4);
            this.picVolumeUP.Name = "picVolumeUP";
            this.picVolumeUP.Size = new System.Drawing.Size(24, 24);
            this.picVolumeUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVolumeUP.TabIndex = 71;
            this.picVolumeUP.TabStop = false;
            // 
            // frmVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 554);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanelBotton);
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.picVolumeMute);
            this.Controls.Add(this.picVolumeUP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MG Lettore video";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVideo_FormClosing);
            this.Load += new System.EventHandler(this.frmVideo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmVideo_KeyDown);
            this.Resize += new System.EventHandler(this.frmVideo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.flowLayoutPanelBotton.ResumeLayout(false);
            this.flowLayoutPanelBotton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaDaCApo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicalePrecedente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaleIndietroVeloce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicxalePausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicalePlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaleStopRosso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaleAvantiVeloce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaleNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolume)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveArchivio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGeationeArchivio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScegliFromArchivio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private System.Windows.Forms.PictureBox picMusicaleStopRosso;
        private System.Windows.Forms.PictureBox picMusicaleNext;
        private System.Windows.Forms.PictureBox picMusicaleAvantiVeloce;
        private System.Windows.Forms.PictureBox picMusicxalePausa;
        private System.Windows.Forms.PictureBox picMusicalePlay;
        private System.Windows.Forms.PictureBox picMusicaleIndietroVeloce;
        private System.Windows.Forms.PictureBox picMusicalePrecedente;
        private System.Windows.Forms.PictureBox picMusicaDaCApo;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtEleapsedTime;
        private Controlli.MediaSeekBar mediaSeekBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtContaBrani;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBotton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox picOpenFile;
        private System.Windows.Forms.PictureBox picOpenDirectory;
        private System.Windows.Forms.PictureBox picShowList;
        private System.Windows.Forms.PictureBox picSaveArchivio;
        private System.Windows.Forms.PictureBox picGeationeArchivio;
        private System.Windows.Forms.PictureBox picScegliFromArchivio;
        private System.Windows.Forms.PictureBox picVolumeUP;
        private System.Windows.Forms.PictureBox picVolumeMute;
        private System.Windows.Forms.PictureBox picVolume;
        private KnobGioshControl knobVelocita;
        private System.Windows.Forms.PictureBox picClear;
    }
}