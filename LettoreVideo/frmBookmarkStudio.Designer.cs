namespace LettoreVideo
{
    partial class frmBookmarkStudio
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
            this.picClose = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBookMark = new System.Windows.Forms.ListBox();
            this.picPlus = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picCancella = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picSave = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.AutoResize = true;
            this.picClose.BackColor = System.Drawing.SystemColors.Control;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.ImageClick = global::LettoreVideo.Properties.Resources.b32_close_clickr;
            this.picClose.ImageHover = global::LettoreVideo.Properties.Resources.b32_close_hover;
            this.picClose.ImageNormal = global::LettoreVideo.Properties.Resources.b32_close_normal;
            this.picClose.Location = new System.Drawing.Point(244, 5);
            this.picClose.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 32);
            this.picClose.TabIndex = 1;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestore bookmark del viideo corrente";
            // 
            // lstBookMark
            // 
            this.lstBookMark.BackColor = System.Drawing.Color.Black;
            this.lstBookMark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBookMark.ForeColor = System.Drawing.Color.White;
            this.lstBookMark.FormattingEnabled = true;
            this.lstBookMark.ItemHeight = 17;
            this.lstBookMark.Location = new System.Drawing.Point(1, 47);
            this.lstBookMark.Name = "lstBookMark";
            this.lstBookMark.Size = new System.Drawing.Size(282, 510);
            this.lstBookMark.TabIndex = 3;
            // 
            // picPlus
            // 
            this.picPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPlus.AutoResize = true;
            this.picPlus.BackColor = System.Drawing.SystemColors.Control;
            this.picPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlus.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picPlus.ImageClick = global::LettoreVideo.Properties.Resources.b32_plus_click;
            this.picPlus.ImageHover = global::LettoreVideo.Properties.Resources.b32_plus_hover;
            this.picPlus.ImageNormal = global::LettoreVideo.Properties.Resources.b32_plus_normal;
            this.picPlus.Location = new System.Drawing.Point(122, 569);
            this.picPlus.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.picPlus.Name = "picPlus";
            this.picPlus.Size = new System.Drawing.Size(32, 32);
            this.picPlus.TabIndex = 4;
            this.picPlus.Click += new System.EventHandler(this.picPlus_Click);
            // 
            // picCancella
            // 
            this.picCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCancella.AutoResize = true;
            this.picCancella.BackColor = System.Drawing.SystemColors.Control;
            this.picCancella.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCancella.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picCancella.ImageClick = global::LettoreVideo.Properties.Resources.b32_cestino_click;
            this.picCancella.ImageHover = global::LettoreVideo.Properties.Resources.b32_cestino_hover;
            this.picCancella.ImageNormal = global::LettoreVideo.Properties.Resources.b32_cestino_normal;
            this.picCancella.Location = new System.Drawing.Point(235, 569);
            this.picCancella.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.picCancella.Name = "picCancella";
            this.picCancella.Size = new System.Drawing.Size(32, 32);
            this.picCancella.TabIndex = 5;
            this.picCancella.Click += new System.EventHandler(this.picCancella_Click);
            // 
            // picSave
            // 
            this.picSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSave.AutoResize = true;
            this.picSave.BackColor = System.Drawing.SystemColors.Control;
            this.picSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSave.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picSave.ImageClick = global::LettoreVideo.Properties.Resources.b32_floppy_click;
            this.picSave.ImageHover = global::LettoreVideo.Properties.Resources.b32_floppy_hover;
            this.picSave.ImageNormal = global::LettoreVideo.Properties.Resources.b32_floppy_normal;
            this.picSave.Location = new System.Drawing.Point(9, 565);
            this.picSave.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(32, 32);
            this.picSave.TabIndex = 6;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBookmarkStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 628);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picCancella);
            this.Controls.Add(this.picPlus);
            this.Controls.Add(this.lstBookMark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBookmarkStudio";
            this.Opacity = 0.7D;
            this.Text = "frmBookmarkStudio";
            this.Load += new System.EventHandler(this.frmBookmarkStudio_Load);
            this.Resize += new System.EventHandler(this.frmBookmarkStudio_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlli.ExtendedPictureBox picClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBookMark;
        private Controlli.ExtendedPictureBox picPlus;
        private Controlli.ExtendedPictureBox picCancella;
        private Controlli.ExtendedPictureBox picSave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}