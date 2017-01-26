/*
 * Toteuta ohjelma, joka tallentaa kaikki korttipelin kortit (hertta, ruutu, risti ja pata. Numerot 1-52.) valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön. 
 * Bonustehtävä: kuinka voisit toteuttaa korttipakan sekoittamisen?
 * 
 * Jere Liikka 25.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRekisteri();
        }
        static void TestaaHenkiloRekisteri()
        {
            //luodaan muutaman testi henkilö
            Korttipakka poppoo = new Korttipakka();
            Kortti hlo0 = new Kortti { KortinNumero = 1 };
            Kortti hlo1 = new Kortti { KortinNumero = 1 };
            Kortti hlo2 = new Kortti { KortinNumero = 1 };
            //Lisätään henkilöt poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);
            //tulostetaan poppoo näytölle
            foreach (Kortti h in poppoo.Henkilolista)
            {
                Console.WriteLine("{0}", h.ToString());
            }
            //TODO kysy käyttäjältä hetu ja haetaan sitä vastaava henkilö näytölle

            Console.Write("Hae hlo ");
            Console.WriteLine(poppoo.HaeHenkiloHetulla(Console.ReadLine()));

        }
    }
}
