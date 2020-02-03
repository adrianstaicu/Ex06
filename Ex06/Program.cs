using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 9;
            int c = 5;

            if (a < b && a < c) {
                Console.WriteLine(" a este cel mai mic");
                    }
            else if (b < a && b < c) {
                Console.WriteLine(" b este cel mai mic");
                    }
            else
            {
                Console.WriteLine(" c este cel mai mic");
            }
        }
    }
}
