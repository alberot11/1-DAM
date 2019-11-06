//Escritura de un número
//Alberto Girón Serna

using System;
class NumeroEscrito
{
    static void Main ()
    {
        int num;
        Console.Write("introduce un numero (1-4): ");
        num=Convert.ToInt32(Console.ReadLine());
        
        switch (num)
        {
            case 1:
                Console.WriteLine("Uno");
                break;
            case 2:
                Console.WriteLine("Dos");
                break;
            case 3:
                Console.WriteLine("Tres");
                break;
            case 4:
                Console.WriteLine("Cuatro");
                break;
            default:
                Console.WriteLine("He pedido un numero del 1 al 4!");
                break;
        }
    }
}
