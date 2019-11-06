//Divisores
//Alberto Girón Serna

using System;
class Divisores

{
    static void Main ()
    {
        Console.Write("Dime un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int cont = 1;
        
        while (cont <= num)
        {
            if (num%cont==0)
            {
                Console.WriteLine(cont);
            }
                cont = cont + 1;
        }
        Console.WriteLine();
    }
}
