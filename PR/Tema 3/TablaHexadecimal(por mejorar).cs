//Alberto Girón Serna

using System;
class TablaHexadecimal
{
    static void Main ()
    {
        int k=0;
        for(int i=0; i<=240; i+=16)
        {
            Console.Write("{0}: ", i);
            k+=16;
            for(int j=i; j<k; j++)
            {
                string num= Convert.ToString(j,16);
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
        
    }
}
