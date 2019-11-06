using System;
class ConversorMillasMetros
{
    static void Main()
    {
        int millas, metros;
        Console.Write("¿Cuántas millas quieres convertir a metros? ");
        millas=Convert.ToInt32(Console.ReadLine());
        metros=millas*1609;
        Console.Write(millas);
        Console.Write(" millas son ");
        Console.Write(metros);
        Console.Write(" metros");
    }
}
