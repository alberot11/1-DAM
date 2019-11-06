//Alberto Girón Serna

using System;
class BuscarArrayInterrumpidaBreak
{
    static void Main ()
    {
        bool coincide=false;
        const int MAX = 10;
        long datoExtra;
        long [] datos;
        datos = new long [MAX];
        for(int i=0; i<datos.Length; i++)
        {
           Console.Write("Introduce dato {0}: ", i+1);
           datos[i] = Convert.ToInt64(Console.ReadLine());
        }
        Console.Write("Introduce dato a buscar: ");
        datoExtra =Convert.ToInt64(Console.ReadLine());
        foreach(long dato in datos)
        {
            if (datoExtra==dato)
            {
                coincide=true;
            }
        }
        if (coincide==true)
        Console.WriteLine("coincide");
        else
        Console.WriteLine("No coincide");
    }
}
