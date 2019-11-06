using System;

class DevolucionMaquina
//Una maquina devuelve el dinero con billetes de 50,10,5 y monedas 2 y 1
//Tiene que devolver el cambio con los billetes o monedas mas grandes 
//posibles
{
    static void Main()
    {
		Console.Write("¿Cuál es el importe? ");
		int importe= Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Cuanto has introducido? ");
		int introd= Convert.ToInt32(Console.ReadLine());
		int vuelta=introd-importe;
		
		for (vuelta; vuelta>=50; vuelta=vuelta-50)
		{
			Console.Write("50 ");
		}
		for (vuelta; vuelta>=10; vuelta=vuelta-10)
		{
			Console.Write("10 ");
		}
		for (vuelta; vuelta>=5; vuelta=vuelta-5)
		{
			Console.Write("5 ");
		}
		for (vuelta; vuelta>=2; vuelta=vuelta-2)
		{
			Console.Write("2 ");
		}
		for (vuelta; vuelta>=1; vuelta=vuelta-1)
		{
			Console.Write("1 ");
		}
		
    }
}
