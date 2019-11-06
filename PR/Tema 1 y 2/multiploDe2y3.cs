//Multiplo de 2 o 3
//Alberto Girón Serna

using System;
class Multiplo2y3
{
    static void Main ()
    {
        int num;
        Console.Write("Dime un numero del 1 al 10: ");
        num=Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0 && num % 3 == 0)
            Console.WriteLine("{0} es multiplo de 2 y de 3", num);
        else if (num % 2 == 0)
            Console.WriteLine("{0} es multiplo de 2", num);
        else if (num % 3 == 0)
            Console.WriteLine("{0} es multiplo de 3", num);
        else 
            Console.WriteLine("{0} no es multiplo de 2 ni de 3", num);
    }
}
