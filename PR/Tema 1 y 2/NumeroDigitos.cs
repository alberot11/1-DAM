//~ Alberto Girón serna
using System;

class NumeroDigitos
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int num= Convert.ToInt32(Console.ReadLine());
        int digitos= 1;
        
        for(int divisor=10; num/divisor>=1; divisor= divisor*10)
        digitos++;
        
        Console.WriteLine("{0} tiene {1} digito(s)", num, digitos);
        
    }
}
