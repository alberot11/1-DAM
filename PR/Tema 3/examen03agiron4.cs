//Alberto Girón Serna

using System;
class examen03agiron4
{
    static void Main ()
    {
        //1^p + 2^p + 3^p + ... + n^p
        string n;
        long n1, p, tpot, pot, sum;
        
        
        do 
        {
            Console.Write("Sumandos? ");
            n=Console.ReadLine();
            if(n!="fin")
            {
                sum=0;
                Console.Write("Potencia? ");
                p =Convert.ToInt64(Console.ReadLine());
                n1= Convert.ToInt64(n);
                for(long i=1; i<=n1; i++)
                {
                    pot=i;
                    tpot=1;
                    for (long j=1; j<=p; j++)
                    {
                        tpot=tpot*pot;
                    }
                    sum=sum+tpot;
                }
                Console.WriteLine("Resultado: " + sum);
            }
            else
            Console.WriteLine("Sesión terminada");
        } while(n!="fin");
        
    }
}
