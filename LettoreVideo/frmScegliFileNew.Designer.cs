namespace LettoreVideo
{
    partial class frmScegliFileNew
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.picClose = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picSaveAndPlay = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picSave = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picPlus = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotale = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1153, 452);
            this.gridControl1.TabIndex = 83;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupPanelText = "Trascina la colonna per raggruppare . . .";
            this.gridView1.Name = "gridView1";
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.AutoResize = true;
            this.picClose.BackColor = System.Drawing.SystemColors.Control;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.ImageClick = global::LettoreVideo.Properties.Resources.b32_close_clickr;
            this.picClose.ImageHover = global::LettoreVideo.Properties.Resources.b32_close_hover;
            this.picClose.ImageNormal = global::LettoreVideo.Properties.Resources.b32_close_normal;
            this.picClose.Location = new System.Drawing.Point(1103, 4);
            this.picClose.Margin = new System.Windows.Forms.Padding(6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(43, 43);
            this.picClose.TabIndex = 82;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "Seleziona i file da vedere";
            // 
            // picSaveAndPlay
            // 
            this.picSaveAndPlay.AutoResize = true;
            this.picSaveAndPlay.BackColor = System.Drawing.SystemColors.Control;
            this.picSaveAndPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSaveAndPlay.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picSaveAndPlay.ImageClick = global::LettoreVideo.Properties.Resources.b32_download_verde_click;
            this.picSaveAndPlay.ImageHover = global::LettoreVideo.Properties.Resources.b32_download_verde_hover;
            this.picSaveAndPlay.ImageNormal = global::LettoreVideo.Properties.Resources.b32_download_verde_normal;
            this.picSaveAndPlay.Location = new System.Drawing.Point(298, 17);
            this.picSaveAndPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picSaveAndPlay.Name = "picSaveAndPlay";
            this.picSaveAndPlay.Size = new System.Drawing.Size(37, 37);
            this.picSaveAndPlay.TabIndex = 89;
            this.picSaveAndPlay.TabStop = false;
            this.picSaveAndPlay.Click += new System.EventHandler(this.picSaveAndPlay_Click);
            // 
            // picSave
            // 
            this.picSave.AutoResize = true;
            this.picSave.BackColor = System.Drawing.SystemColors.Control;
            this.picSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSave.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picSave.ImageClick = global::LettoreVideo.Properties.Resources.b32_download_click;
            this.picSave.ImageHover = global::LettoreVideo.Properties.Resources.b32_download_hover;
            this.picSave.ImageNormal = global::LettoreVideo.Properties.Resources.b32_download_normal;
            this.picSave.Location = new System.Drawing.Point(253, 17);
            this.picSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(37, 37);
            this.picSave.TabIndex = 88;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // picPlus
            // 
            this.picPlus.AutoResize = true;
            this.picPlus.BackColor = System.Drawing.SystemColors.Control;
            this.picPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlus.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picPlus.ImageClick = global::LettoreVideo.Properties.Resources.b32_plus_click;
            this.picPlus.ImageHover = global::LettoreVideo.Properties.Resources.b32_plus_hover;
            this.picPlus.ImageNormal = global::LettoreVideo.Properties.Resources.b32_plus_normal;
            this.picPlus.Location = new System.Drawing.Point(172, 17);
            this.picPlus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picPlus.Name = "picPlus";
            this.picPlus.Size = new System.Drawing.Size(37, 37);
            this.picPlus.TabIndex = 87;
            this.picPlus.TabStop = false;
            this.picPlus.Click += new System.EventHandler(this.picPlus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 15);
            this.label2.TabIndex = 86;
            this.label2.Text = "File che sono stati selezionati:   ";
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(572, 32);
            this.lblTotale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(14, 13);
            this.lblTotale.TabIndex = 85;
            this.lblTotale.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmScegliFileNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1153, 512);
            this.Controls.Add(this.picSaveAndPlay);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.picClose);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScegliFileNew";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestione archivio";
            this.Load += new System.EventHandler(this.frmScegliFileNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Controlli.ExtendedPictureBox picClose;
        private System.Windows.Forms.Label label1;
        private Controlli.ExtendedPictureBox picSaveAndPlay;
        private Controlli.ExtendedPictureBox picSave;
        private Controlli.ExtendedPictureBox picPlus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Timer timer1;
    }
}