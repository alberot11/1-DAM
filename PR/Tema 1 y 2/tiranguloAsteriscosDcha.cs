using System;

class Asterisks
{
    static void Main()
    {
		Console.Write("de que altura quiéres el triangulo? ");
		int altura= Convert.ToInt32(Console.ReadLine());
		int espacios= altura-1;
		int asteriscos=1;
		
		for(int fila=0; fila<altura; fila++)
		{
			for(int columna=0; columna<espacios; columna++)
			{
				Console.Write(" ");
			}
			for(int columna=0; columna<=fila; columna++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
			espacios--;
			asteriscos++;
		}
    }
}
