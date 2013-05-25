using System;

class ThirdrdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type in the number: ");
        string read = Console.ReadLine();
        int number = int.Parse(read);
        if((number/100)%10==7)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
        

    }
}

