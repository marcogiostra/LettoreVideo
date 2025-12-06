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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnCartella = new System.Windows.Forms.RadioButton();
            this.cmbCartelle = new System.Windows.Forms.ComboBox();
            this.lblTotale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecifica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilenameOriginale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVisto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picSaveAndPlay = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picSave = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picPlus = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picUncheckAll = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.picCheckAll = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.SuspendLayout();
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(9, 66);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(73, 17);
            this.rbtnAll.TabIndex = 62;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Tutti i file";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // rbtnCartella
            // 
            this.rbtnCartella.AutoSize = true;
            this.rbtnCartella.Location = new System.Drawing.Point(9, 90);
            this.rbtnCartella.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnCartella.Name = "rbtnCartella";
            this.rbtnCartella.Size = new System.Drawing.Size(160, 17);
            this.rbtnCartella.TabIndex = 63;
            this.rbtnCartella.Text = "Solo i file di una categoria";
            this.rbtnCartella.UseVisualStyleBackColor = true;
            this.rbtnCartella.CheckedChanged += new System.EventHandler(this.rbtnCartella_CheckedChanged);
            // 
            // cmbCartelle
            // 
            this.cmbCartelle.FormattingEnabled = true;
            this.cmbCartelle.Location = new System.Drawing.Point(173, 89);
            this.cmbCartelle.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCartelle.Name = "cmbCartelle";
            this.cmbCartelle.Size = new System.Drawing.Size(486, 21);
            this.cmbCartelle.TabIndex = 64;
            this.cmbCartelle.SelectedIndexChanged += new System.EventHandler(this.cmbCartelle_SelectedIndexChanged);
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(595, 132);
            this.lblTotale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(14, 13);
            this.lblTotale.TabIndex = 71;
            this.lblTotale.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "File che sono stati selezionati:   ";
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.CheckBoxes = true;
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colCategoria,
            this.colSpecifica,
            this.colFilenameOriginale,
            this.colVisto});
            this.lstFiles.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.lstFiles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lstFiles.Location = new System.Drawing.Point(0, 162);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(1006, 317);
            this.lstFiles.TabIndex = 73;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lstFiles_DrawColumnHeader);
            this.lstFiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstFiles_DrawItem);
            this.lstFiles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lstFiles_DrawSubItem);
            // 
            // colFile
            // 
            this.colFile.Text = "File";
            this.colFile.Width = 530;
            // 
            // colCategoria
            // 
            this.colCategoria.Text = "Categoria";
            this.colCategoria.Width = 200;
            // 
            // colSpecifica
            // 
            this.colSpecifica.Text = "Sottocateogria";
            this.colSpecifica.Width = 200;
            // 
            // colFilenameOriginale
            // 
            this.colFilenameOriginale.Text = "Filenameoriginaloe";
            this.colFilenameOriginale.Width = 0;
            // 
            // colVisto
            // 
            this.colVisto.Text = "Visto?";
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
            this.picSaveAndPlay.Location = new System.Drawing.Point(344, 124);
            this.picSaveAndPlay.Name = "picSaveAndPlay";
            this.picSaveAndPlay.Size = new System.Drawing.Size(32, 32);
            this.picSaveAndPlay.TabIndex = 78;
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
            this.picSave.Location = new System.Drawing.Point(306, 124);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(32, 32);
            this.picSave.TabIndex = 77;
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
            this.picPlus.Location = new System.Drawing.Point(173, 124);
            this.picPlus.Name = "picPlus";
            this.picPlus.Size = new System.Drawing.Size(32, 32);
            this.picPlus.TabIndex = 76;
            this.picPlus.TabStop = false;
            this.picPlus.Click += new System.EventHandler(this.picPlus_Click);
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
            this.picUncheckAll.Location = new System.Drawing.Point(50, 122);
            this.picUncheckAll.Name = "picUncheckAll";
            this.picUncheckAll.Size = new System.Drawing.Size(32, 32);
            this.picUncheckAll.TabIndex = 75;
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
            this.picCheckAll.Location = new System.Drawing.Point(12, 122);
            this.picCheckAll.Name = "picCheckAll";
            this.picCheckAll.Size = new System.Drawing.Size(32, 32);
            this.picCheckAll.TabIndex = 74;
            this.picCheckAll.TabStop = false;
            this.picCheckAll.Click += new System.EventHandler(this.picCheckAll_Click);
            // 
            // frmScegliFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 483);
            this.Controls.Add(this.picSaveAndPlay);
            this.Controls.Add(this.picSave);
            this.Controls.Add(this.picPlus);
            this.Controls.Add(this.picUncheckAll);
            this.Controls.Add(this.picCheckAll);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.cmbCartelle);
            this.Controls.Add(this.rbtnCartella);
            this.Controls.Add(this.rbtnAll);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScegliFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleziona i file da vedere";
            this.Load += new System.EventHandler(this.frmScegliFiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnCartella;
        private System.Windows.Forms.ComboBox cmbCartelle;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colCategoria;
        private System.Windows.Forms.ColumnHeader colSpecifica;
        private System.Windows.Forms.ColumnHeader colFilenameOriginale;
        private Controlli.ExtendedPictureBox picUncheckAll;
        private Controlli.ExtendedPictureBox picCheckAll;
        private Controlli.ExtendedPictureBox picPlus;
        private Controlli.ExtendedPictureBox picSave;
        private System.Windows.Forms.ColumnHeader colVisto;
        private Controlli.ExtendedPictureBox picSaveAndPlay;
    }
}