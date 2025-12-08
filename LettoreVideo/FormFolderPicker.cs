using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LettoreVideo
{
    
    public partial class FormFolderPicker : Form
    {
        // Estensioni dei file video
        private readonly string[] videoExtensions = new[] { ".mp4", ".mkv", ".avi", ".divx" };

        // Ultima cartella selezionata (puoi salvare nei Settings)
        private string ultimaCartella = @"C:\";

        // Cartella selezionata dall'utente
        public string CartellaSelezionata { get; private set; }

        public string PathIniziale { get; set; }

        #region DICHIARAZIONI
        private string _Title = "Seleziona una cartella";
        public string Title
        { 
            get { return _Title; }
            set { _Title = value; this.Text = value; }
        }

        #endregion DICHIARAZIONI

        #region Class
        public FormFolderPicker()
        {
            InitializeComponent();
        }
        private void FormFolderPicker_Load(object sender, EventArgs e)
        {
            LoadTree();
        }
        #endregion Class

        #region f()
        private void LoadTree()
        {
            treeFolders.Nodes.Clear();

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                TreeNode driveNode = new TreeNode(drive.Name) { Tag = drive.RootDirectory.FullName };
                driveNode.Nodes.Add("..."); // nodo fittizio per espansione
                treeFolders.Nodes.Add(driveNode);
            }

            treeFolders.BeforeExpand += TreeFolders_BeforeExpand;

            // === SELEZIONA IL PERCORSO INIZIALE ===
            if (Directory.Exists(PathIniziale))
            {
                SelezionaPercorsoIniziale(PathIniziale);
            }
        }

        private void SelezionaPercorsoIniziale(string fullPath)
        {
            fullPath = Path.GetFullPath(fullPath).TrimEnd('\\');

            string root = Directory.GetDirectoryRoot(fullPath).TrimEnd('\\');
            string relative = fullPath.Substring(root.Length).TrimStart('\\');

            // 1️⃣ trova il nodo del drive corretto (C:, D:, ecc.)
            TreeNode driveNode = treeFolders.Nodes
                .Cast<TreeNode>()
                .FirstOrDefault(n =>
                    string.Equals(
                        n.Tag.ToString().TrimEnd('\\'),
                        root,
                        StringComparison.OrdinalIgnoreCase)
                );

            if (driveNode == null)
                return;

            // espandi il nodo del drive
            ExpandNode(driveNode);
            driveNode.Expand();

            TreeNode currentNode = driveNode;

            // 2️⃣ percorri ogni sottocartella
            if (!string.IsNullOrEmpty(relative))
            {
                string[] parts = relative.Split('\\');

                foreach (string part in parts)
                {
                    // Forza l'espansione
                    ExpandNode(currentNode);

                    currentNode.Expand();

                    currentNode = currentNode.Nodes
                        .Cast<TreeNode>()
                        .FirstOrDefault(n =>
                            string.Equals(n.Text, part, StringComparison.OrdinalIgnoreCase)
                        );

                    if (currentNode == null)
                        return; // cartella non trovata
                }
            }

            // 3️⃣ seleziona la cartella trovata
            treeFolders.SelectedNode = currentNode;
            currentNode.EnsureVisible();

            // mostra i file
            LoadFiles(fullPath);
        }

        private void ExpandNode(TreeNode node)
        {
            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "...")
            {
                TreeFolders_BeforeExpand(treeFolders,
                    new TreeViewCancelEventArgs(node, false, TreeViewAction.Expand));
            }
        }

        private void LoadFiles(string folderPath)
        {
            listFiles.Items.Clear();
            try
            {
                var files = Directory.GetFiles(folderPath)
                    .Where(f => videoExtensions.Contains(Path.GetExtension(f).ToLower()));

                foreach (var file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    var item = new ListViewItem(new[]
                    {
                        Path.GetFileName(file),
                        (fi.Length / 1024).ToString("N0")
                    });
                    listFiles.Items.Add(item);
                }
            }
            catch { /* accesso negato */ }
        }
        #endregion f()

        #region TREEVIEW
        private void treeFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            LoadFiles(path);
        }
        private void TreeFolders_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "...")
            {
                e.Node.Nodes.Clear();
                try
                {
                    string path = e.Node.Tag.ToString();
                    var directories = Directory.GetDirectories(path);
                    foreach (var dir in directories)
                    {
                        TreeNode node = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                        node.Nodes.Add("..."); // nodo fittizio
                        e.Node.Nodes.Add(node);
                    }
                }
                catch { }
            }
        }
        #endregion TREEVIEW


        #region PULSANTIERA
        private void btnSeleziona_Click(object sender, EventArgs e)
        {
         
            if (treeFolders.SelectedNode != null)
            {
                CartellaSelezionata = treeFolders.SelectedNode.Tag.ToString();
                ultimaCartella = CartellaSelezionata;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleziona prima una cartella!");
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }
        #endregion PULSANTIERA
    }
}

