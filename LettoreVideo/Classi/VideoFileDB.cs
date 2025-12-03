using Newtonsoft.Json;
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
        public string Categoria { get; set; }
        public string Specifica { get; set; }

        [JsonIgnore] 
        public string Filename { get; set; }
        public string FilenameOriginale { get; set; }
        public bool Visto { get; set; }
    }

    public class Export
    {
        public List<VideoFileDB> Data { get; set; }
    }

}
