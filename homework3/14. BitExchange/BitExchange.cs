using System;
//Опитах се да направя решение със стрингове, но изглежда в някои определени случаи дава грешка.
class BitExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit p");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit q");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter iterration k");
        int k = int.Parse(Console.ReadLine());
        string bin = Convert.ToString(n, 2).PadLeft(32, '0');
        char[] binCharArray = bin.ToCharArray();
        Array.Reverse(binCharArray);
        string binRev = new string(binCharArray);
        string tempP = bin.Substring(p, p+k-1);
        string tempQ = bin.Substring(q, q+k-1);
        bin = bin.Remove(q, q+k-1).Insert(q, tempP);
        bin = bin.Remove(p, p+k-1).Insert(p, tempQ);
        char[] binCharArray2 = bin.ToCharArray();
        Array.Reverse(binCharArray2);
        string bin2 = new string(binCharArray2);
        Console.WriteLine("The new number is: "+bin2+" Its binary representation is: "+Convert.ToUInt32(bin2, 2));
        
        /*
        string tempP = bin.Substring(26, 3);
        string tempQ = bin.Substring(5, 3);
        Console.WriteLine("The original number in binary is:        " + bin);
        bin = bin.Remove(26, 3).Insert(26, temp242526);
        bin = bin.Remove(5, 3).Insert(5, temp345);
        Console.WriteLine("The binary representation of the new is: " + bin);
        Console.WriteLine("The new number is: " + Convert.ToUInt32(bin, 2).ToString());
         */
    }
}

