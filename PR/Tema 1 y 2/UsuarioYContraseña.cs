using System;

class UserAndPassword
{
    static void Main()
    {
		Console.Write("User: ");
		int user= Convert.ToInt32(Console.ReadLine());
		Console.Write("Password: ");
		int password= Convert.ToInt32(Console.ReadLine());
		while(password!=1234 || user!= 1493)
		{
			Console.WriteLine("Access denied");
			Console.Write("User: ");
			user= Convert.ToInt32(Console.ReadLine());
			Console.Write("Password: ");
			password= Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Access granted");
    }
}
