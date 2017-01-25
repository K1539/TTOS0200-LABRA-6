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
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo  { Etunimi = "Jack",  Sukunimi = "Russell", Hetu = "128594-265G" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Jaakko", Sukunimi = "Ruotio", Hetu = "134678-265G" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Julius", Sukunimi = "Raitio", Hetu = "876534-265G" };
            //Lisätään henkilöt poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);
            //tulostetaan poppoo näytölle
            foreach (Henkilo h in poppoo.Henkilolista)
            {
                Console.WriteLine("{0}",h.ToString());
            }
            //TODO kysy käyttäjältä hetu ja haetaan sitä vastaava henkilö näytölle

            Console.WriteLine("Hae hlo ");
            Console.WriteLine("asd" + poppoo.HaeHenkiloHetulla(Console.ReadLine()));

        }
    }
}
