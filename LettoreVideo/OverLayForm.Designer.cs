using System.Drawing;
using System.Windows.Forms;

namespace LettoreVideo
{
    partial class OverlayForm
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
            this.picVolumeMute = new System.Windows.Forms.PictureBox();
            this.picVolumeUP = new System.Windows.Forms.PictureBox();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.txtElapsedTime = new System.Windows.Forms.TextBox();
            this.txtContaBrani = new System.Windows.Forms.TextBox();
            this.btnMusicalePlay = new System.Windows.Forms.Button();
            this.btnMusicaleNext = new System.Windows.Forms.Button();
            this.btnMusicaDaCapo = new System.Windows.Forms.Button();
            this.btnMusicaleStopRosso = new System.Windows.Forms.Button();
            this.btnMusicaleAvantiVeloce = new System.Windows.Forms.Button();
            this.btnMusicalePrecedente = new System.Windows.Forms.Button();
            this.btnMusicaleIndietroVeloce = new System.Windows.Forms.Button();
            this.btnMusicxalePausa = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.mediaSeekBar1 = new LettoreVideo.Controlli.MediaSeekBar();
            this.btnGeationeArchivio = new System.Windows.Forms.Button();
            this.btnScegliFromArchivio = new System.Windows.Forms.Button();
            this.knobVelocita = new LettoreVideo.Controlli.KnobGioshControl();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeUP)).BeginInit();
            this.SuspendLayout();
            // 
            // picVolumeMute
            // 
            this.picVolumeMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picVolumeMute.BackColor = System.Drawing.Color.Transparent;
            this.picVolumeMute.Image = global::LettoreVideo.Properties.Resources.volumeoff_giallo;
            this.picVolumeMute.Location = new System.Drawing.Point(666, 24);
            this.picVolumeMute.Name = "picVolumeMute";
            this.picVolumeMute.Size = new System.Drawing.Size(24, 24);
            this.picVolumeMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVolumeMute.TabIndex = 128;
            this.picVolumeMute.TabStop = false;
            this.picVolumeMute.Visible = false;
            // 
            // picVolumeUP
            // 
            this.picVolumeUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picVolumeUP.BackColor = System.Drawing.Color.Transparent;
            this.picVolumeUP.Image = global::LettoreVideo.Properties.Resources.volumeup_giallo;
            this.picVolumeUP.Location = new System.Drawing.Point(636, 24);
            this.picVolumeUP.Name = "picVolumeUP";
            this.picVolumeUP.Size = new System.Drawing.Size(24, 24);
            this.picVolumeUP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVolumeUP.TabIndex = 127;
            this.picVolumeUP.TabStop = false;
            this.picVolumeUP.Visible = false;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.AcceptsTab = true;
            this.txtTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTime.BackColor = System.Drawing.Color.Black;
            this.txtTotalTime.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTime.ForeColor = System.Drawing.Color.Lime;
            this.txtTotalTime.Location = new System.Drawing.Point(805, 53);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(86, 25);
            this.txtTotalTime.TabIndex = 126;
            this.txtTotalTime.Text = "00:00:00";
            this.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.AcceptsTab = true;
            this.txtElapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtElapsedTime.BackColor = System.Drawing.Color.Black;
            this.txtElapsedTime.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElapsedTime.ForeColor = System.Drawing.Color.Lime;
            this.txtElapsedTime.Location = new System.Drawing.Point(452, 53);
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.ReadOnly = true;
            this.txtElapsedTime.Size = new System.Drawing.Size(86, 25);
            this.txtElapsedTime.TabIndex = 124;
            this.txtElapsedTime.Text = "00:00:00";
            this.txtElapsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContaBrani
            // 
            this.txtContaBrani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtContaBrani.BackColor = System.Drawing.Color.Black;
            this.txtContaBrani.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaBrani.ForeColor = System.Drawing.Color.Lime;
            this.txtContaBrani.Location = new System.Drawing.Point(12, 49);
            this.txtContaBrani.Name = "txtContaBrani";
            this.txtContaBrani.ReadOnly = true;
            this.txtContaBrani.Size = new System.Drawing.Size(107, 25);
            this.txtContaBrani.TabIndex = 114;
            this.txtContaBrani.Text = "-";
            this.txtContaBrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMusicalePlay
            // 
            this.btnMusicalePlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusicalePlay.AutoSize = true;
            this.btnMusicalePlay.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicalePlay.FlatAppearance.BorderSize = 0;
            this.btnMusicalePlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicalePlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusicalePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicalePlay.Image = global::LettoreVideo.Properties.Resources.bm_Play;
            this.btnMusicalePlay.Location = new System.Drawing.Point(284, 46);
            this.btnMusicalePlay.Name = "btnMusicalePlay";
            this.btnMusicalePlay.Size = new System.Drawing.Size(30, 30);
            this.btnMusicalePlay.TabIndex = 136;
            this.btnMusicalePlay.TabStop = false;
            this.btnMusicalePlay.UseVisualStyleBackColor = false;
            // 
            // btnMusicaleNext
            // 
            this.btnMusicaleNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusicaleNext.AutoSize = true;
            this.btnMusicaleNext.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicaleNext.FlatAppearance.BorderSize = 0;
            this.btnMusicaleNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicaleNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusicaleNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicaleNext.Image = global::LettoreVideo.Properties.Resources.bm_Next;
            this.btnMusicaleNext.Location = new System.Drawing.Point(380, 48);
            this.btnMusicaleNext.Name = "btnMusicaleNext";
            this.btnMusicaleNext.Size = new System.Drawing.Size(30, 30);
            this.btnMusicaleNext.TabIndex = 137;
            this.btnMusicaleNext.TabStop = false;
            this.btnMusicaleNext.UseVisualStyleBackColor = false;
            // 
            // btnMusicaDaCapo
            // 
            this.btnMusicaDaCapo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusicaDaCapo.AutoSize = true;
            this.btnMusicaDaCapo.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicaDaCapo.FlatAppearance.BorderSize = 0;
            this.btnMusicaDaCapo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicaDaCapo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusicaDaCapo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicaDaCapo.Image = global::LettoreVideo.Properties.Resources.bm_DaCapo;
            this.btnMusicaDaCapo.Location = new System.Drawing.Point(162, 46);
            this.btnMusicaDaCapo.Name = "btnMusicaDaCapo";
            this.btnMusicaDaCapo.Size = new System.Drawing.Size(30, 30);
            this.btnMusicaDaCapo.TabIndex = 138;
            this.btnMusicaDaCapo.TabStop = false;
            this.btnMusicaDaCapo.UseVisualStyleBackColor = false;
            // 
            // btnMusicaleStopRosso
            // 
            this.btnMusicaleStopRosso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusicaleStopRosso.AutoSize = true;
            this.btnMusicaleStopRosso.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicaleStopRosso.FlatAppearance.BorderSize = 0;
            this.btnMusicaleStopRosso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicaleStopRosso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusicaleStopRosso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicaleStopRosso.Image = global::LettoreVideo.Properties.Resources.bm_StopRosso;
            this.btnMusicaleStopRosso.Location = new System.Drawing.Point(308, 46);
            this.btnMusicaleStopRosso.Name = "btnMusicaleStopRosso";
            this.btnMusicaleStopRosso.Size = new System.Drawing.Size(30, 30);
            this.btnMusicaleStopRosso.TabIndex = 139;
            this.btnMusicaleStopRosso.TabStop = false;
            this.btnMusicaleStopRosso.UseVisualStyleBackColor = false;
            // 
            // btnMusicaleAvantiVeloce
            // 
            this.btnMusicaleAvantiVeloce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusicaleAvantiVeloce.AutoSize = true;
            this.btnMusicaleAvantiVeloce.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicaleAvantiVeloce.FlatAppearance.BorderSize = 0;
            this.btnMusicaleAvantiVeloce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicaleAvantiVeloce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusicaleAvantiVeloce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicaleAvantiVeloce.Image = global::LettoreVideo.Properties.Resources.bm_AvantiVeloce;
            this.btnMusicaleAvantiVeloce.Location = new System.Drawing.Point(344, 47);
            this.btnMusicaleAvantiVeloce.Name = "btnMusicaleAvantiVeloce";
            this.btnMusicaleAvantiVeloce.Size = new System.Drawing.Size(30, 30);
            this.btnMusicaleAvantiVeloce.TabIndex = 140;
            this.btnMusicaleAvantiVeloce.TabStop = false;
            this.btnMusicaleAvantiVeloce.UseVisualStyleBackColor = false;
            // 
            // btnMusicalePrecedente
            // 
            this.btnMusicalePrecedente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusicalePrecedente.AutoSize = true;
            this.btnMusicalePrecedente.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicalePrecedente.FlatAppearance.BorderSize = 0;
            this.btnMusicalePrecedente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicalePrecedente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusicalePrecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicalePrecedente.Image = global::LettoreVideo.Properties.Resources.bm_Previous;
            this.btnMusicalePrecedente.Location = new System.Drawing.Point(192, 45);
            this.btnMusicalePrecedente.Name = "btnMusicalePrecedente";
            this.btnMusicalePrecedente.Size = new System.Drawing.Size(30, 30);
            this.btnMusicalePrecedente.TabIndex = 141;
            this.btnMusicalePrecedente.TabStop = false;
            this.btnMusicalePrecedente.UseVisualStyleBackColor = false;
            // 
            // btnMusicaleIndietroVeloce
            // 
            this.btnMusicaleIndietroVeloce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusicaleIndietroVeloce.AutoSize = true;
            this.btnMusicaleIndietroVeloce.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicaleIndietroVeloce.FlatAppearance.BorderSize = 0;
            this.btnMusicaleIndietroVeloce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicaleIndietroVeloce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusicaleIndietroVeloce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicaleIndietroVeloce.Image = global::LettoreVideo.Properties.Resources.bm_IndietroVeloce;
            this.btnMusicaleIndietroVeloce.Location = new System.Drawing.Point(224, 46);
            this.btnMusicaleIndietroVeloce.Name = "btnMusicaleIndietroVeloce";
            this.btnMusicaleIndietroVeloce.Size = new System.Drawing.Size(30, 30);
            this.btnMusicaleIndietroVeloce.TabIndex = 142;
            this.btnMusicaleIndietroVeloce.TabStop = false;
            this.btnMusicaleIndietroVeloce.UseVisualStyleBackColor = false;
            // 
            // btnMusicxalePausa
            // 
            this.btnMusicxalePausa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusicxalePausa.AutoSize = true;
            this.btnMusicxalePausa.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicxalePausa.FlatAppearance.BorderSize = 0;
            this.btnMusicxalePausa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusicxalePausa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMusicxalePausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicxalePausa.Image = global::LettoreVideo.Properties.Resources.bm_Pausa;
            this.btnMusicxalePausa.Location = new System.Drawing.Point(254, 46);
            this.btnMusicxalePausa.Name = "btnMusicxalePausa";
            this.btnMusicxalePausa.Size = new System.Drawing.Size(30, 30);
            this.btnMusicxalePausa.TabIndex = 143;
            this.btnMusicxalePausa.TabStop = false;
            this.btnMusicxalePausa.UseVisualStyleBackColor = false;
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolume.AutoSize = true;
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Image = global::LettoreVideo.Properties.Resources.volumeup_giallo;
            this.btnVolume.Location = new System.Drawing.Point(416, 48);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(30, 30);
            this.btnVolume.TabIndex = 144;
            this.btnVolume.TabStop = false;
            this.btnVolume.UseVisualStyleBackColor = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AutoSize = true;
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Image = global::LettoreVideo.Properties.Resources.open_file;
            this.btnOpenFile.Location = new System.Drawing.Point(12, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(38, 38);
            this.btnOpenFile.TabIndex = 145;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.AutoSize = true;
            this.btnOpenDirectory.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenDirectory.FlatAppearance.BorderSize = 0;
            this.btnOpenDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpenDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOpenDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDirectory.Image = global::LettoreVideo.Properties.Resources.open_cartella;
            this.btnOpenDirectory.Location = new System.Drawing.Point(56, 2);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(38, 38);
            this.btnOpenDirectory.TabIndex = 146;
            this.btnOpenDirectory.TabStop = false;
            this.btnOpenDirectory.UseVisualStyleBackColor = false;
            // 
            // btnShowList
            // 
            this.btnShowList.AutoSize = true;
            this.btnShowList.BackColor = System.Drawing.Color.Transparent;
            this.btnShowList.FlatAppearance.BorderSize = 0;
            this.btnShowList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowList.Image = global::LettoreVideo.Properties.Resources.choose_item_from_list;
            this.btnShowList.Location = new System.Drawing.Point(100, 2);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(38, 38);
            this.btnShowList.TabIndex = 147;
            this.btnShowList.TabStop = false;
            this.btnShowList.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::LettoreVideo.Properties.Resources.gomma_biamcablue;
            this.btnClear.Location = new System.Drawing.Point(144, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(38, 38);
            this.btnClear.TabIndex = 148;
            this.btnClear.TabStop = false;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::LettoreVideo.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(184, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 38);
            this.btnSave.TabIndex = 149;
            this.btnSave.TabStop = false;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // mediaSeekBar1
            // 
            this.mediaSeekBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaSeekBar1.Location = new System.Drawing.Point(545, 55);
            this.mediaSeekBar1.Maximum = 100;
            this.mediaSeekBar1.Minimum = 0;
            this.mediaSeekBar1.Name = "mediaSeekBar1";
            this.mediaSeekBar1.Size = new System.Drawing.Size(254, 20);
            this.mediaSeekBar1.TabIndex = 150;
            this.mediaSeekBar1.Value = 0;
            // 
            // btnGeationeArchivio
            // 
            this.btnGeationeArchivio.AutoSize = true;
            this.btnGeationeArchivio.BackColor = System.Drawing.Color.Transparent;
            this.btnGeationeArchivio.FlatAppearance.BorderSize = 0;
            this.btnGeationeArchivio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGeationeArchivio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGeationeArchivio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeationeArchivio.Image = global::LettoreVideo.Properties.Resources.gestione;
            this.btnGeationeArchivio.Location = new System.Drawing.Point(224, 2);
            this.btnGeationeArchivio.Name = "btnGeationeArchivio";
            this.btnGeationeArchivio.Size = new System.Drawing.Size(38, 38);
            this.btnGeationeArchivio.TabIndex = 151;
            this.btnGeationeArchivio.TabStop = false;
            this.btnGeationeArchivio.UseVisualStyleBackColor = false;
            // 
            // btnScegliFromArchivio
            // 
            this.btnScegliFromArchivio.AutoSize = true;
            this.btnScegliFromArchivio.BackColor = System.Drawing.Color.Transparent;
            this.btnScegliFromArchivio.FlatAppearance.BorderSize = 0;
            this.btnScegliFromArchivio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScegliFromArchivio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnScegliFromArchivio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScegliFromArchivio.Image = global::LettoreVideo.Properties.Resources.choose_video;
            this.btnScegliFromArchivio.Location = new System.Drawing.Point(268, 2);
            this.btnScegliFromArchivio.Name = "btnScegliFromArchivio";
            this.btnScegliFromArchivio.Size = new System.Drawing.Size(38, 40);
            this.btnScegliFromArchivio.TabIndex = 152;
            this.btnScegliFromArchivio.TabStop = false;
            this.btnScegliFromArchivio.UseVisualStyleBackColor = false;
            // 
            // knobVelocita
            // 
            this.knobVelocita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.knobVelocita.BackColor = System.Drawing.Color.Transparent;
            this.knobVelocita.EndAngle = 405F;
            this.knobVelocita.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knobVelocita.KnobBackColor = System.Drawing.Color.White;
            this.knobVelocita.KnobPointerStyle = LettoreVideo.Controlli.KnobGioshControl.KnobPointerStyles.line;
            this.knobVelocita.LargeChange = 1;
            this.knobVelocita.Location = new System.Drawing.Point(127, 43);
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
            this.knobVelocita.TabIndex = 153;
            this.knobVelocita.Value = 0;
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(903, 86);
            this.Controls.Add(this.knobVelocita);
            this.Controls.Add(this.btnScegliFromArchivio);
            this.Controls.Add(this.btnGeationeArchivio);
            this.Controls.Add(this.mediaSeekBar1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnOpenDirectory);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnMusicxalePausa);
            this.Controls.Add(this.btnMusicaleIndietroVeloce);
            this.Controls.Add(this.btnMusicalePrecedente);
            this.Controls.Add(this.btnMusicaleAvantiVeloce);
            this.Controls.Add(this.btnMusicaleStopRosso);
            this.Controls.Add(this.btnMusicaDaCapo);
            this.Controls.Add(this.btnMusicaleNext);
            this.Controls.Add(this.btnMusicalePlay);
            this.Controls.Add(this.picVolumeMute);
            this.Controls.Add(this.picVolumeUP);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.txtElapsedTime);
            this.Controls.Add(this.txtContaBrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OverlayForm";
            this.Opacity = 0.85D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OverlayForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.Load += new System.EventHandler(this.OverlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVolumeUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picVolumeMute;
        private PictureBox picVolumeUP;
        private TextBox txtTotalTime;
        private TextBox txtElapsedTime;

        private TextBox txtContaBrani;
        private Button btnMusicalePlay;
        private Button btnMusicaleNext;
        private Button btnMusicaDaCapo;
        private Button btnMusicaleStopRosso;
        private Button btnMusicaleAvantiVeloce;
        private Button btnMusicalePrecedente;
        private Button btnMusicaleIndietroVeloce;
        private Button btnMusicxalePausa;
        private Button btnVolume;
        private Button btnOpenFile;
        private Button btnOpenDirectory;
        private Button btnShowList;
        private Button btnClear;
        private Button btnSave;
        private Controlli.MediaSeekBar mediaSeekBar1;
        private Button btnGeationeArchivio;
        private Button btnScegliFromArchivio;
        private Controlli.KnobGioshControl knobVelocita;
    }
}