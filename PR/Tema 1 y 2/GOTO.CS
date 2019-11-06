//~ Alberto Girón serna
using System;

class Goto
{
    static void Main()
    {
        for (int i=1; i<11; i++)
        {
            for(int j=20; j<31; j=j+2)
            {
                if (i>3 && j>25)
                {
                    break;
                }
                Console.WriteLine("{0} {1}", i, j);
            }
        }

    }
}
