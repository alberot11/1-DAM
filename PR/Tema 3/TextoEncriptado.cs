//Alberto Girón Serna

using System;
class TextoEncriptado
{
    static void Main ()
    {
        Console.Write("Introduce un texto: ");
        string texto= Console.ReadLine();
        
        foreach(char c in texto)
        {
            char encriptado= ((char)(c^1));
            Console.Write(encriptado);
            char desencriptado=(char)(encriptado^1);
            Console.WriteLine(desencriptado);
            
        }
    }
}
