using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_DIY
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "XOXOXOXO";
            string two = "OXOXOXOX";
            int n = 0;

            do
            {
                Console.WriteLine(one);
                Console.WriteLine(two);
                n++;
            } while (n < 4);
        }
    }
}
