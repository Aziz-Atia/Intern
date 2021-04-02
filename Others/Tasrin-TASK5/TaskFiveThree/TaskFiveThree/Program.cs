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

            
                Console.WriteLine("Input: ");
                double A = Convert.ToDouble(Console.ReadLine());
                double B = Convert.ToDouble(Console.ReadLine());
                double add =Convert.ToDouble(A + B);
                double subtract = Convert.ToDouble(A - B);
                double multiply = Convert.ToDouble(A * B);
                double divide = Convert.ToDouble( A / B);
                Console.WriteLine("add ans: " + add);
                Console.WriteLine("subtract ans: " + subtract);
                Console.WriteLine("multiply ans: " + multiply);
                Console.WriteLine("divide ans: " + divide);




            Console.ReadKey();
        }
    }
}
