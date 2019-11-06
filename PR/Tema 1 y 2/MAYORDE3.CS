using System;

class Asterisks
{
    static void Main()
    {
       Console.Write("Dime un numero: ");
       int a= Convert.ToInt32(Console.ReadLine());
       Console.Write("Dime un numero: ");
       int b= Convert.ToInt32(Console.ReadLine());
       Console.Write("Dime un numero: ");
       int c= Convert.ToInt32(Console.ReadLine());
       
       if(a>=b && a>=c)
			Console.WriteLine(a);
		else if (b>=a && b>=c)
			Console.WriteLine(b);
		else
			Console.WriteLine(c);
    }
}
