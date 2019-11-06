//Alberto Girón Serna 

using System;
class countdown
{
    static void Main()
    {
        int num1, num2;
        Console.Write("Enter a number: ");
        num1= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        num2= Convert.ToInt32(Console.ReadLine());
        
        if(num1>num2)
            for(int i=num1; i>=num2; i--)
                if (num1%2==0)
                {
                    if(i%2==0 && i!=0)
                    Console.Write("{0} ", i);
                }else if (num1%2!=0)
                {
                    if(i%2!=0 && i!=0)
                    Console.Write("{0} ", i);
                }
        else if (num2>num1)
        {
            for(int j=num2; j>=num1; j--)
                if (num1%2==0)
                {
                    if(j%2==0 && j!=0)
                    Console.Write("{0} ", j);
                }else if (num1%2!=0)
                {
                    if(j%2!=0 && j!=0)
                    Console.Write("{0} ", j);
                }
        }
            
    }
}
//no me ha dado tiempo
