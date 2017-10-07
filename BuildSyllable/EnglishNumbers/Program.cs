using System;
using System.IO;
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
            FileStream fileStream = new FileStream("englishNumbers.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            string[] liczebnikiSlownie = new string[28] { "one", "two", "three", "four", "five",
                                                          "six", "seven", "eight", "nine", "ten",
                                                          "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                                                          "sixteen", "seventeen", "eighteen", "nineteen", "twenty",
                                                          "thirty", "forty", "fifty", "sixty", "seventy",
                                                          "eighty", "ninety", "one hundred"};
            int[] liczebnikiCyframi = new int[28] { 1, 2, 3, 4, 5,
                                                   6, 7, 8, 9, 10,
                                                   11, 12, 13, 14, 15,
                                                   16, 17, 18, 19, 20,
                                                   30, 40, 50, 60, 70,
                                                   80, 90, 100};
            string decision;
            string wpisanyTekst;
            int wylosowanyIndex;
            string wylosowanyLiczebnikSlowo;
            int wylosowanyLiczebnikNumer;
            int lastNumber = 0, beforeLustNum = liczebnikiCyframi.Length;
            Random rand = new Random();

            do
            {
                wylosowanyIndex = rand.Next(liczebnikiCyframi.Length);

                if (wylosowanyIndex == lastNumber || wylosowanyIndex == beforeLustNum)
                {
                    do
                    {
                        wylosowanyIndex = rand.Next(liczebnikiCyframi.Length);
                    } while (wylosowanyIndex == lastNumber || wylosowanyIndex == beforeLustNum);
                }

                beforeLustNum = lastNumber;
                lastNumber = wylosowanyIndex;

                wylosowanyLiczebnikSlowo = liczebnikiSlownie[wylosowanyIndex];
                wylosowanyLiczebnikNumer = liczebnikiCyframi[wylosowanyIndex];

                Console.WriteLine("Wylosowana liczba to {0}", wylosowanyLiczebnikNumer);
                Console.WriteLine("Wpisz slownie podany liczebnik:");

                wpisanyTekst = Console.ReadLine();

                if (wpisanyTekst != wylosowanyLiczebnikSlowo)
                {
                    do
                    {
                        Console.WriteLine("Popraw pisownie");
                        wpisanyTekst = Console.ReadLine();

                    } while (wpisanyTekst != wylosowanyLiczebnikSlowo);

                }
                else
                {
                    Console.WriteLine("Poprawna pisownia");

                }
                Console.WriteLine("Poprawna pisownia");
                Console.WriteLine("If you want to continue press n ");
                Console.WriteLine("If you want to leave press e ");

                decision = Console.ReadLine();
            }
            while (decision != "e");

        }
    }
}
