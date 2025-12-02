using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo.Classi
{
    public static class MyInputBox
    {
        public static string Show(string prompt, string title = "", string defaultValue = "")
        {
            using (var frm = new InputBoxForm(prompt, title, defaultValue))
            {
                return frm.ShowDialog() == DialogResult.OK
                    ? frm.ResultText
                    : null;
            }
        }
    }

}
