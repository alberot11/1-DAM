//Calculo Division 
//Por Alberto Girón Serna

class CalculoDivision
{
    static void Main ()
    {
        int num1, num2, division, resto;
        System.Console.Write("Introduce un número: ");
        num1=System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Introduce otro número: ");
        num2=System.Convert.ToInt32(System.Console.ReadLine());
        
        division=num1/num2;
        resto=num1%num2;
        
        System.Console.Write("Su división es: ");
        System.Console.WriteLine(division);
        System.Console.Write("Su resto de la división es: ");
        System.Console.WriteLine(resto);
        
    }
}
