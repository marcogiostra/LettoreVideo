using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace LettoreVideo
{
    public partial class InputBoxForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;


        public string ResultText { get; private set; }
       
        public InputBoxForm(string prompt, string title, string defaultValue)
        {
            InitializeComponent();


            //Configuro MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK; // Dark Mode
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Orange200, TextShade.WHITE
            );

            bool isDark = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK;
            labelPrompt.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            labelPrompt.ForeColor = isDark ? Color.White : Color.Black;
            textBox1.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            textBox1.ForeColor = isDark ? Color.White : Color.Black;
            btnOk.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            btnOk.ForeColor = isDark ? Color.White : Color.Black;
            btnCancel.BackColor = isDark ? Color.FromArgb(48, 48, 48) : Color.White;
            btnCancel.ForeColor = isDark ? Color.White : Color.Black;

            this.Text = title;
            labelPrompt.Text = prompt;
            textBox1.Text = defaultValue;   // <<< VALORE PREDEFINITO
            textBox1.SelectionStart = defaultValue.Length;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ResultText = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
