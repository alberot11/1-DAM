//Dia De La Semana
//Alberto Girón Serna

using System;
class DiaDeLaSemana
{
    static void Main ()
    {
        int dia;
        Console.Write("Dime el dia de la semana: ");
        dia=Convert.ToInt32(Console.ReadLine());
        
        switch (dia)
        {
            case 1:
                Console.WriteLine("Es Lunes");
                break;
            case 2:
                Console.WriteLine("Es Martes");
                break;
            case 3:
                Console.WriteLine("Es Miércoles");
                break;
            case 4:
                Console.WriteLine("Es Jueves");
                break;
            case 5:
                Console.WriteLine("Es viernes");
                break;
            case 6:
                Console.WriteLine("Es Sábado");
                break;
            case 7:
                Console.WriteLine("Es Viernes");
                break;
            default:
                Console.WriteLine("Solo hay 7 días en una semana");
                break;
        }
    }
}
