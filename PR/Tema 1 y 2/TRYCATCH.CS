//~ Alberto Girón serna
using System;

class TryCatch
{
    static void Main()
    {
        try
        {
            Console.Write("Dime un numero: ");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Dime otro numero: ");
            int num2= Convert.ToInt32(Console.ReadLine());
                int result= num1 + num2;
                Console.WriteLine("{0}+{1}={2}", num1, num2, result);
        }
        catch (Exception)
        {
            Console.WriteLine("No es un caracter numérico");
        }
        Console.WriteLine("Adiós");
        
            
    }
}

