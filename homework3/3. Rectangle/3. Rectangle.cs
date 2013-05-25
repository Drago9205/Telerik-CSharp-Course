using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Type in the width of the rectangle: ");
        string read = Console.ReadLine();
        int width = int.Parse(read);
        Console.WriteLine("type in the height of the rectangle: ");
        string read2 = Console.ReadLine();
        int height = int.Parse(read2);
        Console.WriteLine("The area of the rectangle is: {0}", width*height);

    }
}

