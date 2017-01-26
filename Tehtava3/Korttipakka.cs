using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Korttipakka
    {
        //properties
        private List<Kortti> henkilot;
        public List<Kortti> Henkilolista
        {
            get { return henkilot; }
        }
        public Korttipakka()
        {
            henkilot = new List<Kortti>();
        }
        public void LisaaHenkilo(Kortti hlo)
        {
            henkilot.Add(hlo);
        }
        public Kortti HaeHenkilo(int index)
        {
            if (index < henkilot.Count)
            {
                return henkilot.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

    }
}

