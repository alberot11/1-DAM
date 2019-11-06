//Alberto Girón Serna

using System;
class examen02agiron1
{
    static void Main ()
    {
        int a= Convert.ToInt32(Console.ReadLine());
        int b= Convert.ToInt32(Console.ReadLine());
        int x;
        if(a<b)
        {
            for(x=a; x<=b; x++)
            {
                if(x%3==0)
                    Console.Write("{0} ", x);
            }
            Console.WriteLine();
            
            x=a;
            while(x<=b)
            {
                if(x%3==0)
                    Console.Write("{0} ", x);
                x++;
            }
            Console.WriteLine();
            
            x=a;
            do
            {
                if(x%3==0)
                        Console.Write("{0} ", x);
                    x++;
            } while (x<=b);
            Console.WriteLine();
        }
        else
        {
            for(x=b; x<=a; x++)
            {
                if(x%3==0)
                    Console.Write("{0} ", x);
            }
            Console.WriteLine();
            
            x=b;
            while(x<=a)
            {
                if(x%3==0)
                    Console.Write("{0} ", x);
                x++;
            }
            Console.WriteLine();
            
            x=b;
            do
            {
                if(x%3==0)
                        Console.Write("{0} ", x);
                    x++;
            } while (x<=a);
            Console.WriteLine();
        }
    }
}
