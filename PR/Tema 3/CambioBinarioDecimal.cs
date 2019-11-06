//Alberto Girón Serna

using System;
class CambioBinarioDecimal
{
    static void Main ()
    {
        Console.Write("Introduce un número: ");
        int num =Convert.ToInt32(Console.ReadLine(),2); 
        Console.WriteLine(num);
    }
}
