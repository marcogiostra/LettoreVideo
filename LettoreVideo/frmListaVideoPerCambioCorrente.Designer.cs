namespace LettoreVideo
{
    partial class frmListaVideoPerCambioCorrente
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
            this.lstPlayList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.picClose.Location = new System.Drawing.Point(511, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 32);
            this.picClose.TabIndex = 0;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Play-list: seleziona il nuovo video corrente ";
            // 
            // lstPlayList
            // 
            this.lstPlayList.BackColor = System.Drawing.Color.Black;
            this.lstPlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPlayList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstPlayList.ForeColor = System.Drawing.Color.White;
            this.lstPlayList.FormattingEnabled = true;
            this.lstPlayList.ItemHeight = 17;
            this.lstPlayList.Location = new System.Drawing.Point(0, 44);
            this.lstPlayList.Name = "lstPlayList";
            this.lstPlayList.Size = new System.Drawing.Size(545, 544);
            this.lstPlayList.TabIndex = 2;
            this.lstPlayList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playlist_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmListaVideoPerCambioCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(545, 588);
            this.Controls.Add(this.lstPlayList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaVideoPerCambioCorrente";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmListaVideoPerCambioCorrente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlli.ExtendedPictureBox picClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPlayList;
        private System.Windows.Forms.Timer timer1;
    }
}