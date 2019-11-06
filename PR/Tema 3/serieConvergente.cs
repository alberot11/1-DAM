//Alberto Girón Serna

using System;
class SerieConvergente
{
    static void Main ()
    {
        string s;
        double suma;
        int divisor;
        do
        {
            suma=0;
            divisor=1;
            Console.Write("¿Cuantos sumandos desea? ");
            s=Console.ReadLine();
            if (s!="fin")
            {
                long num=Convert.ToInt64(s);
                if(num>0)
                {
                    for (double i= 1; i<=num; i++)
                    {
                        suma=suma + 1.0/divisor;
                        divisor*=2;
                    }
                    Console.WriteLine("la suma vale {0}.", suma);
                }
                else 
                {
                    Console.WriteLine("No se puede meter menos de 1 sumando");
                }
            }
        } while (s!="fin");
    }
}
