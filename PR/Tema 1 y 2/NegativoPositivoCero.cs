//Mayor o Menor
//Alberto Girón Serna

class MayorOMenor
{
    static void Main()
    {
        int n1, n2, mayor;
        System.Console.Write("Introduce un número: ");
        n1=System.Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Introduce otro número: ");
        n2=System.Convert.ToInt32(Console.ReadLine());
        if (n1 > n2)
            mayor=n1;
            System.Console.WriteLine("El mayor es: ");
            System.Console.WriteLine(mayor);
            
        if (n2>n1)
            mayor=n2;
            System.Console.WriteLine("El mayor es: ");
            System.Console.WriteLine(mayor);

    }
}
