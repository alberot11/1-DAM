using System;

class Asterisks
{
    static void Main()
    {
       Console.Write("Dime el lado del cuadrado: ");
       int lado= Convert.ToInt32(Console.ReadLine());
       
       for(int fila=0; fila<lado; fila++)
       {
			for(int columna=0; columna<lado; columna++)
			{
				Console.Write("* ");
			}
			Console.WriteLine();
		}
    }
}
