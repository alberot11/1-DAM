//Alberto Girón Serna

using System;
class Calculadora
{
    static void Main ()
    {
        double n1;
        char op;
        double n2;
        double total=1;
        
        Console.Write("Introduzca el primer número: ");
        n1 =Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduzca la operacion:" );
        op =Convert.ToChar(Console.ReadLine());
        Console.Write("Introduzca el segundo número: ");
        n2 =Convert.ToDouble(Console.ReadLine());

        if(op=='+')
            total=n1+n2;
        else if (op=='-')
            total= n1-n2;
        else if (op=='*'||op=='x'||op=='·')
            total= n1*n2;
        else if (op=='/')
            total= n1/n2;
        else 
            Console.WriteLine("operacion no disponible");
        if(op=='+'||op=='-'||op=='*'||op=='x'||op=='·'||op=='/')
        Console.WriteLine("{0}{1}{2}={3}", n1, op, n2, total);
        
    }
}
