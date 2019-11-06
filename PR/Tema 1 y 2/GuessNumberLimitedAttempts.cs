//~ Alberto Girón serna
using System;

class GuessNumberLA
{
    static void Main()
    {
        int num=DateTime.Now.Millisecond, unum, attempts=9, ntry=1;
        do
        {
            Console.Write("Enter a number: ");
            unum=Convert.ToInt32(Console.ReadLine());
            if(num==unum)
                Console.WriteLine ("You Win");
            else if (unum>num)
                {
                    Console.WriteLine("Too big");
                }
            else
                {
                    Console.WriteLine("Too low");
                }
            if(ntry==9)
                {
                    Console.WriteLine("You Failed");
                }
            ntry++; 
        } while (ntry<=attempts);

            
        
        
    }
}

