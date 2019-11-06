//Alberto Girón Serna

using System;
class DistincionCaracteres 
{
    static void Main ()
    {
        Console.Write("introduce un caracter: ");
        char caracter = Convert.ToChar(Console.ReadLine());
        
        switch (caracter)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Es una vocal");
                break;
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
                Console.WriteLine("Es un numero");
                break;
            case '"':
            case '\'':
                Console.WriteLine("es un delimitador de texto");
                break;
            default:
                Console.WriteLine("otro simbolo");
                break;
        }
                
        if (caracter>='a' && caracter<='u')
        {
            Console.Write("Es una vocal");
        }
        else if (caracter>='0' && caracter<='9')
        {
            Console.WriteLine("es un numero");
        }
        else if (caracter=='"' || caracter=='\'')
        {
            Console.WriteLine("Es un delimitador de texto");
        }
        else
        {
            Console.WriteLine("Es otro caracter");
        }
            
    }
}

