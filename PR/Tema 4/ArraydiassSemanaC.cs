//Alberto Girón Serna

using System;
class ArraydiassSemanaC
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
        
        foreach (string dia in dias)
        {
            Console.WriteLine(dia)
        }
    }
}
