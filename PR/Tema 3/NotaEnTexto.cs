//Alberto Girón Serna

using System;
class TextoNota
{
    static void Main ()
    {
        int nota;
        string textoComoNota;
        Console.Write("Dime la nota: ");
        nota =Convert.ToInt32(Console.ReadLine());
        
        if (nota < 60)
        {
            textoComoNota= "suspenso";
        }
        else
        {
            textoComoNota= "aprobado";
        }
        Console.WriteLine(textoComoNota);
        
        textoComoNota= nota < 60 ? "suspenso":
            "aprobado";
        Console.WriteLine(textoComoNota);
        
    }
}
