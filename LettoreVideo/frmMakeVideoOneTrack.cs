using LettoreVideo.Classi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo
{
    public partial class frmMakeVideoOneTrack : Form
    {
        #region DICHIARAZIONI
        private string _SourceFileName { get; set; }
        private List<Traccia> _AUDIOs = new List<Traccia>();
        private int _SelectedAUDIOIndex = -1;
        #region PARAMETRI
        #endregion PARAMETRI

        #endregion DICHIARAZIONI

        #region Class
        public frmMakeVideoOneTrack(string pSourceFileName, List<Traccia> pAUDIOs, int pSelectedAUDIOIndex)
        {
            _SourceFileName = pSourceFileName;
            _AUDIOs = pAUDIOs;
            _SelectedAUDIOIndex = pSelectedAUDIOIndex;

            InitializeComponent();

            lblTipo.Text = Path.GetExtension(_SourceFileName);

        }

        private void frmMakeVideoOneTrack_Load(object sender, EventArgs e)
        {
            ComboLoadTracce();
        }
        #endregion Class

        #region f()
        public void ComboLoadTracce()
        {
            cmbAudio.Items.Clear();
            foreach (Traccia t in _AUDIOs)
            {
                cmbAudio.Items.Add(t);
            }
            cmbAudio.SelectedIndex = _SelectedAUDIOIndex;

        }
        #endregion f()

        #region PULSANTERIA
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSave_Click(object sender, EventArgs e)
        {
            // Pulizia e controllo titolo
            txtTitle.Text = txtTitle.Text.Trim();
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Inserire un titolo valido.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = _SourceFileName;

            if (!File.Exists(input))
            {
                MessageBox.Show("File sorgente non trovato.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ext = Path.GetExtension(input); // ".mp4", ".mkv", ecc.

            // Creazione cartella Video\LettoreVideoMG se non esiste
            string videosFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            string targetFolder = Path.Combine(videosFolder, "LettoreVideoMG");
            if (!Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);

            string destinationPath = string.Empty;

            // Apri SaveFileDialog con nome personalizzato
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = targetFolder;

                // Nome file suggerito dall'utente (txtTitle) + estensione originale
                string safeFileName = Path.GetFileNameWithoutExtension(txtTitle.Text) + ext;
                sfd.FileName = safeFileName;

                sfd.Filter = "File video|*" + ext;
                sfd.Title = "Scegli dove salvare il nuovo video";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    destinationPath = sfd.FileName;
                }
            }

            if (string.IsNullOrEmpty(destinationPath))
                return;

            // Controllo sovrascrittura
            if (File.Exists(destinationPath))
            {
                var result = MessageBox.Show("Il file di destinazione esiste già. Sovrascrivere?",
                                             "Conferma Sovrascrittura",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
            }

            int audioIndex = cmbAudio.SelectedIndex; // FFmpeg parte da 0
            string log = string.Empty;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string ffmpegPath = Path.Combine(Application.StartupPath, "ffmpeg", "ffmpeg.exe");

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = "-i \"" + input + "\" -map 0:v -map 0:a:" + audioIndex + " -c copy \"" + destinationPath + "\"",
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                using (Process proc = Process.Start(psi))
                {
                    // FFmpeg scrive la maggior parte dei log su StandardError
                    log = proc.StandardError.ReadToEnd();
                    proc.WaitForExit();

                    if (proc.ExitCode != 0)
                    {
                        // Salva log completo su file
                        string logFile = Path.Combine(Path.GetDirectoryName(destinationPath), "ffmpeg_error_log.txt");
                        File.WriteAllText(logFile, log);

                        // Mostra solo ultime 20 righe nel MessageBox
                        const int maxLines = 20;
                        string[] lines = log.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                        string shortLog = log;
                        if (lines.Length > maxLines)
                        {
                            shortLog = string.Join(Environment.NewLine, lines.Skip(lines.Length - maxLines));
                        }

                        MessageBox.Show("Errore durante la creazione del file.\n\n" + shortLog +
                                        "\n\nLog completo salvato in:\n" + logFile,
                                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Verifica se il file è stato creato correttamente
                if (File.Exists(destinationPath))
                {
                    MessageBox.Show("File creato correttamente:\n" + Path.GetFileName(destinationPath),
                                    "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // chiude il form se necessario
                }
                else
                {
                    MessageBox.Show("FFmpeg non ha creato il file. Controllare il log:\n\n" + log,
                                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore imprevisto:\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        /*
        private void picSave_Click(object sender, EventArgs e)
        {
            txtTitle.Text = txtTitle.Text.Trim();
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Inserire un titolo valido.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = _SourceFileName;

            if (!File.Exists(input))
            {
                MessageBox.Show("File sorgente non trovato.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ext = Path.GetExtension(input); // ".mp4", ".mkv", ecc.

            // Creazione cartella Video\LettoreVideoMG se non esiste
            string videosFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            string targetFolder = Path.Combine(videosFolder, "LettoreVideoMG");
            if (!Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);

            string destinationPath = string.Empty;      
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.InitialDirectory = targetFolder;

                // Solo il nome del file, non il percorso completo
                string safeFileName = Path.GetFileNameWithoutExtension(_SourceFileName) + ext;
                sfd.FileName = safeFileName;

                sfd.Filter = "File video|*" + ext;
                sfd.Title = "Scegli dove salvare il nuovo video";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    destinationPath = sfd.FileName;
                }
            }


            if (string.IsNullOrEmpty(destinationPath))
                return;

            if (File.Exists(destinationPath))
            {
                var result = MessageBox.Show("Il file di destinazione esiste già. Sovrascrivere?", "Conferma Sovrascrittura",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
            }

            int audioIndex = cmbAudio.SelectedIndex; // FFmpeg parte da 0

            string log = string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string ffmpegPath = Path.Combine(Application.StartupPath, "ffmpeg", "ffmpeg.exe");

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = "-i \"" + input + "\" -map 0:v -map 0:a:" + audioIndex + " -c copy \"" + destinationPath + "\"",
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                using (Process proc = Process.Start(psi))
                {
                    log = proc.StandardError.ReadToEnd();
                    proc.WaitForExit();

                    // Controllo codice di uscita FFmpeg
                    if (proc.ExitCode != 0)
                    {
                        MessageBox.Show("Errore durante la creazione del file.\n\n" + log,
                                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Controllo se il file output esiste
                if (File.Exists(destinationPath))
                {
                    MessageBox.Show("File creato correttamente:\n" + destinationPath,
                                    "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    string logFile = Path.Combine(Path.GetDirectoryName(destinationPath), "ffmpeg_error_log.txt");
                    File.WriteAllText(logFile, log);

                    string shortLog = log;
                    const int maxLines = 20;
                    string[] lines = log.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                    if (lines.Length > maxLines)
                    {
                        shortLog = string.Join(Environment.NewLine, lines.Skip(lines.Length - maxLines));
                    }

                    MessageBox.Show("Errore durante la creazione del file.\n\n" + shortLog +
                                    "\n\nLog completo salvato in:\n" + logFile,
                                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore imprevisto:\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        */

        #endregion PULSANTERIA

    }
}
