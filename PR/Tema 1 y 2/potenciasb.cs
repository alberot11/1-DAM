//~ Alberto Girón serna, Patricia Lopez Navarro
using System;

class Potencias
{
    static void Main()
    {
        Console.Write("Dime la base: ");
        int num= Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime el exponente: ");
        int exp= Convert.ToInt32(Console.ReadLine());
        int result= 1;
        for(int i=0; i<exp; i++)
        {
            result= result* num;
        }
        Console.WriteLine("{0}^{1}={2}", num, exp, result);
        
            
    }
}
