//Positivo, cero o negativo
//Alberto Girón Serna


using System;
class PositivoCeroNegativo
{
    static void Main ()
    {
        int numero;
        Console.Write("Introduce un número: ");
        numero=Convert.ToInt32(Console.ReadLine());
        
        if (numero>0||numero==0)
        Console.WriteLine("{0} es positivo o cero", numero);
        else
        Console.WriteLine("{0} es negativo", numero);
    }
}
