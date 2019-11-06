//Tabla de multiplicar
//Alberto Girón Serna

using System;
class TablasDeMultiplicar
{
    static void Main ()
    {
        int num, cont=0;
        Console.Write("¿de qué número quieres la tabla? ");
        num = Convert.ToInt32(Console.ReadLine());
        while (cont <= 10)
        {
            Console.WriteLine("{0} * {1} = {2}", num, cont, num*cont);
            cont = cont + 1;
        }
    }
}
