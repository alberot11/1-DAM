using System;

class PerimetroCircunferencia
{
    static void Main()
    {
        double pi=3.141592, radio, lenght;
        Console.Write("Dime el radio de la circunferencia: ");
        radio = Convert.ToDouble(Console.ReadLine());
        lenght = 2 * pi * radio;
        Console.WriteLine("el perimetro es: {0}", lenght);
    }
}
