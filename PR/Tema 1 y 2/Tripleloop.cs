using System;

class TripleLoop
{
    static void Main()
    {
		Console.Write("Dime un numero impar: ");
		int num1= Convert.ToInt32(Console.ReadLine());
		Console.Write("Dime otro numero: ");
		int num2= Convert.ToInt32(Console.ReadLine());
		if(num1%2!=0 && num1<num2)
		{
			for(int i=num1; i<=num2; i=i+2)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine();
		} else if (num1%2!=0 && num1>num2)
		{
			for(int i=num1; i>=num2; i=i-2)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine();
		} else if (num1==num2)
		{
			Console.WriteLine("Ha introducido el mismo numero 2 veces");
		}else
			Console.WriteLine("El primer numero tenía que ser impar");
			
			
			
			
		if(num1%2!=0 && num1<num2)
		{
			for(int i=num1; i<=num2; i++)
			{
				if(i%2!=0)
				Console.Write("{0} ", i);
			}
			Console.WriteLine();
		} else if (num1%2!0 && num1>num2)
		{
			for(int i=num1; i>=num2; i--)
			{
				if(i%2!=0)
				Console.Write("{0} ", i);
			}
			Console.WriteLine();
		} else if (num1==num2)
		{
			Console.WriteLine("Ha introducido el mismo numero 2 veces");
		}else
			Console.WriteLine("El primer numero tenía que ser impar");
			
			
		int j=num1;
		if(num1%2!=0 && num1<num2)
		{
			while(j<=num2)
			{
				Console.Write("{0} ", j);
				j=j+2;
			}
			Console.WriteLine();
		} else if (num1%!0 && num1>num2)
		{
			while(j>=num2)
			{
				Console.Write("{0} ", j);
				j=j-2;
			}
			Console.WriteLine();
		} else if (num1==num2)
		{
			Console.WriteLine("Ha introducido el mismo numero 2 veces");
		}else
			Console.WriteLine("El primer numero tenía que ser impar");
    }
}
