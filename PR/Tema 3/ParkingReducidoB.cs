//Alberto Girón Serna

using System;
class ParkingReducidoB
{
    static void Main ()
    {
        int hentrada, hsalida, dif, htotal;
        double total=0.0, precio=2.20;
        Console.Write("¿hora de entrada? ");
        hentrada= Convert.ToInt32(Console.ReadLine());
        Console.Write("¿hora de salida? ");
        hsalida= Convert.ToInt32(Console.ReadLine());
        dif=hsalida-hentrada;
        htotal= dif/100;
        if(dif%100!=0)
            htotal++;
        total=htotal*precio;
        Console.WriteLine("El total sin minutos es: {0}", total);
        
        htotal=dif/100;
        total= htotal*precio + (60-dif*1.0%100.0)* (precio/60.0);
        Console.WriteLine("El total con minutos es: {0}", total);
    }
}
