using System;

class OddEven
{
    static void Main()
    {
        string read = Console.ReadLine();
        int number = int.Parse(read);

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}

