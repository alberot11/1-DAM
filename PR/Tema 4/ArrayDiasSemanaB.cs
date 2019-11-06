//Alberto Girón Serna

using System;
class ArrayDiasSemanaB
{
    static void Main ()
    {
        string[] dia= new string [7];
        dia[0]= "Lunes";
        dia[1]= "Martes";
        dia[2]= "Miercoles";
        dia[3]= "Jueves";
        dia[4]= "Viernes";
        dia[5]= "Sabado";
        dia[6]= "Domingo";
        
        for(int i=0; i<7; i++)
        {
            Console.WriteLine(dia[i]);
        }
    }
}
