//Primo
//Alberto Girón Serna

using System;
class primo

{
    static void Main ()
    {
        Console.Write("Dime un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int cont = 1;
        int cont2 = 0;
        while (cont <= num)
        {
            if (num%cont==0)
            {
                cont2 = cont2 + 1;
            }
                cont = cont + 1;
        }
        if (cont2==2)
            Console.WriteLine("{0} es primo", num);
        else
            Console.WriteLine("{0} no es primo", num);
    }
}
