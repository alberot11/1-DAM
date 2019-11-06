//Alberto Girón Serna 

using System;
class TryExceptions
{
    static void Main()
    {   /*
        int a=0, b=0;
        try
        {
            Console.Write("Dime un numero: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.Write("Dime otro numero: ");
            b= Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
             Console.WriteLine("No es un caracter numérico");
        }
        catch (DivideByZeroException)
        {
             Console.WriteLine("No se puede dividir entre 0");
        }
        Console.WriteLine("{0}/{1}={2}", a, b, a/b);
        Console.WriteLine("{0}*{1}={2}", a, b, a*b);
        */
        //Cuando error=0 -> No hay error
        //Cuando error=1 -> Hay error
        int c=0, d=0, error=0;
        do{
            try{
                Console.Write("Dime un numero: ");
                c= Convert.ToInt32(Console.ReadLine());
                Console.Write("Dime otro numero: ");
                d= Convert.ToInt32(Console.ReadLine());
                error=0;    
            }catch (FormatException)
            {
                 Console.WriteLine("No es un caracter numérico");
                 error=1;
            }
            catch (DivideByZeroException)
            {
                 Console.WriteLine("No se puede dividir entre 0");
                 error=1;
            }
        }while(error==1);
        Console.WriteLine("{0}/{1}={2}", c, d, c/d);
        Console.WriteLine("{0}*{1}={2}", c, d, c*d);
        
    }
}
