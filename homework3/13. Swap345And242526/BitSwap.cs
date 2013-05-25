using System;
//A solution using strings instead of bitwise operators
class BitSwap
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        uint n = uint.Parse(Console.ReadLine());
        string bin = Convert.ToString(n, 2).PadLeft(32, '0');
        string temp345 = bin.Substring(26, 3);
        string temp242526 = bin.Substring(5, 3);
        Console.WriteLine("The original number in binary is:        " + bin);
        bin = bin.Remove(26, 3).Insert(26, temp242526);
        bin = bin.Remove(5, 3).Insert(5, temp345);
        Console.WriteLine("The binary representation of the new is: "+bin);
        Console.WriteLine("The new number is: "+Convert.ToUInt32(bin,2).ToString());
    }
}

