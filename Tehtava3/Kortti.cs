using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Kortti
    {
        public int Value { get; set; }
        public string Nimi { get; set; }

        public Kortti (string nimi, int value)
        {
            Nimi = nimi;
            Value = value;
        }

        public string PrintCard()
        {
            return Nimi + " " + Value;
        }
    }
}
