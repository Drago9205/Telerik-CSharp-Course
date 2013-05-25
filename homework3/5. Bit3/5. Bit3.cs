using System;

class ThirdBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type in an integer: ");
        string str = Console.ReadLine();
        int numb = int.Parse(str);
        int mask = 1;
        mask = mask << 3;
        if((numb & mask) == 0)
            Console.WriteLine("The 3rd bit is: 0");
        else
            Console.WriteLine("The 3rd bit is: 1");
        
        int bitResault = (numb & mask) >>3;
        Console.WriteLine("The third bit is " +bitResault +" (second check)");
        

    }
}

