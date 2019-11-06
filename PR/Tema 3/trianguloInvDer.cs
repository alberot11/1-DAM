//Alberto Girón Serna

using System;
class trianguloInvDer
{
    static void Main ()
    {
        char caracter;
        long alto;
        Console.Write("Caracter? ");
        caracter = Convert.ToChar(Console.ReadLine());
        Console.Write("Tamaño? ");
        alto =Convert.ToInt64(Console.ReadLine());
        long espacios=0;
        long simbolo=alto;
        
        for(int fila=0; fila<alto; fila++)
        {
            for(int i=0; i<=espacios; i++)
                Console.Write(" ");
            for(int j=0; j<simbolo; j++)
                Console.Write("{0}", caracter);
            Console.WriteLine();
            espacios++;
            simbolo--;
        }
    }
}
//Solo un triangulo normal
