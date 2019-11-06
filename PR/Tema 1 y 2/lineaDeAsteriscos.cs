//Linea de asteriscos
//Alberto Girón Serna

using System;
class LineaAsteriscos
{
    static void Main ()
    {
        int num, cont=0;
        Console.Write("¿cuántos asteriscos quiéres? ");
        num = Convert.ToInt32(Console.ReadLine());
        while (cont < num)
        {
            Console.Write("*");
            cont = cont + 1;
        }
        Console.WriteLine();
    }
}
