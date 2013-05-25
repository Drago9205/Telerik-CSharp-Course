using System;

class DividedBy7and5
{
    static void Main(string[] args)
    {
        string read = Console.ReadLine();
        int number = int.Parse(read);
        if(number%7==0 && number%5==0)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}

