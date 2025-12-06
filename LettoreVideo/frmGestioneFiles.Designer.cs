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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            this.lstFiles = new System.Windows.Forms.ListView();
            this.colFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecifica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilenameOriginale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVisto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiModificaCateogria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateSpecifica = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateVisto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateTitolo = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnALL = new System.Windows.Forms.RadioButton();
            this.rbtnOnlySI = new System.Windows.Forms.RadioButton();
            this.rbtnOnlyNO = new System.Windows.Forms.RadioButton();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFile,
            this.colCategoria,
            this.colSpecifica,
            this.colFilenameOriginale,
            this.colVisto});
            this.lstFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFiles.HideSelection = false;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            this.lstFiles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10});
            this.lstFiles.Location = new System.Drawing.Point(0, 65);
            this.lstFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(1151, 441);
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
            this.cms.Size = new System.Drawing.Size(254, 142);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
            // 
            // tsmiModificaCateogria
            // 
            this.tsmiModificaCateogria.Name = "tsmiModificaCateogria";
            this.tsmiModificaCateogria.Size = new System.Drawing.Size(220, 22);
            this.tsmiModificaCateogria.Text = "Modifica la categoria";
            this.tsmiModificaCateogria.Click += new System.EventHandler(this.tsmiModificaCateogria_Click);
            // 
            // tsmiUpdateSpecifica
            // 
            this.tsmiUpdateSpecifica.Name = "tsmiUpdateSpecifica";
            this.tsmiUpdateSpecifica.Size = new System.Drawing.Size(220, 22);
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // tsmiDeleteItem
            // 
            this.tsmiDeleteItem.Name = "tsmiDeleteItem";
            this.tsmiDeleteItem.Size = new System.Drawing.Size(220, 22);
            this.tsmiDeleteItem.Text = "Escludi il file dall\'archivio";
            this.tsmiDeleteItem.Click += new System.EventHandler(this.tsmiDeleteItem_Click);
            // 
            // tsmiUpdateTitolo
            // 
            this.tsmiUpdateTitolo.Name = "tsmiUpdateTitolo";
            this.tsmiUpdateTitolo.Size = new System.Drawing.Size(220, 22);
            this.tsmiUpdateTitolo.Text = "Modifica il titolo";
            this.tsmiUpdateTitolo.Click += new System.EventHandler(this.tsmiUpdateTitolo_Click);
            // 
            // rbtnALL
            // 
            this.rbtnALL.AutoSize = true;
            this.rbtnALL.Checked = true;
            this.rbtnALL.Location = new System.Drawing.Point(205, 34);
            this.rbtnALL.Name = "rbtnALL";
            this.rbtnALL.Size = new System.Drawing.Size(50, 19);
            this.rbtnALL.TabIndex = 76;
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
            // frmGestioneFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 512);
            this.Controls.Add(this.rbtnOnlyNO);
            this.Controls.Add(this.rbtnOnlySI);
            this.Controls.Add(this.rbtnALL);
            this.Controls.Add(this.lstFiles);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestioneFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}