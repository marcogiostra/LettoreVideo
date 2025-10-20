using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettoreVideo.Classi
{
    public class VideoFile: VideoFileDB
    {
        public int ID { get; set; }
        //public string File { get; set; }
        //public string Titolo { get; set; }
        //public string Cartella { get; set; }
        //public string Filename { get; set; }
        public bool Saved { get; set; }

        public override string ToString()
        {
            return Titolo;
        }

    }
}
