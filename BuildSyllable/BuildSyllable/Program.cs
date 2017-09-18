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
            string[] spolgloski = new string[18] {"b", "c", "d", "f", "g", "h", "j", "k", "l", "ł", "m", "n", "p", "r", "s", "t", "w", "z"};

            string[,,] sylaba = new string[samogloski.Length,spolgloski.Length,2];

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



                Console.WriteLine("If you want to continue press n ");
                Console.WriteLine("If you want to leave press e ");

                decision = Console.ReadLine();

            } while (decision != "e");

            //for (i=0; i<samogloski.Length; i++)
            //{
            //    for(j=0; j<spolgloski.Length; j++)
            //    {
            //        if (samogloski[i] != spolgloski[j])
            //        {
            //            sylaba[i, j, 0] = samogloski[i] + spolgloski[j];
            //            sylaba[i, j, 1] = spolgloski[j] + samogloski[i];
            //        }

            //        Console.WriteLine(sylaba[i, j, 0] + " " + sylaba[i, j, 1]);

            //    }
            //}
        }
    }
}
