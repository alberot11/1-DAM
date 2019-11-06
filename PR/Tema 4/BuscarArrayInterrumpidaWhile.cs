//Alberto Girón Serna

using System;
class BuscarArrayInterrumpidaWhile
{
    static void Main ()
    {
        int i=0;
        bool coincide=false;
        const int MAX = 10;
        long datoExtra;
        long [] datos;
        datos = new long [MAX];
        for(int j=0; i<datos.Length; i++)
        {
           Console.Write("Introduce dato {0}: ", j+1);
           datos[j] = Convert.ToInt64(Console.ReadLine());
        }
        Console.Write("Introduce dato a buscar: ");
        datoExtra =Convert.ToInt64(Console.ReadLine());
        while (i<datos.Length && coincide==false)
        {
            if (datoExtra==datos[i])
            {
                coincide=true;
            }
            i++;
        }
        if (coincide==true)
        Console.WriteLine("coincide");
        else
        Console.WriteLine("No coincide");
    }
}
