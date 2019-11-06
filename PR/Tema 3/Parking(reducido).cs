//Alberto Girón Serna

using System;
class ParkingReducido
{
    static void Main ()
    {
        int hentrada, hsalida, dif, htotal;
        double total=0.0, precio=2.20;
        Console.Write("¿precio de entrada? ");
        hentrada= Convert.ToInt32(Console.ReadLine());
        Console.Write("¿precio de salida? ");
        hsalida= Convert.ToInt32(Console.ReadLine());
        dif=hsalida-hentrada;
        for(htotal=dif; htotal>100; htotal-=100)
        {
            total=total+precio;
        }
        if(htotal!=0)
        {
            total=total+precio;
        }
        Console.WriteLine("El total es: {0}$", total);
    }
}
