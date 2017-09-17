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
            string[] spolgloski = new string[24] {"a", "b", "c", "d", "e", "f", "g", "h",
                                                  "i", "j", "k", "l", "ł", "m", "n", "o",
                                                  "p", "r", "s", "t", "u", "w", "y", "z"};

            string[,,] sylaba = new string[samogloski.Length,spolgloski.Length,2];

            int i, j;

            for (i=0; i<samogloski.Length; i++)
            {
                for(j=0; j<spolgloski.Length; j++)
                {
                    if (samogloski[i] != spolgloski[j])
                    {
                        sylaba[i, j, 0] = samogloski[i] + spolgloski[j];
                        sylaba[i, j, 1] = spolgloski[j] + samogloski[i];
                    }

                    Console.WriteLine(sylaba[i, j, 0] + " " + sylaba[i, j, 1]);

                }
            }
        }
    }
}
