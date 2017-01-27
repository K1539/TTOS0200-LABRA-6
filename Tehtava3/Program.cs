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
            LisaaPataKortit();
        }
        public static void LisaaPataKortit()
        {
            //pata
            Korttipakka poppoo = new Korttipakka();
            Kortti pata1 = new Kortti { KortinNumero = "1", Maa = "Pata" };
            Kortti pata2 = new Kortti { KortinNumero = "2", Maa = "Pata" };
            Kortti pata3 = new Kortti { KortinNumero = "3", Maa = "Pata" };
            Kortti pata4 = new Kortti { KortinNumero = "4", Maa = "Pata" };
            Kortti pata5 = new Kortti { KortinNumero = "5", Maa = "Pata" };
            Kortti pata6 = new Kortti { KortinNumero = "6", Maa = "Pata" };
            Kortti pata7 = new Kortti { KortinNumero = "7", Maa = "Pata" };
            Kortti pata8 = new Kortti { KortinNumero = "8", Maa = "Pata" };
            Kortti pata9 = new Kortti { KortinNumero = "9", Maa = "Pata" };
            Kortti pata10 = new Kortti { KortinNumero = "10", Maa = "Pata" };
            Kortti patajatka = new Kortti { KortinNumero = "jätkä", Maa = "Pata" };
            Kortti pataakka = new Kortti { KortinNumero = "akka", Maa = "Pata" };
            Kortti patakurko = new Kortti { KortinNumero = "kurko", Maa = "Pata" };
            //hertta
            Kortti hertta1 = new Kortti { KortinNumero = "1", Maa = "hertta" };
            Kortti hertta2 = new Kortti { KortinNumero = "2", Maa = "hertta" };
            Kortti hertta3 = new Kortti { KortinNumero = "3", Maa = "hertta" };
            Kortti hertta4 = new Kortti { KortinNumero = "4", Maa = "hertta" };
            Kortti hertta5 = new Kortti { KortinNumero = "5", Maa = "hertta" };
            Kortti hertta6 = new Kortti { KortinNumero = "6", Maa = "hertta" };
            Kortti hertta7 = new Kortti { KortinNumero = "7", Maa = "hertta" };
            Kortti hertta8 = new Kortti { KortinNumero = "8", Maa = "hertta" };
            Kortti hertta9 = new Kortti { KortinNumero = "9", Maa = "hertta" };
            Kortti hertta10 = new Kortti { KortinNumero = "10", Maa = "hertta" };
            Kortti herttajatka = new Kortti { KortinNumero = "jätkä", Maa = "hertta" };
            Kortti herttaakka = new Kortti { KortinNumero = "akka", Maa = "hertta" };
            Kortti herttakurko = new Kortti { KortinNumero = "kurko", Maa = "hertta" };
            //risti
            Kortti risti1 = new Kortti { KortinNumero = "1", Maa = "risti" };
            Kortti risti2 = new Kortti { KortinNumero = "2", Maa = "risti" };
            Kortti risti3 = new Kortti { KortinNumero = "3", Maa = "risti" };
            Kortti risti4 = new Kortti { KortinNumero = "4", Maa = "risti" };
            Kortti risti5 = new Kortti { KortinNumero = "5", Maa = "risti" };
            Kortti risti6 = new Kortti { KortinNumero = "6", Maa = "risti" };
            Kortti risti7 = new Kortti { KortinNumero = "7", Maa = "risti" };
            Kortti risti8 = new Kortti { KortinNumero = "8", Maa = "risti" };
            Kortti risti9 = new Kortti { KortinNumero = "9", Maa = "risti" };
            Kortti risti10 = new Kortti { KortinNumero = "10", Maa = "risti" };
            Kortti ristijatka = new Kortti { KortinNumero = "jätkä", Maa = "risti" };
            Kortti ristiakka = new Kortti { KortinNumero = "akka", Maa = "risti" };
            Kortti ristikurko = new Kortti { KortinNumero = "kurko", Maa = "risti" };
            //ruutu
            Kortti ruutu1 = new Kortti { KortinNumero = "1", Maa = "ruutu" };
            Kortti ruutu2 = new Kortti { KortinNumero = "2", Maa = "ruutu" };
            Kortti ruutu3 = new Kortti { KortinNumero = "3", Maa = "ruutu" };
            Kortti ruutu4 = new Kortti { KortinNumero = "4", Maa = "ruutu" };
            Kortti ruutu5 = new Kortti { KortinNumero = "5", Maa = "ruutu" };
            Kortti ruutu6 = new Kortti { KortinNumero = "6", Maa = "ruutu" };
            Kortti ruutu7 = new Kortti { KortinNumero = "7", Maa = "ruutu" };
            Kortti ruutu8 = new Kortti { KortinNumero = "8", Maa = "ruutu" };
            Kortti ruutu9 = new Kortti { KortinNumero = "9", Maa = "ruutu" };
            Kortti ruutu10 = new Kortti { KortinNumero = "10", Maa = "ruutu" };
            Kortti ruutujatka = new Kortti { KortinNumero = "jätkä", Maa = "ruutu" };
            Kortti ruutuakka = new Kortti { KortinNumero = "akka", Maa = "ruutu" };
            Kortti ruutukurko = new Kortti { KortinNumero = "kurko", Maa = "ruutu" };
            //Lisätään kortit pakkaan
            poppoo.LisaaHenkilo(pata1);
            poppoo.LisaaHenkilo(pata2);
            poppoo.LisaaHenkilo(pata3);
            poppoo.LisaaHenkilo(pata4);
            poppoo.LisaaHenkilo(pata5);
            poppoo.LisaaHenkilo(pata6);
            poppoo.LisaaHenkilo(pata7);
            poppoo.LisaaHenkilo(pata8);
            poppoo.LisaaHenkilo(pata9);
            poppoo.LisaaHenkilo(pata10);
            poppoo.LisaaHenkilo(patajatka);
            poppoo.LisaaHenkilo(pataakka);
            poppoo.LisaaHenkilo(patakurko);
            //
            poppoo.LisaaHenkilo(hertta1);
            poppoo.LisaaHenkilo(hertta2);
            poppoo.LisaaHenkilo(hertta3);
            poppoo.LisaaHenkilo(hertta4);
            poppoo.LisaaHenkilo(hertta5);
            poppoo.LisaaHenkilo(hertta6);
            poppoo.LisaaHenkilo(hertta7);
            poppoo.LisaaHenkilo(hertta8);
            poppoo.LisaaHenkilo(hertta9);
            poppoo.LisaaHenkilo(hertta10);
            poppoo.LisaaHenkilo(herttajatka);
            poppoo.LisaaHenkilo(herttaakka);
            poppoo.LisaaHenkilo(herttakurko);
            //
            poppoo.LisaaHenkilo(risti1);
            poppoo.LisaaHenkilo(risti2);
            poppoo.LisaaHenkilo(risti3);
            poppoo.LisaaHenkilo(risti4);
            poppoo.LisaaHenkilo(risti5);
            poppoo.LisaaHenkilo(risti6);
            poppoo.LisaaHenkilo(risti7);
            poppoo.LisaaHenkilo(risti8);
            poppoo.LisaaHenkilo(risti9);
            poppoo.LisaaHenkilo(risti10);
            poppoo.LisaaHenkilo(ristijatka);
            poppoo.LisaaHenkilo(ristiakka);
            poppoo.LisaaHenkilo(ristikurko);
            //
            poppoo.LisaaHenkilo(ruutu1);
            poppoo.LisaaHenkilo(ruutu2);
            poppoo.LisaaHenkilo(ruutu3);
            poppoo.LisaaHenkilo(ruutu4);
            poppoo.LisaaHenkilo(ruutu5);
            poppoo.LisaaHenkilo(ruutu6);
            poppoo.LisaaHenkilo(ruutu7);
            poppoo.LisaaHenkilo(ruutu8);
            poppoo.LisaaHenkilo(ruutu9);
            poppoo.LisaaHenkilo(ruutu10);
            poppoo.LisaaHenkilo(ruutujatka);
            poppoo.LisaaHenkilo(ruutuakka);
            poppoo.LisaaHenkilo(ruutukurko);
            foreach (Kortti h in poppoo.Henkilolista)
            {
                Console.WriteLine(h.ToString());
            }
        }

     }
}
