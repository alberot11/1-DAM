//Alberto Girón Serna

using System;
class menorIfTern
{
    static void Main ()
    {
        ushort n1, n2, n3, menor;
        Console.Write("introduce un numero: ");
        n1 =Convert.ToUInt16(Console.ReadLine());
        Console.Write("introduce otro numero: ");
        n2 =Convert.ToUInt16(Console.ReadLine());
        Console.Write("introduce otro numero: ");
        n3 =Convert.ToUInt16(Console.ReadLine());
        
        if(n1<=n2 && n1<=n3)
        {
            menor=n1;
        }
        else if (n2<=n3)
        {
            menor=n2;
        }
        else
        {
            menor=n3;
        }
        Console.WriteLine(menor);
        
        menor= (n1<=n2 && n1<=n3) ? n1 : n2<=n3 ? n2 : n3;
        Console.WriteLine(menor);
    }
}
