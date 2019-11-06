//Alberto Girón Serna

using System;
class Pong01
{
    static void Main ()
    {
        int y=12, x=77;
        string key;
        do
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("|");
            key= Console.ReadLine();
            if (key=="w")
                y--;
            if (key=="s")
                y++;
        } while(key!="p");
    }
}
