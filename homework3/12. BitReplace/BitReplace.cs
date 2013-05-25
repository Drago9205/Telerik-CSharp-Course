using System;

class BitReplace
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit number");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit value (1 or 0)");
        int v = int.Parse(Console.ReadLine());
        string number = Convert.ToString(n, 2).PadLeft(32, '0');
        int mask = 1 << p;
        Console.WriteLine("The original int number in binary is:\n{0}", number);
        if (v == 0)
        {
            n = n & (~mask);
            Console.WriteLine("The new int number is: {0}", n);
            Console.WriteLine((Convert.ToString(n, 2).PadLeft(32, '0')));
        }
        else 
        {
            n = n | mask;
            Console.WriteLine("The new int number is: {0}, in binary it is:", n);
            Console.WriteLine((Convert.ToString(n, 2).PadLeft(32, '0')));
        }
    }
}

