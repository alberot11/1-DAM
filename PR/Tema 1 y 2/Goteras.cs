//Alberto Girón Serna 

using System;
class Goteras
{
    static void Main()
    {
        int cases= Convert.ToInt32(Console.ReadLine());
        for (int i=0; i<cases; i++)
        {
            int drops= Convert.ToInt32(Console.ReadLine());
            if(drops>0 && drops<86400)
            {
                int hours= drops/3600;
                int min= (drops%3600)/60; 
                int sec=(drops%3600)%60%60;
                if (hours==0)
                Console.Write("00:");
                else if (hours<10)
                Console.Write("0{0}:", hours);
                else
                Console.Write("{0}:", hours);
                if (min==0)
                Console.Write("00:");
                else if (min<10)
                Console.Write("0{0}:", min);
                else
                Console.Write("{0}:", min);
                if (sec==0)
                Console.WriteLine("00");
                else if (sec<10)
                Console.WriteLine("0{0}", sec);
                else
                Console.WriteLine(sec);
            }
        }
    }
}
