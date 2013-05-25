using System;

class withinCircle
{
    static void Main()
    {
        string strX = Console.ReadLine();
        string strY = Console.ReadLine();
        double x = double.Parse(strX);
        double y = double.Parse(strY);

        if ((x * x + y * y) <= 5*5)
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K(0,5)", x, y);
        }
        else
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is out of the circle K(0,5)", x, y);
        }
    }
}

