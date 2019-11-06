//
//Alberto Girón Serna

using System;
class greatestof3
{
    static void Main ()
    {
        int num1, num2, num3, mayor;
        Console.Write("Enter a number: ");
        num1= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        num2= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        num3= Convert.ToInt32(Console.ReadLine());
        
        if (num1>num2 && num2>num3)
            mayor=num1;
        else if (num2>num3)
            mayor=num2;
        else
            mayor=num3;

        Console.WriteLine(mayor);
        
        
        mayor= num1>num2 && num2>num3 ? num1 : num2>num3 ? num2 : num3;
        
        Console.WriteLine(mayor);

    }
}
