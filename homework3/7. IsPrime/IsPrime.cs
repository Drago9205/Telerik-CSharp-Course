using System;

class IsPrime
{
    static void Main()
    {
        Console.WriteLine("Type in a number between 0 and 100: ");
        string input = Console.ReadLine();
        int num = int.Parse(input);
        if (num >100 || num < 0)
            Console.WriteLine("The number is not between 0 and 100");
        else
        {
        if (num == 2 || num == 3 || num == 5 || num == 7)
            Console.WriteLine("The number is prime");
        else
        {
            if( num%2==0 || num%3==0 || num%5==0 || num%7==0 )
                Console.WriteLine("The number is not prime");
            else
                Console.WriteLine("The number is prime");
            }
            }
    }
}

