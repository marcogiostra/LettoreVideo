namespace LettoreVideo
{
    partial class frmGestioneFiles
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.lstFiles = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecifica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilenameOriginale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVisto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdateTitolo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificaCateogria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateSpecifica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateVisto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnALL = new System.Windows.Forms.RadioButton();
            this.rbtnOnlySI = new System.Windows.Forms.RadioButton();
            this.rbtnOnlyNO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new LettoreVideo.Controlli.ExtendedPictureBox();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.Color.Black;
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colCategoria,
            this.colSpecifica,
            this.colFilenameOriginale,
            this.colVisto});
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFiles.ForeColor = System.Drawing.Color.White;
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.lstFiles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lstFiles.Location = new System.Drawing.Point(0, 59);
            this.lstFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstFiles.MultiSelect = false;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(1153, 453);
            this.lstFiles.TabIndex = 75;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lstFiles_DrawColumnHeader);
            this.lstFiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lstFiles_DrawItem);
            this.lstFiles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lstFiles_DrawSubItem);
            this.lstFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstFiles_MouseDown);
            this.lstFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstFiles_MouseUp);
            // 
            // colFile
            // 
            this.colFile.Text = "Titolo";
            this.colFile.Width = 680;
            // 
            // colCategoria
            // 
            this.colCategoria.Text = "Categoria";
            this.colCategoria.Width = 200;
            // 
            // colSpecifica
            // 
            this.colSpecifica.Text = "Sottocategoria";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdateTitolo,
            this.tsmiModificaCateogria,
            this.tsmiUpdateSpecifica,
            this.tsmiUpdateVisto,
            this.toolStripSeparator1,
            this.tsmiDeleteItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(254, 120);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
            // 
            // tsmiUpdateTitolo
            // 
            this.tsmiUpdateTitolo.Name = "tsmiUpdateTitolo";
            this.tsmiUpdateTitolo.Size = new System.Drawing.Size(253, 22);
            this.tsmiUpdateTitolo.Text = "Modifica il titolo";
            this.tsmiUpdateTitolo.Click += new System.EventHandler(this.tsmiUpdateTitolo_Click);
            // 
            // tsmiModificaCateogria
            // 
            this.tsmiModificaCateogria.Name = "tsmiModificaCateogria";
            this.tsmiModificaCateogria.Size = new System.Drawing.Size(253, 22);
            this.tsmiModificaCateogria.Text = "Modifica la categoria";
            this.tsmiModificaCateogria.Click += new System.EventHandler(this.tsmiModificaCateogria_Click);
            // 
            // tsmiUpdateSpecifica
            // 
            this.tsmiUpdateSpecifica.Name = "tsmiUpdateSpecifica";
            this.tsmiUpdateSpecifica.Size = new System.Drawing.Size(253, 22);
            this.tsmiUpdateSpecifica.Text = "Modifica la sottocateogria";
            this.tsmiUpdateSpecifica.Click += new System.EventHandler(this.tsmiUpdateSpecifica_Click);
            // 
            // tsmiUpdateVisto
            // 
            this.tsmiUpdateVisto.Name = "tsmiUpdateVisto";
            this.tsmiUpdateVisto.Size = new System.Drawing.Size(253, 22);
            this.tsmiUpdateVisto.Text = "Inverti lo stato di visione del video";
            this.tsmiUpdateVisto.Click += new System.EventHandler(this.tsmiUpdateVisto_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
            // 
            // tsmiDeleteItem
            // 
            this.tsmiDeleteItem.Name = "tsmiDeleteItem";
            this.tsmiDeleteItem.Size = new System.Drawing.Size(253, 22);
            this.tsmiDeleteItem.Text = "Escludi il file dall\'archivio";
            this.tsmiDeleteItem.Click += new System.EventHandler(this.tsmiDeleteItem_Click);
            // 
            // rbtnALL
            // 
            this.rbtnALL.AutoSize = true;
            this.rbtnALL.Checked = true;
            this.rbtnALL.Location = new System.Drawing.Point(205, 34);
            this.rbtnALL.Name = "rbtnALL";
            this.rbtnALL.Size = new System.Drawing.Size(50, 19);
            this.rbtnALL.TabIndex = 76;
            this.rbtnALL.TabStop = true;
            this.rbtnALL.Text = "Tutti";
            this.rbtnALL.UseVisualStyleBackColor = true;
            this.rbtnALL.CheckedChanged += new System.EventHandler(this.rbtnALL_CheckedChanged);
            // 
            // rbtnOnlySI
            // 
            this.rbtnOnlySI.AutoSize = true;
            this.rbtnOnlySI.Location = new System.Drawing.Point(261, 34);
            this.rbtnOnlySI.Name = "rbtnOnlySI";
            this.rbtnOnlySI.Size = new System.Drawing.Size(104, 19);
            this.rbtnOnlySI.TabIndex = 77;
            this.rbtnOnlySI.Text = "Solo quelli visti";
            this.rbtnOnlySI.UseVisualStyleBackColor = true;
            this.rbtnOnlySI.CheckedChanged += new System.EventHandler(this.rbtnOnlySI_CheckedChanged);
            // 
            // rbtnOnlyNO
            // 
            this.rbtnOnlyNO.AutoSize = true;
            this.rbtnOnlyNO.Location = new System.Drawing.Point(371, 34);
            this.rbtnOnlyNO.Name = "rbtnOnlyNO";
            this.rbtnOnlyNO.Size = new System.Drawing.Size(128, 19);
            this.rbtnOnlyNO.TabIndex = 78;
            this.rbtnOnlyNO.Text = "Solo quelli non visti";
            this.rbtnOnlyNO.UseVisualStyleBackColor = true;
            this.rbtnOnlyNO.CheckedChanged += new System.EventHandler(this.rbtnOnlyNO_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 80;
            this.label1.Text = "Gestione archivio";
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
            this.picClose.Location = new System.Drawing.Point(1108, 6);
            this.picClose.Margin = new System.Windows.Forms.Padding(5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(37, 37);
            this.picClose.TabIndex = 79;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // frmGestioneFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1153, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.rbtnOnlyNO);
            this.Controls.Add(this.rbtnOnlySI);
            this.Controls.Add(this.rbtnALL);
            this.Controls.Add(this.lstFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestioneFiles";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestione archivio";
            this.Load += new System.EventHandler(this.frmGestioneFilecs_Load);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.ColumnHeader colFile;
        private System.Windows.Forms.ColumnHeader colCategoria;
        private System.Windows.Forms.ColumnHeader colSpecifica;
        private System.Windows.Forms.ColumnHeader colFilenameOriginale;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificaCateogria;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateSpecifica;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteItem;
        private System.Windows.Forms.ColumnHeader colVisto;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateVisto;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateTitolo;
        private System.Windows.Forms.RadioButton rbtnALL;
        private System.Windows.Forms.RadioButton rbtnOnlySI;
        private System.Windows.Forms.RadioButton rbtnOnlyNO;
        private System.Windows.Forms.Label label1;
        private Controlli.ExtendedPictureBox picClose;
    }
}