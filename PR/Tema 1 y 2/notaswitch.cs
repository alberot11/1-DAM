using System;

class Password
{
    static void Main()
    {
        Console.Write("¿Cuál es tu nota? ");
        int nota=Convert.ToInt32(Console.ReadLine());
        switch (nota)
        {
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
				Console.WriteLine("Suspenso");
			break;
			case 5:
				Console.WriteLine("Aprobado");
			break;
			case 6:
				Console.WriteLine("bien");
			break;
			case 7:
			case 8:
				Console.WriteLine("Notable");
			break;
			case 9:
			case 10:
				Console.WriteLine("Sobresaliente");
			break;
			default:
				Console.WriteLine("La nota tiene que ser de 1 a 10");
			break;
		}
			
	}
}
