//Contraseña 1234
//Alberto Girón Serna

using System;
class Contraseña1234
{
    static void Main ()
    {
        int contraseña, intentos=1;
        Console.Write("Introduce la contraseña: ");
        contraseña=Convert.ToInt32(Console.ReadLine());
        while (contraseña != 1234)
        {
            intentos = intentos + 1;
            Console.WriteLine("La contraseña introducida es incorrecta");
            Console.Write("Este es tu intento numero {0}, ", intentos);
            Console.Write("Introduce la contraseña: ");
            contraseña=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine ("BIENVENIDO");
    }
}
