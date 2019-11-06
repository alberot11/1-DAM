//Alberto Girón Serna

using System;
class operacionesBinario
{
    static void Main ()
    {
        long a, b;
        Console.Write("Introduce un numero: ");
        a =Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce otro numero: ");
        b =Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(Convert.ToString(a,2));
        Console.WriteLine(Convert.ToString(b,2));
        
        Console.WriteLine("OR: " + Convert.ToString(a|b,2));
        Console.WriteLine("AND: " + Convert.ToString(a&b,2));
        Console.WriteLine("XOR: " + Convert.ToString(a^b,2));
        Console.WriteLine("NOT: " + Convert.ToString(a~b,2));
        Console.WriteLine(">>: " + Convert.ToString(a>>2));
        Console.WriteLine("<<: " + Convert.ToString(a<<2));
    }
}
