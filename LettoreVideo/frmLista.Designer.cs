namespace LettoreVideo
{
    partial class frmLista
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.picCestino = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picDown = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picUp = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picSave = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picCheckAll = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picUncheckAll = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Black;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 89);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(442, 361);
            this.checkedListBox1.TabIndex = 59;
            // 
            // picCestino
            // 
            this.picCestino.AutoResize = true;
            this.picCestino.BackColor = System.Drawing.SystemColors.Control;
            this.picCestino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCestino.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picCestino.ImageClick = global::LettoreVideo.Properties.Resources.b32_garbage_click;
            this.picCestino.ImageHover = global::LettoreVideo.Properties.Resources.b32_garbage_hover;
            this.picCestino.ImageNormal = global::LettoreVideo.Properties.Resources.b32_garbage_normal;
            this.picCestino.Location = new System.Drawing.Point(208, 37);
            this.picCestino.Name = "picCestino";
            this.picCestino.Size = new System.Drawing.Size(32, 32);
            this.picCestino.TabIndex = 62;
            this.picCestino.TabStop = false;
            this.picCestino.Click += new System.EventHandler(this.picCestino_Click);
            // 
            // picDown
            // 
            this.picDown.AutoResize = true;
            this.picDown.BackColor = System.Drawing.SystemColors.Control;
            this.picDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDown.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picDown.ImageClick = global::LettoreVideo.Properties.Resources.b32_down_click;
            this.picDown.ImageHover = global::LettoreVideo.Properties.Resources.b32_down_hover;
            this.picDown.ImageNormal = global::LettoreVideo.Properties.Resources.b32_down__normal;
            this.picDown.Location = new System.Drawing.Point(50, 37);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(32, 32);
            this.picDown.TabIndex = 63;
            this.picDown.TabStop = false;
            this.picDown.Click += new System.EventHandler(this.picDown_Click);
            // 
            // picUp
            // 
            this.picUp.AutoResize = true;
            this.picUp.BackColor = System.Drawing.SystemColors.Control;
            this.picUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUp.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picUp.ImageClick = global::LettoreVideo.Properties.Resources.b32_up_click;
            this.picUp.ImageHover = global::LettoreVideo.Properties.Resources.b32_up_hover;
            this.picUp.ImageNormal = global::LettoreVideo.Properties.Resources.b32_up_normal;
            this.picUp.Location = new System.Drawing.Point(90, 39);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(32, 32);
            this.picUp.TabIndex = 64;
            this.picUp.TabStop = false;
            this.picUp.Click += new System.EventHandler(this.picUp_Click);
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
            this.picSave.Location = new System.Drawing.Point(12, 37);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(32, 32);
            this.picSave.TabIndex = 65;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // picCheckAll
            // 
            this.picCheckAll.AutoResize = true;
            this.picCheckAll.BackColor = System.Drawing.SystemColors.Control;
            this.picCheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckAll.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picCheckAll.ImageClick = global::LettoreVideo.Properties.Resources.b32_checek_click;
            this.picCheckAll.ImageHover = global::LettoreVideo.Properties.Resources.b32_checek_hover;
            this.picCheckAll.ImageNormal = global::LettoreVideo.Properties.Resources.b32_checek_normal;
            this.picCheckAll.Location = new System.Drawing.Point(130, 39);
            this.picCheckAll.Name = "picCheckAll";
            this.picCheckAll.Size = new System.Drawing.Size(32, 32);
            this.picCheckAll.TabIndex = 66;
            this.picCheckAll.TabStop = false;
            this.picCheckAll.Click += new System.EventHandler(this.picCheckAll_Click);
            // 
            // picUncheckAll
            // 
            this.picUncheckAll.AutoResize = true;
            this.picUncheckAll.BackColor = System.Drawing.SystemColors.Control;
            this.picUncheckAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUncheckAll.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picUncheckAll.ImageClick = global::LettoreVideo.Properties.Resources.b32_unchecek_click;
            this.picUncheckAll.ImageHover = global::LettoreVideo.Properties.Resources.b32_unchecek_hover;
            this.picUncheckAll.ImageNormal = global::LettoreVideo.Properties.Resources.b32_unchecek_normal;
            this.picUncheckAll.Location = new System.Drawing.Point(168, 39);
            this.picUncheckAll.Name = "picUncheckAll";
            this.picUncheckAll.Size = new System.Drawing.Size(32, 32);
            this.picUncheckAll.TabIndex = 67;
            this.picUncheckAll.TabStop = false;
            this.picUncheckAll.Click += new System.EventHandler(this.picUncheckAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Gestore play-list";
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
            this.picClose.Location = new System.Drawing.Point(403, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 32);
            this.picClose.TabIndex = 68;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picUncheckAll);
            this.Controls.Add(this.picCheckAll);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.picCestino);
            this.Controls.Add(this.checkedListBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLista";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestore play-list";
            this.Load += new System.EventHandler(this.frmLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Controlli.ExtendedPictureBox picCestino;
        private Controlli.ExtendedPictureBox picDown;
        private Controlli.ExtendedPictureBox picUp;
        private Controlli.ExtendedPictureBox picSave;
        private Controlli.ExtendedPictureBox picCheckAll;
        private Controlli.ExtendedPictureBox picUncheckAll;
        private System.Windows.Forms.Label label1;
        private Controlli.ExtendedPictureBox picClose;
    }
}