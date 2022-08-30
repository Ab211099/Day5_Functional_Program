using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_programs
{
    internal class Even_Odd
    {

        public static void evenOdd()
        {
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even number");
            }
            else
            {
                Console.WriteLine(num + " is odd number");
            }
        }
    }
}
