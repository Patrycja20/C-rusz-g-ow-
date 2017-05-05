using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pętle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string poem = "";
            while (x < 4)
            {
                poem += "a";
                if (x < 1)
                {
                    poem += "noise";
                }
                poem += " ";
                if (x > 1)
                {
                    poem += "oyster";
                    x += 2;
                }
                if (x == 1)
                {
                    poem += "noys";
                }
                if (x < 1)
                {
                    poem += "n";
                }
                x = 1;
            }
            Console.WriteLine(poem);
            //a noise annoys an oyster 
            Console.ReadKey();
        }
    }
}
