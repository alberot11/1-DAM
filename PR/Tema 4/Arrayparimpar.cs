//Alberto Girón Serna

using System;
class Arrayparimpar
{
    static void Main ()
    {
        const int MAX = 10;
        short [] datos;
        datos = new short [MAX];
        for(int i=0; i<datos.Length; i++)
        {
           Console.Write("Introduce el dato {0}: ", i+1);
           datos[i] = Convert.ToInt16(Console.ReadLine());
        }
        Console.Write("Datos de posiciones impares: ");
        for (int i=0; i<datos.Length; i++)
        {
            if (i%2==0 || i==0)
                Console.Write(datos[i] + " ");
        }
        Console.WriteLine();
        bool par= false;
        Console.Write("Datos pares: ");
        foreach (short dato in datos)
        {
            if (dato%2==0)
            {
                par=true;
                Console.Write(dato + " ");
            }
        }
        if(par==false)
            Console.WriteLine("No hay datos pares");
        else 
            Console.WriteLine();
    }
}
