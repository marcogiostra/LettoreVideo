namespace LettoreVideo
{
    partial class frmScegliFiles
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
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnCartella = new System.Windows.Forms.RadioButton();
            this.cmbCartelle = new System.Windows.Forms.ComboBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picUncheckAll = new System.Windows.Forms.PictureBox();
            this.picCheckAll = new System.Windows.Forms.PictureBox();
            this.picPlus = new System.Windows.Forms.PictureBox();
            this.lblTotale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUncheckAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 195);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(673, 276);
            this.checkedListBox1.TabIndex = 61;
            this.checkedListBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseMove);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(12, 81);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(79, 20);
            this.rbtnAll.TabIndex = 62;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Tutti i file";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // rbtnCartella
            // 
            this.rbtnCartella.AutoSize = true;
            this.rbtnCartella.Location = new System.Drawing.Point(12, 111);
            this.rbtnCartella.Name = "rbtnCartella";
            this.rbtnCartella.Size = new System.Drawing.Size(168, 20);
            this.rbtnCartella.TabIndex = 63;
            this.rbtnCartella.Text = "Solo i file di una cartella";
            this.rbtnCartella.UseVisualStyleBackColor = true;
            this.rbtnCartella.CheckedChanged += new System.EventHandler(this.rbtnCartella_CheckedChanged);
            // 
            // cmbCartelle
            // 
            this.cmbCartelle.FormattingEnabled = true;
            this.cmbCartelle.Location = new System.Drawing.Point(214, 110);
            this.cmbCartelle.Name = "cmbCartelle";
            this.cmbCartelle.Size = new System.Drawing.Size(434, 24);
            this.cmbCartelle.TabIndex = 64;
            this.cmbCartelle.SelectedIndexChanged += new System.EventHandler(this.cmbCartelle_SelectedIndexChanged);
            // 
            // picSave
            // 
            this.picSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSave.Image = global::LettoreVideo.Properties.Resources.save_freccia;
            this.picSave.Location = new System.Drawing.Point(139, 153);
            this.picSave.Margin = new System.Windows.Forms.Padding(4);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(34, 34);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSave.TabIndex = 70;
            this.picSave.TabStop = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            // 
            // picExit
            // 
            this.picExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picExit.Image = global::LettoreVideo.Properties.Resources.Exit_Quadrato_Rosso;
            this.picExit.Location = new System.Drawing.Point(626, 153);
            this.picExit.Margin = new System.Windows.Forms.Padding(4);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(34, 34);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picExit.TabIndex = 69;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picUncheckAll
            // 
            this.picUncheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picUncheckAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUncheckAll.Image = global::LettoreVideo.Properties.Resources.check_list_false1;
            this.picUncheckAll.Location = new System.Drawing.Point(55, 153);
            this.picUncheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.picUncheckAll.Name = "picUncheckAll";
            this.picUncheckAll.Size = new System.Drawing.Size(34, 34);
            this.picUncheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUncheckAll.TabIndex = 68;
            this.picUncheckAll.TabStop = false;
            this.picUncheckAll.Click += new System.EventHandler(this.picUncheckAll_Click);
            // 
            // picCheckAll
            // 
            this.picCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picCheckAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCheckAll.Image = global::LettoreVideo.Properties.Resources.check_list_true1;
            this.picCheckAll.Location = new System.Drawing.Point(13, 153);
            this.picCheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.picCheckAll.Name = "picCheckAll";
            this.picCheckAll.Size = new System.Drawing.Size(34, 34);
            this.picCheckAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCheckAll.TabIndex = 67;
            this.picCheckAll.TabStop = false;
            this.picCheckAll.Click += new System.EventHandler(this.picCheckAll_Click);
            // 
            // picPlus
            // 
            this.picPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picPlus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlus.Image = global::LettoreVideo.Properties.Resources.plus;
            this.picPlus.Location = new System.Drawing.Point(97, 153);
            this.picPlus.Margin = new System.Windows.Forms.Padding(4);
            this.picPlus.Name = "picPlus";
            this.picPlus.Size = new System.Drawing.Size(34, 34);
            this.picPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlus.TabIndex = 66;
            this.picPlus.TabStop = false;
            this.picPlus.Click += new System.EventHandler(this.picPlus_Click);
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(403, 160);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(15, 16);
            this.lblTotale.TabIndex = 71;
            this.lblTotale.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "File che sono stati selezionati:   ";
            // 
            // frmScegliFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picUncheckAll);
            this.Controls.Add(this.picCheckAll);
            this.Controls.Add(this.picPlus);
            this.Controls.Add(this.cmbCartelle);
            this.Controls.Add(this.rbtnCartella);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.checkedListBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScegliFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleziona i file da vedere";
            this.Load += new System.EventHandler(this.frmScegliFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUncheckAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnCartella;
        private System.Windows.Forms.ComboBox cmbCartelle;
        private System.Windows.Forms.PictureBox picUncheckAll;
        private System.Windows.Forms.PictureBox picCheckAll;
        private System.Windows.Forms.PictureBox picPlus;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Label label2;
    }
}