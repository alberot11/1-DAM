//Alberto Girón Serna 

using System;
class CantidadMultiplos
{
    static void Main()
    {
        int a, b, CantidadDeMultiplosDe3;
        Console.Write("dime un numero: ");
        a= Convert.ToInt32(Console.ReadLine());
        Console.Write("dime otro numero: ");
        b= Convert.ToInt32(Console.ReadLine());
            
        if(a%3==0 && b%3==0)
            CantidadDeMultiplosDe3=2;
        else if(a%3==0 || b%3==0)
            CantidadDeMultiplosDe3=1;
        else 
            CantidadDeMultiplosDe3=0;
        Console.WriteLine("{0} multiplos de 3", CantidadDeMultiplosDe3);
        
        CantidadDeMultiplosDe3= (a%3==0 && b%3==0) ?
        2: 
        (a%3==0 || b%3==0) ?
        1: 
        0;
                
        Console.WriteLine("{0} multiplos de 3", CantidadDeMultiplosDe3);
    }
}
