//Alberto Girón Serna

using System;
class NombreCorrecto
{
    static void Main ()
    {
        Console.Write("Introduce tu nombre: ");
        string nombre= Console.ReadLine();
        if (nombre!="Alberto")
        {
            Console.WriteLine("Nombre incorrecto");
        }
        else 
        Console.WriteLine("Bienvenido!!");
    }
}
