//
//Alberto Girón Serna

using System;
class ValorAbsoluto
{
    static void Main ()
    {
        int num, abs;
        Console.Write("introduce un número: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        abs = num >= 0 ? num : -num;
        Console.Write("|{0}| = {1}", num, abs);
    }
}
