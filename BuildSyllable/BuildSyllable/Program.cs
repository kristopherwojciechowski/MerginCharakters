using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerginCharakters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] samogloski = new string[6] { "a", "e", "i", "o", "u", "y" };
            //string[] spolgloski = new string[24] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "o", "p", "r", "s", "t", "u", "w", "y", "z"};
            string[] spolgloski = new string[18] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "ł", "m", "n", "p", "r", "s", "t", "w", "z" };

            string decision;
            Random rand = new Random();

            do
            {
                Console.WriteLine();

                int indexSamogloski = rand.Next(samogloski.Length);
                int indexSpolgloski = rand.Next(spolgloski.Length);
                string letter1 = spolgloski[indexSpolgloski];
                string letter2 = samogloski[indexSamogloski];

                Console.WriteLine(letter1 + letter2);
                Console.WriteLine();
                Console.WriteLine(letter2 + letter1);
                Console.WriteLine();

                if (letter2 == "i" || letter2 == "y")
                {
                    do
                    {
                        indexSamogloski = rand.Next(samogloski.Length);
                        letter2 = samogloski[indexSamogloski];

                    } while (letter2 == "i" || letter2 == "y");
                }

                Console.WriteLine(letter1 + "i" + letter2);
                Console.WriteLine();


                Console.WriteLine("If you want to continue press n ");
                Console.WriteLine("If you want to leave press e ");

                decision = Console.ReadLine();

            } while (decision != "e");

            //BuildSyllable sylab = new BuildSyllable();
            //Sylaba sylab1 = new Sylaba();

            //do
            //{


            //    Console.WriteLine("If you want to continue press n ");
            //    Console.WriteLine("If you want to leave press e ");

            //    decision = Console.ReadLine();

            //} while (decision != "e");

        }
    }
}
