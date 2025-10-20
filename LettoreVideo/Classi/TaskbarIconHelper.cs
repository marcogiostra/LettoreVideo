using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo.Classi
{
    public static class TaskbarIconHelper
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_SETICON = 0x0080;

        public static void SetTaskbarIcon(Form form, Icon icon)
        {
            IntPtr handle = form.Handle;
            SendMessage(handle, WM_SETICON, new IntPtr(1), icon.Handle); // 1 = ICON_BIG (taskbar)
            SendMessage(handle, WM_SETICON, IntPtr.Zero, icon.Handle);   // 0 = ICON_SMALL (title bar)
        }
    }
}
