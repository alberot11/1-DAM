//Alberto Girón Serna

using System;
class examen03agiron3
{
    static void Main ()
    {
        float n1, n2, n3;
        byte iguales;
        Console.Write("Introduce un número: ");
        n1 =Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce otro número: ");
        n2 =Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce otro número: ");
        n3 =Convert.ToSingle(Console.ReadLine());
        
        if (n1==n2 && n2==n3)
            iguales=3;
        else if(n1==n2 || n1==n3 || n2==n3)
            iguales=2;
        else
            iguales=1;
        Console.WriteLine(iguales);
        
        iguales= (n1==n2 && n2==n3) ? (byte)3 : (n1==n2 || n1==n3 || n2==n3) ?
            (byte)2 : (byte)1;
        Console.WriteLine(iguales);

    }
}
