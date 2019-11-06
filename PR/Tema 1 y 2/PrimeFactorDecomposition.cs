//
//Alberto Girón Serna

using System;
class PrimeFactorDecomposition
{
    static void Main ()
    {
        Console.Write("Enter a number: ");    
        int num= Convert.ToInt32(Console.ReadLine());
        int ini=num;
        for (int i = 2; i <= num; i++)
        {
            while(num%i==0)
            {
                num=num/i;
                Console.Write("{0} ", i);
            }
        }
    }
}
