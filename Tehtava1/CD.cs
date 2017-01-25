using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    public class CD
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public string SongName { get; set; }
        public CD(string songname)
        {
            SongName = songname;
        }
        public CD() { }
        public override string ToString()
        {
            return "-Name: " + SongName;
        }
    }
}

