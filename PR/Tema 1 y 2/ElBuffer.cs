//Alberto Girón Serna 

using System;
class ElBuffer
{
    static void Main()
    {
        int casos= Convert.ToInt32(Console.ReadLine());
        int urinarios; 
        for (int cont=0; cont<casos; cont++)
        {
            urinarios= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((urinarios+1)/2);
        }
    }
}
