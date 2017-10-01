using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSyllable
{
    class ReadingLessons
    {
        public static string RandomLetter(string[] alfabet, int index)
        {
            if ((index >= 0) && (index < alfabet.Length))
            {
                return alfabet[index];
            } else
            {
                return "index out of scope";
            }
        }

        /**
        public void Twoletters(string[] firstSet, string[] secondSet)
        {
            Random rand = new Random();

            int indexSamogloski = rand.Next(firstSet.Length);
            int indexSpolgloski = rand.Next(secondSet.Length);
            string letter1 = firstSet[indexSpolgloski];
            string letter2 = secondSet[indexSamogloski];

            Console.WriteLine(letter1 + letter2);
            Console.WriteLine();
            Console.WriteLine(letter2 + letter1);
            Console.WriteLine();
        }
        */
    }
}
