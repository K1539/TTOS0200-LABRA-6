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
            int[] KorttiPakka = new int[52];

            for (int i = 0; i < KorttiPakka.Length; i++)
            {
                KorttiPakka[i] = (i + 1);
                Console.WriteLine(KorttiPakka[i]);
            }

            

        }
    }
}
