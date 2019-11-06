//Decimales
//Alberto Girón Serna

using System;
class AproximacionDePI
{
    static void Main ()
    {
        int pi = 22/7;
        int dec = 1000*22/7%1000;
        Console.WriteLine("{0}.{1}", pi, dec);
    }
}
