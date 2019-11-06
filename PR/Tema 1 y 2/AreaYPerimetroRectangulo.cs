/*Área y perímetro de un rectángulo
  Alberto Girón Serna*/

using System;
class AYPRectangulo
{
    static void Main ()
    {
        int anchura, altura;
        int perimetro, area;
        Console.Write("Introduce la anchura: ");
        anchura = Convert.ToInt32(Console.ReadLine());
        Console.Write("introduce la altura: ");
        altura = Convert.ToInt32(Console.ReadLine());
        
        perimetro = 2 * anchura + 2 * altura;
        area = anchura * altura;
        Console.Write("El área es: ");
        Console.WriteLine(area);
        Console.Write("El perímetro es: ");
        Console.WriteLine(perimetro);
    }
}
