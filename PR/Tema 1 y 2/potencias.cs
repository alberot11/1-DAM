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
        int original=num;
        int cont= 1;
        if (exp==0)
        {
            num=1;
        }
        else 
        {
        while (cont<exp)
        {
            num=num*original;
            cont++;
        }
        }
        Console.WriteLine(num);
        
            
    }
}
