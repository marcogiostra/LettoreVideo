using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettoreVideo.Classi
{
    public static class Funzioni
    {
        public static string GetVersion()
        {
            // Ottieni l'oggetto Assembly corrente
            var assembly = System.Reflection.Assembly.GetEntryAssembly();

            // Ottieni l'oggetto dell'attributo AssemblyVersion
            var versionAttribute = assembly.GetCustomAttributes(typeof(System.Reflection.AssemblyFileVersionAttribute), false) as System.Reflection.AssemblyFileVersionAttribute[];

            // Se non c'è alcun attributo di versione del file, restituisci una stringa vuota
            if (versionAttribute == null || versionAttribute.Length == 0)
                return string.Empty;

            // Ottieni la versione del file
            var version = versionAttribute[0].Version;

            return version;
        }

        public static Int64 GetVersionNumeric()
        {
            // Ottieni l'oggetto Assembly corrente
            var assembly = System.Reflection.Assembly.GetEntryAssembly();

            // Ottieni l'oggetto dell'attributo AssemblyVersion
            var versionAttribute = assembly.GetCustomAttributes(typeof(System.Reflection.AssemblyFileVersionAttribute), false) as System.Reflection.AssemblyFileVersionAttribute[];

            // Se non c'è alcun attributo di versione del file, restituisci una stringa vuota
            if (versionAttribute == null || versionAttribute.Length == 0)
                return 0;

            // Ottieni la versione del file
            var version = versionAttribute[0].Version;

            return 0;
        }

        /*
        public static void CancellaFileDirectoryTemp(Ricettario pBook)
        {
            string saveDIR = string.Empty;
            string tempDIR_P = string.Empty;
            string tempDIR_V = string.Empty;

            if (pBook.GetSave_Dir(ref saveDIR))
            {
                if (pBook.GetTempPhoto_Dir(ref tempDIR_P))
                {
                    if (pBook.GetTempVideo_Dir(ref tempDIR_V))
                    {
                        try
                        {
                            System.IO.DirectoryInfo di = new DirectoryInfo(tempDIR_P);
                            foreach (FileInfo file in di.GetFiles())
                            {
                                file.Delete();
                            }
                            di = null;

                            try
                            {
                                System.IO.DirectoryInfo di2 = new DirectoryInfo(tempDIR_V);
                                foreach (FileInfo file in di2.GetFiles())
                                {
                                    file.Delete();
                                }
                                di2 = null;

                            }
                            catch (Exception ex2)
                            {
                                PRG.MsgBoxERR(ex2, "Errore preparazione iniziale tabella temporane per l'importazione dei video:\r\n\r\n");
                                return;
                            }

                        }
                        catch (Exception ex1)
                        {
                            PRG.MsgBoxERR(ex1, "Errore preparazione iniziale tabella temporane per l'importazione delle immagini:\r\n\r\n");
                            return;

                        }


                    }
                }
            }
        }
        */

    }
}
