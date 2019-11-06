//Alberto Girón Serna

using System;
class tiposimbolo
{
    static void Main ()
    {
        Console.Write("Introduce un caracter: ");
        char a =Convert.ToChar(Console.ReadLine());
        
        if (a>='0' && a<='9')
        {
            Console.WriteLine("es un digito");
        }
        else if (a=='+' || a=='-' || a=='*' || a=='/' || a=='%')
        {
            Console.WriteLine("es un operador");
        }
        else if (a=='.' || a==',' || a==';' || a==':')
        {
            Console.WriteLine("es un simbolo de puntuacion");
        }
        else
        {
            Console.WriteLine("otro simbolo");
        }
        
        switch (a)
        {
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            case '0':
                Console.WriteLine("es un digito");
                break;
            case '+':
            case '-':
            case '*':
            case '/':
                Console.WriteLine("es un operador");
                break;
            case '.':
            case ',':
            case ';':
            case ':':
                Console.WriteLine("es un signo de puntuacion");
                break;
            
            default:
                Console.WriteLine("otro simbolo");
                break;
        }
    }
}
