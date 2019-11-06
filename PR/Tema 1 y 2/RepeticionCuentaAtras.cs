using System;

class CuentaAtras
{
    static void Main()
    {
		Console.WriteLine("Cuantas veces quieres que lo escriba?");
		int num=Convert.ToInt32(Console.ReadLine());
		for (int fila=0; fila<num; fila++)
		{
			for(int cuentaAtras=10; cuentaAtras>=0; 
				cuentaAtras=cuentaAtras-2)
				Console.Write("{0} ", cuentaAtras);
			Console.WriteLine();
		}
	}
}
