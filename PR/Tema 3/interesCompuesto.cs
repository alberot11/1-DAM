//Alberto Girón Serna

using System;
class InteresCompuesto
{
    static void Main ()
    {
        double e, i, r;
        int a;
        Console.Write("dinero? ");
        e =Convert.ToDouble(Console.ReadLine());
        Console.Write("interes (%)? ");
        i =Convert.ToDouble(Console.ReadLine());
        Console.Write("años? ");
        a =Convert.ToInt32(Console.ReadLine());
        
        r=e*(1.0+i/100.0);
        for(int j=1; j<a; j++)
        {
            r=r*(1.0+i/100.0);
        }
        Console.WriteLine(r);
        
        
    }
}
