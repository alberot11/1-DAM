//Mayor o Menor
//Alberto Girón Serna

class MayorOMenor
{
    static void Main()
    {
        int n1, n2, mayor;
        System.Console.Write("Introduce un número: ");
        n1=System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Introduce otro número: ");
        n2=System.Convert.ToInt32(System.Console.ReadLine());
      //valor=condicion? verdad : falso
        mayor= n1 >= n2? n1 : n2;
        System.Console.Write("El mayor es: ");
        System.Console.WriteLine(mayor);
    }
}
