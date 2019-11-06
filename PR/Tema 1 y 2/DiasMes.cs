//Alberto Girón Serna 

using System;
class DiasMes
{
    static void Main()
    {
        Console.Write("Dime el mes (1-12): ");
        int mes= Convert.ToInt32(Console.ReadLine());
        
        if (mes==2)
            Console.WriteLine(28);
        else if (mes==4 || mes==6 || mes==9 || mes==11)
            Console.WriteLine(30);
        else 
            Console.WriteLine(31);
   // ------------------------------------------------------
        switch(mes)
        {
            case 2:
                Console.WriteLine("28");
            break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("30");
            break;
            default:
                Console.WriteLine("31");
            break;    
        }
                
    }
}
