//Alberto Girón Serna

using System;
class gastos01
{
    static void Main ()
    {
        byte sel;
        do
        {
            Console.WriteLine("1. Añadir un gasto");
            Console.WriteLine("2. Ver informes");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("0. Salir");
            sel =Convert.ToByte(Console.ReadLine());
            switch (sel)
            {
                case 1:
                    Console.WriteLine("Opcion todavia no disponible");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Opcion todavia no disponible");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Opcion todavia no disponible");
                    Console.WriteLine();
                    break;
            }
            
        } while (sel!=0);
    }
}
