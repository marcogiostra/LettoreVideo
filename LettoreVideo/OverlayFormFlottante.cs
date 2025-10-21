using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LettoreVideo
{
    // Filtro globale per intercettare i movimenti del mouse
    public class GlobalMouseMoveFilter : IMessageFilter
    {
        public event MouseEventHandler MouseMove;

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x200) // WM_MOUSEMOVE
            {
                Point p = Control.MousePosition;
                MouseMove?.Invoke(null, new MouseEventArgs(MouseButtons.None, 0, p.X, p.Y, 0));
            }
            return false;
        }
    }

    public partial class OverlayFormFlottante : Form
    {
        private frmVideoNEW _OwnerForm;
        private Button closeButton;
        private Timer slideTimer;
        private bool isVisibleTarget = false;
        private int targetX, hiddenX;
        private int slideSpeed = 20;
        private GlobalMouseMoveFilter mouseFilter;

        private Timer mouseCheckTimer;
        public int TriggerZoneSize { get; set; } = 80;

        public OverlayFormFlottante(frmVideoNEW pOwnrForm)
        {
            _OwnerForm = pOwnrForm;

            // Form senza bordi
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.ShowInTaskbar = false;

            this.Size = new Size(40, 40);
            this.BackColor = Color.Black;

            closeButton = new Button
            {
                Text = "X",
                Size = new Size(40, 40),
                Location = new Point(0, 0),
                Font = new Font("Tahoma", 10, FontStyle.Bold),
                BackColor = Color.DarkRed,
                ForeColor = Color.White
            };
            this.Controls.Add(closeButton);
            closeButton.Click += (s, e) => this.Owner?.Close();

            slideTimer = new Timer { Interval = 15 };
            slideTimer.Tick += SlideTimer_Tick;
        }

        /*
        public void AttachToForm(Form parent)
        {
            this.Owner = parent;
            this.StartPosition = FormStartPosition.Manual;

            targetX = parent.Right - this.Width - 5;
            hiddenX = parent.Right + 5;
            this.Location = new Point(hiddenX, parent.Top + 5);
            this.Show(parent);

            parent.Resize += Parent_Resize;

            // Attiva il filtro globale per intercettare i movimenti del mouse
            mouseFilter = new GlobalMouseMoveFilter();
            mouseFilter.MouseMove += Parent_MouseMove;
            Application.AddMessageFilter(mouseFilter);
        }
        */

        public void AttachToForm(Form parent)
        {
            this.Owner = parent;
            this.StartPosition = FormStartPosition.Manual;

            targetX = parent.Right - this.Width - 5;
            hiddenX = parent.Right + 5;
            this.Location = new Point(hiddenX, parent.Top + 5);
            this.Show(parent);

            parent.Resize += Parent_Resize;

            mouseCheckTimer = new Timer { Interval = 50 }; // ogni 50 ms
            mouseCheckTimer.Tick += (s, e) => CheckMousePosition();
            mouseCheckTimer.Start();
        }

        private void CheckMousePosition()
        {
            var parent = this.Owner;
            if (parent == null) return;

            Point mousePos = parent.PointToClient(Cursor.Position);

            bool inTopRight;
            if (_OwnerForm.isPlaying)
            {
                inTopRight = (mousePos.X >= _OwnerForm.VideoControlWidth() - TriggerZoneSize &&
                              mousePos.Y <= TriggerZoneSize);
            }
            else
            {
                inTopRight = (mousePos.X >= parent.ClientSize.Width - TriggerZoneSize &&
                              mousePos.Y <= TriggerZoneSize);
            }


            if (inTopRight && !isVisibleTarget)
            {
                isVisibleTarget = true;
                slideTimer.Start();
            }
            else if (!inTopRight && isVisibleTarget)
            {
                isVisibleTarget = false;
                slideTimer.Start();
            }
        }

        private void Parent_Resize(object sender, EventArgs e)
        {
            var parent = this.Owner;
            targetX = parent.Right - this.Width - 5;
            hiddenX = parent.Right + 5;
        }

        private void Parent_MouseMove(object sender, MouseEventArgs e)
        {
            this.BringToFront();
            bool inTopRight = false;
            var parent = this.Owner;
            Point mousePos = parent.PointToClient(Cursor.Position);

            if (_OwnerForm.isPlaying)
            {
                inTopRight = (mousePos.X >= _OwnerForm.VideoControlWidth() - TriggerZoneSize &&
                              mousePos.Y <= TriggerZoneSize);
            }
            else
            {
                inTopRight = (mousePos.X >= parent.ClientSize.Width - TriggerZoneSize &&
                              mousePos.Y <= TriggerZoneSize);
            }

            string output = inTopRight ? "VERO" : "FALSE";
            if (_OwnerForm.isPlaying)
            {
                output = "PLAYING " + output;
            }

            if (inTopRight && !isVisibleTarget)
            {
                isVisibleTarget = true;
                slideTimer.Start();
            }
            else if (!inTopRight && isVisibleTarget)
            {
                isVisibleTarget = false;
                slideTimer.Start();
            }
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (isVisibleTarget)
            {
                if (this.Left > targetX)
                {
                    this.Left -= slideSpeed;
                    if (this.Left < targetX) this.Left = targetX;
                }
                else slideTimer.Stop();
            }
            else
            {
                if (this.Left < hiddenX)
                {
                    this.Left += slideSpeed;
                    if (this.Left > hiddenX) this.Left = hiddenX;
                }
                else slideTimer.Stop();
            }
        }
    }
}
