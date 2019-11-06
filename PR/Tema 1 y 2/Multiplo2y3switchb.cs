//Multiplo de 2 o 3 (2)
//Alberto Girón Serna

using System;
class Multiplo2y3
{
    static void Main ()
    {
        int num;
        Console.Write("Dime un numero del 1 al 10: ");
        num=Convert.ToInt32(Console.ReadLine());
        
        switch (num)
        {
        case 1:
            Console.WriteLine("{0} no es multiplo de 2 y de 3", num);
        break;
        case 2:
            Console.WriteLine("{0} es multiplo de 2", num);
        break;
        case 3:
            Console.WriteLine("{0} es multiplo de 3", num);
        break;
        case 4:
            goto case 2;
        case 5:
            goto case 1;
        case 6:
            Console.WriteLine("{0} es multiplo de 2 y de 3", num);
        break;
        case 7:
            goto case 1;
        case 8:
            goto case 2;
        case 9:
            goto case 3;
        case 10:
            goto case 2;
        default:
            Console.WriteLine("{0} no es un numero valido", num);
        break;
        }
    }
}
