//Cuantos son positivos
//Alberto Girón Serna

using System;
class CuantosSonPositivos
{
    static void Main ()
    {
        int num1, num2;
        Console.WriteLine("Dime un número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime otro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Números positivos: ");
        if(num1>0 && num2>0)
        Console.WriteLine(2);
        else if (num1<0 && num2<0)
        Console.WriteLine(0);
        else if (num1<0 || num2<0)
        Console.WriteLine(1);
        else
        Console.WriteLine("El cero no es un numero positivo ni negativo");
    }
}
