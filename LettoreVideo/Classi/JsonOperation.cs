using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettoreVideo.Classi
{
    public class JsonOperation
    {
        public static void Save_DB(List<VideoFileDB> pVID_DB, string pDataFolder)
        {
            string DbFile = Path.Combine(pDataFolder, "db.json");
            try
            {

                if (Directory.Exists(pDataFolder))
                {
                    if (File.Exists(DbFile))
                        System.IO.File.Copy(DbFile, Path.Combine(pDataFolder, "db.bak"), true);
                }

                //string json = JsonConvert.SerializeObject(VID_DBs, Formatting.Indented);
                //File.WriteAllText(DbFile, json);

                Export exportObj = new Export { Data = pVID_DB };

                string json = JsonConvert.SerializeObject(exportObj, Formatting.Indented);
                System.IO.File.WriteAllText(DbFile, json);
            }
            catch (Exception ex)
            {
                if (Directory.Exists(Path.Combine(pDataFolder, "db.bak")))
                {
                    System.IO.File.Copy(Path.Combine(pDataFolder, "db.bak"), DbFile, true);
                }
                PRG.MsgBoxERR(ex, "Errore nella procedura di aggiornamento dell'archivio:\r\n\r\n");
                
            }

            if (File.Exists(Path.Combine(pDataFolder, "db.bak")))
            {
                try
                {
                    System.IO.File.Delete(Path.Combine(pDataFolder, "db.bak"));
                }
                catch (Exception) { }
            }
        }

        public static List<VideoFileDB> Laod_DB (string pDB_Folder)
        {
            string DbFile = Path.Combine(pDB_Folder, "db.json");

            if (!File.Exists(DbFile))
                return new List<VideoFileDB>();

            string json = File.ReadAllText(DbFile);

            Export export = JsonConvert.DeserializeObject<Export>(json);

            if (export == null || export.Data == null)
                return new List<VideoFileDB>();

            // Inizializza le liste Bookmarks che sono null
            foreach (VideoFileDB v in export.Data)
            {
                if (v.Bookmarks == null)
                    v.Bookmarks = new List<Bookmark>();
            }

            return export.Data;
        }

 
    }
}
