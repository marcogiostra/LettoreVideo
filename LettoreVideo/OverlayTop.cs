using LettoreVideo.Controlli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo
{
    public partial class OverlayTop : Form
    {
        Form _owner = new Form();

        public OverlayTop()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Black;
            this.Opacity = 0.6; // trasparenza

            #region GESTORE
            picOpenFile.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_OPEN_FILE();
            };

            picOpenDirectory.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_OPEN_DIR();
            };

            picShowList.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_SHOW_LIST();

            };


            picClear.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_CLEAR();

            };


            picSave.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_SAVE();

            };

   

            picScegliFromArchivio.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_SCEGLI_VIDEO_DA_ARCHIVIO();

            };

            picCategory.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_GESTIONE_CATEGORIE();

            };

            picClose.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_CLOSE_FORM();

            };

            picGestioneBookmark.Click += (s, e) =>
            {
                // chiama un metodo nel form principale
                if (this.Owner is frmVideoNEW main)
                    main.External_GESTIONE_BOOKMARKS();
            };

            #endregion GESTORE

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.picSave, "Salva i nuovi filmati in archivio");
            toolTip1.SetToolTip(this.picOpenFile, "Seleziona nuovi video");
            toolTip1.SetToolTip(this.picOpenDirectory, "Selziona tutti i video di una cartella");
            toolTip1.SetToolTip(this.picCategory, "Gestione arcihvio");
            toolTip1.SetToolTip(this.picClear, "Cancella la lista dei video da vedere");
            toolTip1.SetToolTip(this.picScegliFromArchivio, "Aggiungi video dall'archivio alla play-list");
            toolTip1.SetToolTip(this.picShowList, "Gestione play-list");
            toolTip1.SetToolTip(this.picGestioneBookmark, "Gestione bookmarks");
        }

        private void OVerlayBottom_Resize(object sender, EventArgs e)
        {
            int _width = this.Width;
            int _height = this.Height;
            int spazio = 10;
            int buttonWidth = picClear.Width;
            int totalButtons = this.Controls.OfType<ExtendedPictureBox>().Count() - 1; // esclude picClose
            int totalWidth = (totalButtons * buttonWidth) + ((totalButtons - 1) * spazio);
            int firstButtonLeft = (_width - totalWidth) / 2;

            picOpenFile.Location = new Point(firstButtonLeft, (_height - picCategory.Height) / 2);
            picOpenDirectory.Location = new Point(picOpenFile.Right + spazio, picOpenFile.Top);
            picShowList.Location = new Point(picOpenDirectory.Right + spazio, picOpenFile.Top);
            picClear.Location = new Point(picShowList.Right + spazio, picOpenFile.Top);
            picSave.Location = new Point(picClear.Right + spazio, picOpenFile.Top);
            picScegliFromArchivio.Location = new Point(picSave.Right + spazio, picOpenFile.Top);
            picCategory.Location = new Point(picScegliFromArchivio.Right + spazio, picOpenFile.Top);
            picGestioneBookmark.Location = new Point(picCategory.Right + spazio, picOpenFile.Top);


            


            picClose.Location = new Point(_width - 10 - picClose.Width, picOpenFile.Top);


        }
        public void SetOwner(Form owner)
        {
            if (owner != null)
            {
                _owner.Owner = owner;
            }
        }
    }



}
