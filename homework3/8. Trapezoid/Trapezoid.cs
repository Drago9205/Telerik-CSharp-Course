using System;

class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("type in a: ");
        string inputa = Console.ReadLine();
        Console.WriteLine("type in b: ");
        string inputb = Console.ReadLine();
        Console.WriteLine("type in h: ");
        string inputh = Console.ReadLine();
        double a = double.Parse(inputa);
        double b = double.Parse(inputb);
        double h = double.Parse(inputh);
        Console.WriteLine("The area of the trapezoid is: " + ((a+b)*h/2));
    }
}

