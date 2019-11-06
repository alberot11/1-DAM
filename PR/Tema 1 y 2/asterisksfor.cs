using System;

class Asterisks
{
    static void Main()
    {
        Console.Write("How many asterisks? ");
        int n = Convert.ToInt32( Console.ReadLine() );
        
        for (int i=1; i <= n; i++)
            Console.Write("* ");
        Console.WriteLine();
    }
}
