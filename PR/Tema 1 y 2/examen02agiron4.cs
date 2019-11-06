//Alberto Girón Serna

using System;
class examen02agiron4
{
    static void Main ()
    {
        Console.Write("Tamaño de casilla? ");
        int a= Convert.ToInt32(Console.ReadLine());

            for(int colt=0; colt<8; colt++)
            {
                for(int fila1=0; fila1<a; fila1++)
                {
                    for(int col1=0; col1<a; col1++)
                        Console.Write("#");
                }
                for(int fila2=0; fila2<a; fila2++)
                {
                    for(int col2=0; col2<a; col2++)
                        Console.Write(" ");
                }
            Console.WriteLine();
            }
        
        
    }
}
