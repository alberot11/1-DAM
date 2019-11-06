using System;

class Password
{
    static void Main()
    {
        
        Console.Write("Enter your password: ");
        int password = Convert.ToInt32(
            Console.ReadLine());
		
		do
		{
			Console.Write("Enter your password again: ");
            password = Convert.ToInt32(
                Console.ReadLine());
			if(password != 1234)
			Console.WriteLine("Wrong attempt");
		}
        while (password != 1234)
        Console.WriteLine("Welcome!");
    }
}
