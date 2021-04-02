using System;
namespace Numb2;
public class Class1
{
    public Class1()
    {
        ConsoleWriteLine("Enter Values:");
        double A = ConsoleReadLine();
        double B = ConsoleReadLine();
        Double avg = (A + B) / 2;
        ConsoleWriteLine("Student's Avg is :" + avg);
    }
}
