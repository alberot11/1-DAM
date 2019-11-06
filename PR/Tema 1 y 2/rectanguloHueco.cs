using System;

class RectanguloHueco
{
    static void Main()
    {
		Console.Write("¿De que altura quiéres el rectángulo? ");
		int alto = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿De que anchura quiéres el rectángulo? ");
		int ancho = Convert.ToInt32(Console.ReadLine());
		
		for(int fila=0; fila < alto; fila++)
		{
			for(int columna=0; columna < ancho; columna++)
			{
				if(fila==0||fila==alto-1)
                {
                    Console.Write("*");
                }
                else
                    if (columna==0||columna==ancho-1)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}
