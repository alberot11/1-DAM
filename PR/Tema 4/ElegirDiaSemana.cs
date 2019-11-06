//Alberto Girón Serna

using System;
class ElegirDiaSemanaArray
{
    static void Main ()
    {
        string[] dias= new string [7];
        dias[0]= "Lunes";
        dias[1]= "Martes";
        dias[2]= "Miercoles";
        dias[3]= "Jueves";
        dias[4]= "Viernes";
        dias[5]= "Sabado";
        dias[6]= "Domingo";
        
        Console.Write("Dime un numero (1-7): ");
        int d =Convert.ToInt32(Console.ReadLine());
        if(d>0 && d<=7)
        Console.WriteLine("El día de la semana es: "+ dias[d-1]);
        else
        Console.WriteLine("La semana solo tiene 7 días");
    }
}
