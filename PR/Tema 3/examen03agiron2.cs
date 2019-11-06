//Alberto Girón Serna

using System;
class examen03agiron2
{
    static void Main ()
    {
        Console.Write("Introduce una letra: ");
        char letra = Convert.ToChar(Console.ReadLine());
        
        switch (letra)
        {
            case 'A':
            case 'B':
            case 'C':
            case 'D':
            case 'E':
            case 'F':
            case 'G':
            case 'H':
            case 'I':
            case 'J':
            case 'K':
            case 'L':
            case 'M':
            case 'N':
            case 'O':
            case 'P':
            case 'Q':
            case 'R':
            case 'S':
            case 'T':
            case 'U':
            case 'V':
            case 'W':
            case 'X':
            case 'Y':
            case 'Z':
                Console.WriteLine("Es una letra mayúscula");
                break;
            case '6':
            case '7':
            case '8':
            case '9':
            case '0':
                Console.WriteLine("Es un dígito mayor que 5");
                break;
            case '/':
            case '\\':
                Console.WriteLine("es una \"barra\"");
                break;
            default:
                Console.WriteLine("Es otro símbolo");
                break;
        }
        
        if(letra>='A' && letra<='Z')
            Console.WriteLine("Es una letra mayúscula");
        else if ((letra>'5' && letra<='9') || letra=='0')
            Console.WriteLine("Es un dígito mayor que 5");
        else if (letra=='/' || letra=='\\')
        {
            Console.WriteLine("es una \"barra\"");
        }
        else
        {
            Console.WriteLine("Es otro símbolo");
        }
    }
}
