using System;

class Password
{
    static void Main()
    {
        for (int i=10 ; i<=20 ; i=++)
					/*al declarar int dentro solo se usa dentro del 
					 * bucle y despues se destruye */
			Console.Write("{0}", i);
	}
}
