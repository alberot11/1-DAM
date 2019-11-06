//Alberto Girón Serna
using System;
class examen02agiron2
{
    static void Main ()
    {
        Console.Write("dame un número: ");
        int a= Convert.ToInt32(Console.ReadLine());
        
        if (a<=1)
            Console.WriteLine("I");
        else if(a<=2)
            Console.WriteLine("II");
        else if (a<=3)
            Console.WriteLine("III");
        else if (a<=4)
            Console.WriteLine("IV");
        else if (a<=5)
            Console.WriteLine("V");
        else if (a<=6)
            Console.WriteLine("VI");
        else if (a<=7)
            Console.WriteLine("VII");
        else if (a<=8)
            Console.WriteLine("VIII");
        else if (a<=9)
            Console.WriteLine("IX");
        else if (a<=10)
            Console.WriteLine("X");
        else 
            Console.WriteLine("No es un número válido");
            
        switch (a)
        {
            case 1: Console.WriteLine("I"); break;
            case 2: Console.WriteLine("II"); break;
            case 3: Console.WriteLine("III"); break;
            case 4: Console.WriteLine("IV"); break;
            case 5: Console.WriteLine("V"); break;
            case 6: Console.WriteLine("VI"); break;
            case 7: Console.WriteLine("VII"); break;
            case 8: Console.WriteLine("VIII"); break;
            case 9: Console.WriteLine("IX"); break;
            case 10: Console.WriteLine("X"); break;
            default: Console.WriteLine("No es un número válido"); break;
        }
    }
}
