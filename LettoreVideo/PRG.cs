using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettoreVideo
{
    public static class PRG
    {
        public  const string Title = "Lettore video";

        #region MessageBox

        public static bool EXMessage { get; set; }

        public static void MsgBox(string pMessage, string pTitle = "", MessageBoxButtons pButton = MessageBoxButtons.OK, MessageBoxIcon pIcon = MessageBoxIcon.Exclamation)
        {
            MessageBox.Show(pMessage, (string.IsNullOrEmpty(pTitle) ? Title : pTitle), pButton, pIcon);
        }

        public static void MsgBoxWarning(string pMessage, string pTitle = "", MessageBoxButtons pButton = MessageBoxButtons.OK, MessageBoxIcon pIcon = MessageBoxIcon.Warning)
        {
            MessageBox.Show(pMessage, (string.IsNullOrEmpty(pTitle) ? Title : pTitle), pButton, pIcon);
        }

        public static void MsgBoxExcvlamation(string pMessage, string pTitle = "", MessageBoxButtons pButton = MessageBoxButtons.OK, MessageBoxIcon pIcon = MessageBoxIcon.Exclamation)
        {
            MessageBox.Show(pMessage, (string.IsNullOrEmpty(pTitle) ? Title : pTitle), pButton, pIcon);
        }

        public static void MsgBoxERR(Exception pEX,string pMessage, string pTitle = "", MessageBoxButtons pButton = MessageBoxButtons.OK, MessageBoxIcon pIcon = MessageBoxIcon.Error)
        {
            
            MessageBox.Show(pMessage + (EXMessage ? pEX.Message : pEX.ToString()), (string.IsNullOrEmpty(pTitle) ? Title : pTitle), pButton, pIcon);
        }

        public static bool MsgBoxYesNo(string pMessage, string pTitle = "")
        {
            if (MessageBox.Show(pMessage, (string.IsNullOrEmpty(pTitle) ? Title : pTitle), MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        public static DialogResult MsgBoxYesNoCancel(string pMessage, string pTitle = "")
        {
            return MessageBox.Show(pMessage, (string.IsNullOrEmpty(pTitle) ? Title : pTitle), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static DialogResult MsgBoxOkCancel(string pMessage, string pTitle = "")
        {
            return MessageBox.Show(pMessage, (string.IsNullOrEmpty(pTitle) ? Title : pTitle), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        #endregion MessageBox

        #region KEYPRESS
        public const string KEYS_UPPPER = "ABCDEFGHIJKLMNOPQRSTUVWXY";
        public const string KEYS_NUMBER = "0123456789";
        public const string KEYS_LOWER = "abcdefghijklmnopqrstuvwxyz";
        public const string KEYS_ACCENTATE = "àìòùèéç";
        public const string KEYS_PARENTESI = "[](){}";
        public const string KEYS_ALGEBRA = "=*+-:.,%<>";
        public const string KEYS_ALGEBRASHORT = "-.,";
        public const string KEYS_MONEY = "£$€";
        public const string KEYS_PUNTEGGIATURA = ".:,;!?";
        public const string KEYS_APICI = "'\"";
        public const string KEYS_SLASH = "\\/";
        public const string KEYS_SPACE = " ";
        public const string KEYS_VARI = "|^°#_&";

        public static bool OnKeyPress(object sender, KeyPressEventArgs e, string pKeyFilter = "")
        {

            // Stringa di caratteri permessi
            string caratteriPermessi = string.Empty;
            if (string.IsNullOrEmpty(pKeyFilter))
                caratteriPermessi = KEYS_UPPPER + KEYS_NUMBER + KEYS_LOWER + KEYS_ACCENTATE + 
                                        KEYS_PARENTESI + KEYS_ALGEBRA + KEYS_ALGEBRASHORT + KEYS_MONEY +
                                        KEYS_PUNTEGGIATURA + KEYS_APICI + KEYS_SLASH + KEYS_SPACE + KEYS_VARI;
            else
                caratteriPermessi = pKeyFilter;

            // Controlla se il carattere digitato non è contenuto nella stringa di caratteri permessi
            if (!caratteriPermessi.Contains(caratteriPermessi )) 
            {
                // Impedisce al carattere di essere inserito
                return true;
            }

            return false;

        }
        #endregion KEYPRESS

    }
}
