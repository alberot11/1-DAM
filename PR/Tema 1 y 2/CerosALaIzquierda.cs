//Completar con ceros a la izquierda
//Alberto Girón Serna

using System;
class CompletarConCeros
{
    static void Main ()
    {
        int num;
        Console.Write("Dime un número positivo: ");
        num=Convert.ToInt32(Console.ReadLine());
        
        if (num >= 100)
            Console.WriteLine(num);
        else if (num >= 10)
            Console.WriteLine("0{0}", num);
        else if (num >= 0)
            Console.WriteLine("00{0}", num);
        else
            Console.WriteLine("he dicho un número positivo");
    }
}
