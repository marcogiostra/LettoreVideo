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
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 106);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(442, 344);
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
            this.picCestino.Location = new System.Drawing.Point(208, 66);
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
            this.picDown.Location = new System.Drawing.Point(50, 66);
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
            this.picUp.Location = new System.Drawing.Point(90, 68);
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
            this.picSave.Location = new System.Drawing.Point(12, 66);
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
            this.picCheckAll.Location = new System.Drawing.Point(130, 68);
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
            this.picUncheckAll.Location = new System.Drawing.Point(168, 68);
            this.picUncheckAll.Name = "picUncheckAll";
            this.picUncheckAll.Size = new System.Drawing.Size(32, 32);
            this.picUncheckAll.TabIndex = 67;
            this.picUncheckAll.TabStop = false;
            this.picUncheckAll.Click += new System.EventHandler(this.picUncheckAll_Click);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.picUncheckAll);
            this.Controls.Add(this.picCheckAll);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.picCestino);
            this.Controls.Add(this.checkedListBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestore play-list";
            this.Load += new System.EventHandler(this.frmLista_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Controlli.ExtendedPictureBox picCestino;
        private Controlli.ExtendedPictureBox picDown;
        private Controlli.ExtendedPictureBox picUp;
        private Controlli.ExtendedPictureBox picSave;
        private Controlli.ExtendedPictureBox picCheckAll;
        private Controlli.ExtendedPictureBox picUncheckAll;
    }
}