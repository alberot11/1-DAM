//Alberto Girón Serna

using System;
class ElegirDiaSemanaArrayB
{
    static void Main ()
    {
        string[] dias= {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes",
            "Sabado", "Domingo"};
        
        Console.Write("Dime un numero (1-7): ");
        int d =Convert.ToInt32(Console.ReadLine());
        if(d>0 && d<=7)
        Console.WriteLine("El día de la semana es: "+ dias[d-1]);
        else
        Console.WriteLine("La semana solo tiene 7 días");
    }
}
