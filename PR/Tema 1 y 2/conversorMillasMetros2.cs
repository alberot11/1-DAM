using System;
class ConversorMillasMetros
{
    static void Main()
    {
        int millas, metros;
        Console.Write("¿Cuántas millas quieres convertir a metros? ");
        millas=Convert.ToInt32(Console.ReadLine());
        metros=millas*1609;
        Console.Write("{0} millas son {1} metros", millas, metros);
    }
}
