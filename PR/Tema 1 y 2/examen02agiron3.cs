//Alberto Girón Serna

using System;
class examen02agiron3
{
    static void Main ()
    {
        Console.Write("dame un número: ");
        int n1= Convert.ToInt32(Console.ReadLine());
        Console.Write("dame otro número: ");
        int n2= Convert.ToInt32(Console.ReadLine());
        int n1esMultiploDe5, sonMultiplosDe5;
        
        if(n1%5==0)
            n1esMultiploDe5=1;
        else
            n1esMultiploDe5=0;
            
        n1esMultiploDe5= n1%5==0 ? 1 : 0;
        
        if(n1%5==0 && n2%5==0)
            sonMultiplosDe5=2;
        else if(n1%5!=0 && n2%5!=0)
            sonMultiplosDe5=0;
        else
            sonMultiplosDe5=1;
        
        sonMultiplosDe5= n1%5==0 && n2%5==0 ?
            2 :
            n1%5!=0 && n2%5!=0 ?
            0 :
            1;
    }
}
