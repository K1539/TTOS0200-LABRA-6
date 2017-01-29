/*
 * oteuta ohjelma, jolla voidaan lisätä, poistaa ja listata SM-Liiga-joukkueen JYP pelaajia. 
 * Luo Pelaaja-luokka jolla on ominaisuudet Etunimi, Sukunimi, Ikä ja Numero. Löydät täältä JYP pelaajat kaudella 2016-17. 
 * Luo myös Joukkue-luokka. Luokalla on ominnaisuudet Nimi, Kotikaupunki ja Pelaajat. 
 * Ominaisuus Pelaajat on siis lista Pelaaja-olioita. 
 * Tee Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue), jota konstruktori kutsuu. 
 * HaePelaajat metodi luo Pelaajat-listaan oikeat pelaajat.
 * Bonustehtävä: missä ja miten pitäisi pelaajatietoja silloin tallessa kun ohjelma ei ole käynnissä? 
 * Listaa erilaiset vaihtoehdot. Toteuta niistä tekstitiedosto-pohjainen ratkaisu.
 * Jere Liikka 29.1.2017
*/
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
            Joukkue poppoo = new Joukkue();
            Pelaaja hlo = new Pelaaja { Etunimi = "Juho", Sukunimi = "Olkinuora", Ika = 26, Numero = 45 };
            Pelaaja hlo1 = new Pelaaja { Etunimi = "Olli", Sukunimi = "Aitola", Ika = 24, Numero = 60 };
            Pelaaja hlo2 = new Pelaaja { Etunimi = "Joona", Sukunimi = "Erving", Ika = 22, Numero =  53};
            Pelaaja hlo3 = new Pelaaja { Etunimi = "Niklas", Sukunimi = "Friman", Ika = 23, Numero = 20 };
            Pelaaja hlo4 = new Pelaaja { Etunimi = "Jaakko", Sukunimi = "Jokinen", Ika = 23, Numero = 16 };
            Pelaaja hlo5 = new Pelaaja { Etunimi = "Mikko", Sukunimi = "Kalteva", Ika = 32, Numero = 7 };
            Pelaaja hlo6 = new Pelaaja { Etunimi = "Valtteri", Sukunimi = "Hotakainen", Ika = 26, Numero = 21 };
            Pelaaja hlo7 = new Pelaaja { Etunimi = "Juha-Pekka", Sukunimi = "Hytönen", Ika = 35, Numero = 15 };
            Pelaaja hlo8 = new Pelaaja { Etunimi = "Henri", Sukunimi = "Kanninen", Ika = 22, Numero = 71 };
            Pelaaja hlo9 = new Pelaaja { Etunimi = "Janne", Sukunimi = "Kolehmainen", Ika = 30, Numero = 55 };
            Pelaaja hlo10 = new Pelaaja { Etunimi = "Arttu", Sukunimi = "Likola", Ika = 22, Numero = 41 };

            //Lisätään henkilöt poppooseen
            poppoo.HaePelaajat(hlo);
            poppoo.HaePelaajat(hlo1);
            poppoo.HaePelaajat(hlo2);
            poppoo.HaePelaajat(hlo3);
            poppoo.HaePelaajat(hlo4);
            poppoo.HaePelaajat(hlo5);
            poppoo.HaePelaajat(hlo6);
            poppoo.HaePelaajat(hlo7);
            poppoo.HaePelaajat(hlo8);
            poppoo.HaePelaajat(hlo9);
            poppoo.HaePelaajat(hlo10);
            //tulostetaan poppoo näytölle
            foreach (Pelaaja h in poppoo.Henkilolista)
            {
                Console.WriteLine("{0}", h.ToString());
            }
        }
    }
}
