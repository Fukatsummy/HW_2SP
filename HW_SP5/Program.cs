using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SP5
{
     class Program
    {
        static void Main(string[] args)
        {
            int currentfib = 0;
            int nexfib = 1;

            Console.WriteLine(currentfib);
            Console.WriteLine(nexfib);

            for (int i = 0; i < 18; i++)
            {
                int NextNextfib = currentfib + nexfib;
                Console.WriteLine(NextNextfib);
                currentfib = nexfib;
                nexfib = NextNextfib;
            }
        }
    }

}