//Alberto Girón Serna

using System;
class CaracterEspecial
{
    static void Main ()
    {
        Console.Write("Introduce un caracter: ");
        char x = Convert.ToChar(Console.ReadLine());
        Console.Write("Introduce otro caracter: ");
        char y = Convert.ToChar(Console.ReadLine());
        Console.Write("Introduce otro caracter: ");
        char z = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("{0}\n\"{1}{2}\"", z, y, x);
    }
}
