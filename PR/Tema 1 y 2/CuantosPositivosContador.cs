//Cuantos son positivos
//Alberto Girón Serna

using System;
class CuantosSonPositivos
{
    static void Main ()
    {
        int num1, num2, cont=0;
        Console.WriteLine("Dime un número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime otro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Números positivos: ");
        if (num1>0)
        {
            cont = cont + 1;
        }
        if (num2>0)
        {
            cont = cont + 1;
        }
        Console.WriteLine(cont);
    }
}
