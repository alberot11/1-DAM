//Alberto Girón Serna

using System;

class cuentaBreakContinue
{
    static void Main()
    {
		Console.Write("Dime un numero: ");
		int num, divisores=0;
		num=Convert.ToInt32(Console.ReadLine());
		for(int i=1; i<=num; i++)
		{
			if(num%i==0)
			divisores++;
			if(divisores>2)
			break;
			//break = Caca
		}
		if(divisores==2)
			Console.WriteLine("Es primo");
		else
			Console.WriteLine("No es primo");
		
	}
}
