using System;

class Password
{
    static void Main()
    {
		int num, sgn;
		Console.Write("Dime un número: ");
		num=Convert.ToInt32(Console.ReadLine());
		
		if (num==0)
			sgn=0;
			
		else if (num<0)
			sgn=-1;
		else
			sgn=1;
		Console.WriteLine("signo ({0}) = {1}", num, sgn);
		
		sgn= num==0 ? 0 : (num<0 ? -1 : 1);
		Console.WriteLine("signo ({0}) = {1}", num, sgn);
	}
}
