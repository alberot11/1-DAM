//Alberto Girón Serna

using System;

class cuentaBreakContinue
{
    static void Main()
    {
		Console.Write("Dime un numero: ");
		int num, divisores=0;
		num=Convert.ToInt32(Console.ReadLine());
		int i=1;
		while( i<=num && divisores<=2)
		{
			if(num%i==0)
			divisores++;
			i++;
		}
		if(divisores==2)
			Console.WriteLine("Es primo");
		else
			Console.WriteLine("No es primo");
		
	}
}
