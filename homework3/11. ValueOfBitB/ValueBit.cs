using System;

class ValueBit
{
    static void Main()
    {
        Console.WriteLine("Please type in an integer: ");
        string str = Console.ReadLine();
        Console.WriteLine("Type in the position of the bit you would like to check: ");
        int b = int.Parse(Console.ReadLine());
        int numb = int.Parse(str);
        string bin = Convert.ToString(numb, 2);
        int mask = 1;
        mask = mask << b;
        int bitResault = (numb & mask) >> b;
        Console.WriteLine("the number in binary is: "+bin);
        Console.WriteLine("The third bit is " + bitResault);
       
    }
}

