//Alberto Girón Serna
using System;

class DevolucionMaquina
{
    static void Main()
    {
		Console.Write("¿Precio? ");
		int importe= Convert.ToInt32(Console.ReadLine());
		Console.Write("¿Pagado? ");
		int pagado= Convert.ToInt32(Console.ReadLine());
		int vuelta=pagado-importe;
		
		if(pagado>importe)
		{
            Console.Write("Tu cambio es {0}: ", vuelta);
			while (vuelta>=50)
			{
				Console.Write("50 ");
				vuelta=vuelta-50;
			}
			while (vuelta>=10)
			{
				Console.Write("10 ");
				vuelta=vuelta-10;
			}
			while (vuelta>=5)
			{
				Console.Write("5 ");
				vuelta=vuelta-5;
			}
			while (vuelta>=2)
			{
				Console.Write("2 ");
				vuelta=vuelta-2;
			}
			while (vuelta>=1)
			{
				Console.Write("1 ");
				vuelta=vuelta-1;
			}
		}
		else if (importe==pagado)
			Console.WriteLine("El importe pagado es igual al precio.");
		else
		{
			Console.Write("La cantidad introducida ha de ser mayor");
			Console.WriteLine(" que el importe.");
		}
    }
}
