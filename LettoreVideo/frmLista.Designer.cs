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
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picUncheckAll = new System.Windows.Forms.PictureBox();
            this.picCheckAll = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picCestino = new System.Windows.Forms.PictureBox();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.picDown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUncheckAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 159);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(589, 395);
            this.checkedListBox1.TabIndex = 59;
            this.checkedListBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseMove);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picExit.Image = global::LettoreVideo.Properties.Resources.Exit_Quadrato_Rosso;
            this.picExit.Location = new System.Drawing.Point(528, 85);
            this.picExit.Margin = new System.Windows.Forms.Padding(4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(34, 34);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picExit.TabIndex = 67;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picUncheckAll
            // 
            this.picUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picUncheckAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUncheckAll.Image = global::LettoreVideo.Properties.Resources.check_list_false1;
            this.picUncheckAll.Location = new System.Drawing.Point(224, 85);
            this.picUncheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.picUncheckAll.Name = "picUncheckAll";
            this.picUncheckAll.Size = new System.Drawing.Size(34, 34);
            this.picUncheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUncheckAll.TabIndex = 61;
            this.picUncheckAll.TabStop = false;
            this.picUncheckAll.Click += new System.EventHandler(this.picUncheckAll_Click);
            // 
            // picCheckAll
            // 
            this.picCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picCheckAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCheckAll.Image = global::LettoreVideo.Properties.Resources.check_list_true1;
            this.picCheckAll.Location = new System.Drawing.Point(171, 85);
            this.picCheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.picCheckAll.Name = "picCheckAll";
            this.picCheckAll.Size = new System.Drawing.Size(34, 34);
            this.picCheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCheckAll.TabIndex = 60;
            this.picCheckAll.TabStop = false;
            this.picCheckAll.Click += new System.EventHandler(this.picCheckAll_Click);
            // 
            // picSave
            // 
            this.picSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSave.Image = global::LettoreVideo.Properties.Resources.do_list_freccia_verede_down;
            this.picSave.Location = new System.Drawing.Point(16, 85);
            this.picSave.Margin = new System.Windows.Forms.Padding(4);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(34, 34);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSave.TabIndex = 58;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // picCestino
            // 
            this.picCestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picCestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCestino.Image = global::LettoreVideo.Properties.Resources.cestino_stilizzato;
            this.picCestino.Location = new System.Drawing.Point(277, 85);
            this.picCestino.Margin = new System.Windows.Forms.Padding(4);
            this.picCestino.Name = "picCestino";
            this.picCestino.Size = new System.Drawing.Size(34, 34);
            this.picCestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCestino.TabIndex = 57;
            this.picCestino.TabStop = false;
            this.picCestino.Click += new System.EventHandler(this.picCestino_Click);
            // 
            // picUp
            // 
            this.picUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUp.Image = global::LettoreVideo.Properties.Resources.semplice_up;
            this.picUp.Location = new System.Drawing.Point(117, 85);
            this.picUp.Margin = new System.Windows.Forms.Padding(4);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(34, 34);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUp.TabIndex = 56;
            this.picUp.TabStop = false;
            this.picUp.Click += new System.EventHandler(this.picUp_Click);
            // 
            // picDown
            // 
            this.picDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDown.Image = global::LettoreVideo.Properties.Resources.semplice_down;
            this.picDown.Location = new System.Drawing.Point(67, 85);
            this.picDown.Margin = new System.Windows.Forms.Padding(4);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(34, 34);
            this.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDown.TabIndex = 55;
            this.picDown.TabStop = false;
            this.picDown.Click += new System.EventHandler(this.picDown_Click);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 554);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picUncheckAll);
            this.Controls.Add(this.picCheckAll);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picCestino);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.picDown);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestore play-list";
            this.Load += new System.EventHandler(this.frmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUncheckAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.PictureBox picCestino;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox picCheckAll;
        private System.Windows.Forms.PictureBox picUncheckAll;
        private System.Windows.Forms.PictureBox picExit;
    }
}