using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            for (i = 0; i <= 2; i++)
            {
                Console.Write("Input: ");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = Convert.ToDouble(Console.ReadLine());
                double c = (A + B) / 2;
                Console.WriteLine("STUDENT'S AVERAGE " + c);

            }



            Console.ReadKey();
        }
    }
}
