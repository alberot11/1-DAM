// Diego Aníbal Lezcano Reissner y Alberto Girón Serna

using System;
class Division2Numeros
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Dime un número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write ("Dime otro: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        if (n2 == 0)
            Console.WriteLine("No se puede");
        else
        {
            Console.WriteLine("Su división es {0}", n1 / n2);

            if (n1 % n2 != 0)
                Console.WriteLine("Y el resto es {0}", n1 % n2);
            else
                Console.WriteLine("(Exacta)");
        }
        


    }
}

