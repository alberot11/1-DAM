using System;

class NumeroMagico
{
    static void Main()
    {
        int num= 666, numuser;
        do
        {
            Console.Write("Dame un número: ");
            numuser= Convert.ToInt32(Console.ReadLine());
            if(numuser > num)
                Console.WriteLine("Te has pasado");
            else if(numuser < num)
                Console.WriteLine("No has llegado");
        } while (numuser!=num);
        Console.WriteLine("Has acertado");
    }
}
