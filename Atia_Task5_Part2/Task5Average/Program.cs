using System;

namespace Task5Average

{

    public class Numb
    {
        static void Main()
        {
            Console.WriteLine("Enter Values:");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((A + B) / 2);
        }
    }
}