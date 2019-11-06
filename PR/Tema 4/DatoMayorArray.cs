//Alberto Girón Serna

using System;
class DatoMayorArray
{
    static void Main ()
    {
        const int N=10;
        long [] datos, mayor;
        datos = new long [N];
        for(long i=0; i<datos.Length; i++)
        {
            Console.Write("Dime dato: ");
            datos [i] =Convert.ToInt64(Console.ReadLine());
            mayor=datos[0];
            if(datos[i]>mayor && i!=0)
                mayor= datos[i];
        }
        
    }
}
