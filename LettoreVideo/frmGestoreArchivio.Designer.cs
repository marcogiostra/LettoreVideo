namespace LettoreVideo
{
    partial class frmGestoreArchivio
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
            this.picUncheckAll = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picCheckAll = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picSave = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picCestino = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 106);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(442, 344);
            this.checkedListBox1.TabIndex = 60;
            this.checkedListBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseMove);
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
            this.picUncheckAll.Location = new System.Drawing.Point(94, 69);
            this.picUncheckAll.Name = "picUncheckAll";
            this.picUncheckAll.Size = new System.Drawing.Size(32, 32);
            this.picUncheckAll.TabIndex = 71;
            this.picUncheckAll.TabStop = false;
            this.picUncheckAll.Click += new System.EventHandler(this.picUncheckAll_Click);
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
            this.picCheckAll.Location = new System.Drawing.Point(54, 68);
            this.picCheckAll.Name = "picCheckAll";
            this.picCheckAll.Size = new System.Drawing.Size(32, 32);
            this.picCheckAll.TabIndex = 70;
            this.picCheckAll.TabStop = false;
            this.picCheckAll.Click += new System.EventHandler(this.picSave_Click);
            // 
            // picSave
            // 
            this.picSave.AutoResize = true;
            this.picSave.BackColor = System.Drawing.SystemColors.Control;
            this.picSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSave.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.picSave.ImageClick = global::LettoreVideo.Properties.Resources.b32_plusitem_click;
            this.picSave.ImageHover = global::LettoreVideo.Properties.Resources.b32_plusitem__hover;
            this.picSave.ImageNormal = global::LettoreVideo.Properties.Resources.b32_plusitem_normal;
            this.picSave.Location = new System.Drawing.Point(12, 68);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(32, 32);
            this.picSave.TabIndex = 69;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
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
            this.picCestino.Location = new System.Drawing.Point(132, 69);
            this.picCestino.Name = "picCestino";
            this.picCestino.Size = new System.Drawing.Size(32, 32);
            this.picCestino.TabIndex = 68;
            this.picCestino.TabStop = false;
            this.picCestino.Click += new System.EventHandler(this.picCestino_Click);
            // 
            // frmGestoreArchivio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.picUncheckAll);
            this.Controls.Add(this.picCheckAll);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picCestino);
            this.Controls.Add(this.checkedListBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestoreArchivio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestione dell\'archivio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Controlli.ExtendedPictureBox picUncheckAll;
        private Controlli.ExtendedPictureBox picCheckAll;
        private Controlli.ExtendedPictureBox picSave;
        private Controlli.ExtendedPictureBox picCestino;
    }
}