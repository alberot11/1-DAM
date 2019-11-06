using System;
//Program that asks the user height and width and draws a rectangle 
//with the given dimensions
class RectangleDraw
{
    static void Main()
    {
		Console.Write("¿height of the rectangle? ");
		int height = Convert.ToInt32(Console.ReadLine());
		Console.Write("¿width of the rectangle? ");
		int width = Convert.ToInt32(Console.ReadLine());
		
		for(int row=0; row < height; row++)
		{
			for(int column=0; column < width; column++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
