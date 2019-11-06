//Alberto Girón Serna

using System;
class menu
{
    static void Main ()
    {
        byte sel;
        Console.WriteLine("1. Jugar");
        Console.WriteLine("2. Cargar");
        Console.WriteLine("0. Salir");
        sel =Convert.ToByte(Console.ReadLine()); 
        
        switch (sel)
        {
            case 1: Console.Clear(); Console.Write(sel); break;
            case 2: Console.Clear(); Console.Write(sel); break;
            case 0: Console.Clear(); Console.Write(sel); break;
            default: Console.Clear(); Console.Write("opcion no valida"); break;
        }
    }
}
