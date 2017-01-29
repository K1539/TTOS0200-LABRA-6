/*
 * Nimi, Kotikaupunki ja Pelaajat. 
 * Tee Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue), jota konstruktori kutsuu. HaePelaajat metodi luo Pelaajat-listaan oikeat pelaajat.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Joukkue
    {
        //properties
        private List<Pelaaja> henkilot;
        public List<Pelaaja> Henkilolista
        {
            get { return henkilot; }
        }
        public Joukkue()
        {
            henkilot = new List<Pelaaja>();
        }
        public void HaePelaajat(Pelaaja joukkue)
        {
            henkilot.Add(joukkue);
        }
    }
}
