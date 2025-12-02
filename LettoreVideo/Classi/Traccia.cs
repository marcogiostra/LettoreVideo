using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettoreVideo.Classi
{
    public class Traccia
    {
        public int id { get; set; }
        public string Description { get; set; }

        public override string ToString() => Description;
    }
}
