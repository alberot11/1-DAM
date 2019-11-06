//Alberto Girón Serna 

using System;
class RaizCuadradaAprox
{
    static void Main()
    {
        Console.Write("dime un numero: ");
        int num= Convert.ToInt32(Console.ReadLine());
        int cuadrado=0, x=0;
        
        do 
        {
            x++;
            cuadrado=x*x;
        }
        while(cuadrado<=num);
        if(cuadrado==num)
            Console.WriteLine("Su raiz es {0} (aprox)", x);
        else
            Console.WriteLine("Su raiz es {0} (exacta)", x);
    }
}
