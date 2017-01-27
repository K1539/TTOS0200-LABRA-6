using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Kortti
    {
        public string KortinNumero { get; set; }
        public string Maa { get; set; }
        public override string ToString()
        {
            return Maa + " " + KortinNumero;
        }
    }
}
