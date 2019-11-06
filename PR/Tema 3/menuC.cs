//Alberto Girón Serna

using System;
class menu
{
    enum sel {Play=1, Load, Exit=0};
    static void Main ()
    {
        Console.WriteLine((int) sel.Play + ". " + sel.Play);
        Console.WriteLine((int) sel.Load + ". " + sel.Load);
        Console.WriteLine((int) sel.Exit + ". " + sel.Exit);
        byte opc = Convert.ToByte(Console.ReadLine());
        switch (opc)
        {
            case (int)sel.Play: Console.Write("You choose " + (int)sel.Play +
                ". " + sel.Play); break;
            case (int)sel.Load: Console.Write("You choose " + (int)sel.Load + 
                ". " + sel.Load); break;
            case (int)sel.Exit: Console.Write("You choose " + (int)sel.Exit + 
                ". " + sel.Exit); break;
            default: Console.Clear(); Console.Write("Not valid"); break;
        }
    }
}
