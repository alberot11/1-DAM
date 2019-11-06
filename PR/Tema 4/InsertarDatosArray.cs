//Alberto Girón Serna

using System;
class InsertarDatosArray
{
    static void Main ()
    {
        long [] datos;
        Console.Write("cuantos datos quieres? ");
        long n =Convert.ToInt64(Console.ReadLine());
        datos = new long [n];
        for(long i=0; i<datos.Length; i++)
        {
            Console.Write("Dime dato: ");
            datos [i] =Convert.ToInt64(Console.ReadLine());
        }
        for (long i=datos.Length-1; i>=0; i--)
            Console.WriteLine(datos[i]);
    }
}
