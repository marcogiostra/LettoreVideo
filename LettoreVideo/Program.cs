using LettoreVideo.Classi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo
{
    internal static class Program
    {
        // Nome unico per il mutex (puoi cambiarlo)
        private static Mutex _mutex;

        [DllImport("user32.dll")] private static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;

            // Crea o prova ad aprire il mutex
            _mutex = new Mutex(true, "LettoreVideoMG", out createdNew);

            // Se esiste già un'istanza, attivala e termina
            if (!createdNew)
            {
                BringExistingInstanceToFront();
                return;
            }

            /*
            if (!createdNew)
            {
                var current = Process.GetCurrentProcess();
                foreach (var p in Process.GetProcessesByName(current.ProcessName))
                {
                    if (p.Id != current.Id)
                    {
                        SetForegroundWindow(p.MainWindowHandle);
                        break;
                    }
                }
                return;
            }
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmMain());
            List<VideoFile> videoFiles = new List<VideoFile>();
            Application.Run(new frmVideoNEW());
        }

        private static void BringExistingInstanceToFront()
        {
            var current = Process.GetCurrentProcess();

            foreach (var p in Process.GetProcessesByName(current.ProcessName))
            {
                if (p.Id != current.Id)
                {
                    IntPtr handle = p.MainWindowHandle;

                    if (handle != IntPtr.Zero)
                        SetForegroundWindow(handle);

                    break;
                }
            }
        }
    }

    
}
