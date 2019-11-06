//Alberto Girón Serna

using System;

class cuentaBreakContinue
{
    static void Main()
    {
		for(int i=1; i<=5; i++)
		{
			if (i==3) break;
			//break = Caca
			Console.Write("{0} ", i);
		}
		for(int i=1; i<=5; i++)
		{
			if(i==3) continue;
			//contnue = Caca
			Console.Write("{0} ", i);
		}
	}
}
