
//Alberto Girón Serna

using System;
class CambioBase
{
    static void Main ()
    {
        int num;
        do
        {
            Console.Write("Dime un numero: ");
            num =Convert.ToInt32(Console.ReadLine());
            if (num!=0)
            {
                Console.WriteLine(Convert.ToString(num,16));
                Console.WriteLine(Convert.ToString(num,2));
            }
        } while (num!=0);
        Console.WriteLine("Adios!");
        
    }
}
