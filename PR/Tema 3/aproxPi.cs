//Alberto Girón Serna

using System;
class aproxPi
{
    static void Main ()
    {
        long term; 
        double total=0, parte=1;
        Console.Write("nº de terminos? ");
        term =Convert.ToInt64(Console.ReadLine());
        for(double i=1; i<=term; i++)
        {
            if(i%2!=0)
                total=total+(1.0/parte);
            else
                total=total-(1.0/parte);
            Console.WriteLine("termino {0}= {1}", i, total*4.00);
            parte+=2;
        }
    }
}
