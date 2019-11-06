//Alberto Girón Serna

using System;
class sumaNumerosString
{
    static void Main ()
    {
        long suma=0;
        Console.Write("Introduce numeros separados por espacios: ");
        string numeros = Console.ReadLine();
        string [] num = numeros.Split();
        for(int i=0; i<num.Length; i++)
        {
            suma=suma+Convert.ToInt64(num[i]);
        }
        Console.WriteLine("la suma es: {0}", suma);
    }
}
