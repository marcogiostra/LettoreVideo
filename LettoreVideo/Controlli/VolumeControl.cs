using LettoreVideo.Classi;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LettoreVideo.Controlli
{
    public partial class VolumeControl : UserControl
    {
        private bool _updating;

        public VolumeControl()
        {
            InitializeComponent();
            Load += VolumeControl_Load;
        }

        private void VolumeControl_Load(object sender, EventArgs e)
        {
            _updating = true;
            trackBar1.Value = (int)(AudioManager.GetMasterVolume() * 100);
            AudioManager.SetMasterVolume(trackBar1.Value / 100f);
            lblPercentuale.Text = trackBar1.Value + "%";
            Invalidate();
            _updating = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (_updating) return;

            float vol = trackBar1.Value / 100f;
            AudioManager.SetMasterVolume(vol);
            lblPercentuale.Text = trackBar1.Value + "%";
            Invalidate();

        }
    }

 
}


