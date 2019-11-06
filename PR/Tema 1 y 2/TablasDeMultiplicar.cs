//Tablas de multiplicar por Alberto Girón Serna

using System;

class TablasDeMultiplicar
{
    static void Main()
    {
        int numero;
        Console.Write("¿De qué número quieres la tabla de multiplicar? ");
        numero=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("la tabla de multiplicar del (0) es:",numero);
        Console.WriteLine("{0} * 0 = {1}",numero, numero*0);
        Console.WriteLine("{0} * 1 = {1}",numero, numero*1);
        Console.WriteLine("{0} * 2 = {1}",numero, numero*2);
        Console.WriteLine("{0} * 3 = {1}",numero, numero*3);
        Console.WriteLine("{0} * 4 = {1}",numero, numero*4);
        Console.WriteLine("{0} * 5 = {1}",numero, numero*5);
        Console.WriteLine("{0} * 6 = {1}",numero, numero*6);
        Console.WriteLine("{0} * 7 = {1}",numero, numero*7);
        Console.WriteLine("{0} * 8 = {1}",numero, numero*8);
        Console.WriteLine("{0} * 9 = {1}",numero, numero*9);
        Console.WriteLine("{0} * 10 = {1}",numero, numero*10);
    }
    
}

