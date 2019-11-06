using System;

class numbere
{
    static void Main()
    {
        ulong term;
        Console.Write("nº? ");
        term = Convert.ToUInt64(Console.ReadLine());

        if (term<=0)
        {
            Console.WriteLine(0);
        }
        else if (term==1)
        {
            Console.WriteLine(1);
        }
        else
        {
            double result = 1;
            for (ulong i=0; i<=term; i++)
            {
                double currentTerm = 1;
                for (ulong n = 1; n <= i; n++)
                {
                    currentTerm /= n;
                }
                result += currentTerm;
            }
            Console.WriteLine(result);
        }
    }
}