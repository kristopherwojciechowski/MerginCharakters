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
            string[] spolgloski = new string[18] {"b", "c", "d", "f", "g", "h",
                                                  "j", "k", "l", "l", "m", "n",
                                                  "p", "r", "s", "t", "w", "y"};

            string sylaba;

            sylaba = samogloski[0] + spolgloski[0];

            Console.WriteLine("sylaba: " + sylaba);

        }
    }
}
