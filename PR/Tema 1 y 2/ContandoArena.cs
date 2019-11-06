//Alberto Girón Serna 

using System;
class ContandoArena
{
    static void Main()
    {
        int num;
        do
        {
        num= Convert.ToInt32(Console.ReadLine());

        if(num==0)
        {}
        else
        {
        for (int i=0; i<num; i++)
        {
            Console.Write(1);
        }
        Console.WriteLine();
        }
        }
        while (num!=0);
    }
}
