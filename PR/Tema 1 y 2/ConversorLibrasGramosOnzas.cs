//Por Alberto Girón Serna
//21-09-2019

using System;
class ConversorMasas
{
    static void Main()
    {
        int libras, onzas, gramos;
        Console.Write("Introduce el peso en libras: ");
        libras=Convert.ToInt32(Console.ReadLine());
        onzas=libras*16;
        gramos=libras*453592/1000;
        Console.WriteLine("{0} libras son {1} onzas", libras, onzas);
        Console.WriteLine("{0} Libras son {1} gramos", libras, gramos);
    }
}
