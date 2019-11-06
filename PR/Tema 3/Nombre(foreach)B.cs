//Alberto Girón Serna

using System;
class Nombre
{
    static void Main ()
    {
        string nombre;
        Console.Write("Dime tu nombre: ");
        nombre= Console.ReadLine();
        foreach (char c in nombre)
            Console.Write(c + " ");
    }
}
