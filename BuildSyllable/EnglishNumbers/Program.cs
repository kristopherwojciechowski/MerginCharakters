using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] liczebnikiSlownie = new string[5] { "one", "two", "three", "four", "five" };
            int[] liczebnikiCyframi = new int[5] { 1, 2, 3, 4, 5};
            string decision;
            //do
            //{
                Random rand = new Random();

                int wylosowanaIndex = rand.Next(liczebnikiCyframi.Length);

                Console.WriteLine("wyslosawana liczba to " + liczebnikiCyframi[wylosowanaIndex] + " -> " + "(" + liczebnikiSlownie[wylosowanaIndex] + ")");

                Console.WriteLine("If you want to continue press n ");
                Console.WriteLine("If you want to leave press e ");

                decision = Console.ReadLine();

            //} while (decision != "e");

            string wylosowanyLiczebnikSlowo = liczebnikiSlownie[wylosowanaIndex];
            int wylosowanyLiczebnikNumer = liczebnikiCyframi[wylosowanaIndex];

            Console.WriteLine("Wylosowana liczba to {0}", wylosowanyLiczebnikNumer);
            Console.WriteLine("Wpisz slownie podany liczebnik:");

            string wpisanyTekst = Console.ReadLine();

            if(wpisanyTekst == wylosowanyLiczebnikSlowo)
            {
                Console.WriteLine("Poprawna pisowania");
            }
            else
            {
                Console.WriteLine("Popraw pisowanie");

            }

        }
    }
}
