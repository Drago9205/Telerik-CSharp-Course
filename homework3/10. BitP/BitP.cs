using System;

class BitP
{
    static void Main()
    {
        Console.WriteLine("Please type in an integer: ");
        string str = Console.ReadLine();
        Console.WriteLine("Type in the position of the bit you would like to check: ");
        int p = int.Parse(Console.ReadLine());
        int numb = int.Parse(str);
        string bin = Convert.ToString(numb, 2);
        int mask = 1;
        mask = mask << p;
        bool pbit = ((numb & mask) == 0);
        Console.WriteLine("The bit at position {0} is 1: {1}", p, !pbit);
        Console.WriteLine("the number in binary is: " + bin);
        /*
        if ((numb & mask) == 0)
            Console.WriteLine("The p bit is: 0");
        else
            Console.WriteLine("The p bit is: 1");
        //Second solution of the problem
        int bitResault = (numb & mask) >> p;
        Console.WriteLine("the number in binary is: "+bin);
        Console.WriteLine("The third bit is " + bitResault + " (second check)");
         */
    }
}

