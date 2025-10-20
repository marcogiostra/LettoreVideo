using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettoreVideo.Classi
{
    public class VideoFileDB
    {
        public string File { get; set; }
        public string Titolo { get; set; }
        public string Cartella { get; set; }
        public string Filename { get; set; }
    }

    public class Export
    {
        public List<VideoFileDB> Data { get; set; }
    }

}
