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
            string[] liczebnikiSlownie = new string[20] { "one", "two", "three", "four", "five",
                                                          "six", "seven", "eight", "nine", "ten",
                                                          "eleven", "twelve", "therteen", "fourteen", "fiveteen",
                                                          "sixteeen", "seventeen", "eighteen", "ninrteen", "twenty"};
            string decision;
            string wpisanyTekst;
            int wylosowanyIndex;
            string wylosowanyLiczebnikSlowo;
            int wylosowanyLiczebnikNumer;
            int lastNumber = 0, beforeLustNum = liczebnikiSlownie.Length;
            Random rand = new Random();


            Console.WriteLine("Napisz podyktowane słowo: ");
            wpisanyTekst = Console.ReadLine();

            for(int i=0 ; i<=liczebnikiSlownie.Length; i++)
            {
                if(liczebnikiSlownie[i] != wpisanyTekst)
                {
                    Console.WriteLine("Pisowania NIE poprawna;");
                }
                else
                {
                    Console.WriteLine("Pisowania poprawna;");
                }
            }

            //do
            //{
            //    wylosowanyIndex = rand.Next(liczebnikiSlownie.Length);

            //    if (wylosowanyIndex == lastNumber || wylosowanyIndex == beforeLustNum)
            //    {
            //        do
            //        {
            //            wylosowanyIndex = rand.Next(liczebnikiSlownie.Length);
            //        } while (wylosowanyIndex == lastNumber || wylosowanyIndex == beforeLustNum);
            //    }

            //    beforeLustNum = lastNumber;
            //    lastNumber = wylosowanyIndex;

            //    wylosowanyLiczebnikSlowo = liczebnikiSlownie[wylosowanyIndex];
            //    wylosowanyLiczebnikNumer = liczebnikiCyframi[wylosowanyIndex];

            //    Console.WriteLine("Wylosowana liczba to {0}", wylosowanyLiczebnikNumer);
            //    Console.WriteLine("Wpisz slownie podany liczebnik:");

            //    wpisanyTekst = Console.ReadLine();

            //    if (wpisanyTekst != wylosowanyLiczebnikSlowo)
            //    {
            //        do
            //        {
            //            Console.WriteLine("Popraw pisowanie");
            //            wpisanyTekst = Console.ReadLine();

            //        } while (wpisanyTekst != wylosowanyLiczebnikSlowo);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Poprawna pisowania");
            //    }
            //    Console.WriteLine("Poprawna pisowania");
            //    Console.WriteLine("If you want to continue press n ");
            //    Console.WriteLine("If you want to leave press e ");

            //    decision = Console.ReadLine();
            //}
            //while (decision != "e");

        }
    }
}
