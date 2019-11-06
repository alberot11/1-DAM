//Alberto Girón Serna

using System;
class menu
{
    static void Main ()
    {
        byte sel;
        const byte Play= 1;
        const byte Load= 2;
        const byte Exit= 0;
        Console.WriteLine(Play + ". Play");
        Console.WriteLine(Load + ". Load");
        Console.WriteLine(Exit + ". Exit");
        sel =Convert.ToByte(Console.ReadLine()); 
        
        switch (sel)
        {
            case Play: Console.Write("You choose " + sel + ". Play"); break;
            case Load: Console.Write("You choose " + sel + ". Load"); break;
            case Exit: Console.Write("You choose " + sel + ". Exit"); break;
            default: Console.Clear(); Console.Write("Not valid"); break;
        }
    }
}
