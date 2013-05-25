using System;

class WithinCircleRect
{
    static void Main()
    {
        Console.WriteLine("Type in coordinate x: ");
        string strX = Console.ReadLine();
        Console.WriteLine("Type in coordinate y: ");
        string strY = Console.ReadLine();
        double x = double.Parse(strX);
        double y = double.Parse(strY);
        bool inCirc = ((Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2)) <= (3 * 3));
        bool outOfRect = ((1 > x || x > 7) && (-1 < y || y < -3));
        if (inCirc && outOfRect)
            Console.WriteLine("The point satisfies the requirements.\n (It's in the circe and out of the rectangle)");
        else 
            Console.WriteLine("The point doesn't satisfy the requirements.");

    }
}

