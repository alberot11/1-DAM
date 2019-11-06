//Alberto Girón Serna

using System;
class Calculadora
{
    static void Main ()
    {
        double n1;
        char op;
        double n2;
        double suma;
        double resta;
        double prod;
        double div;
        
        Console.Write("Introduzca el primer número: ");
        n1 =Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduzca la operacion:" );
        op =Convert.ToChar(Console.ReadLine());
        Console.Write("Introduzca el segundo número: ");
        n2 =Convert.ToDouble(Console.ReadLine());
        
        suma=n1+n2;
        resta=n1-n2;
        prod=n1*n2;
        div=n1/n2;
        if(op=='+')
            Console.WriteLine("{0}+{1}={2}", n1, n2, suma);
        else if (op=='-')
            Console.WriteLine("{0}-{1}={2}", n1, n2, resta);
        else if (op=='*'||op=='x'||op=='·')
            Console.WriteLine("{0}{1}{2}={3}", n1, op, n2, prod);
        else if (op=='/')
            Console.WriteLine("{0}/{1}={2}", n1, n2, div);
        else 
            Console.WriteLine("operacion no disponible");
        
    }
}
