using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFiveFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = 17;
            double fahrenheit;
            fahrenheit = (celsius * 1.8 ) + 32;
            Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
            Console.ReadKey();
        }
    }
}
