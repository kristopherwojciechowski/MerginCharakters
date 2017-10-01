using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSyllable
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

                Console.WriteLine(ReadingLessons.RandomLetter(samogloski, indexSamogloski) +
                                  ReadingLessons.RandomLetter(samogloski, indexSamogloski));


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

                int indexSamogloski2 = rand.Next(samogloski.Length);
                int indexSpolgloski2 = rand.Next(spolgloski.Length);

                if (indexSamogloski2 == indexSamogloski || indexSpolgloski2 == indexSpolgloski)
                {
                    do
                    {
                        indexSamogloski2 = rand.Next(samogloski.Length);
                        indexSpolgloski2 = rand.Next(spolgloski.Length);

                    } while (indexSamogloski2 == indexSamogloski || indexSpolgloski2 == indexSpolgloski);
                }

                string letter3 = spolgloski[indexSpolgloski2];
                string letter4 = samogloski[indexSamogloski2];

                Console.WriteLine(letter1 + letter2 + letter3 + letter4);
                Console.WriteLine();
                Console.WriteLine(letter3 + letter4 + letter1 + letter2);
                Console.WriteLine();

                Console.WriteLine("If you want to continue press n ");
                Console.WriteLine("If you want to leave press e ");

                decision = Console.ReadLine();

            } while (decision != "e");

        }
    }
}
