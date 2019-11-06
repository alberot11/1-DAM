//Alberto Girón Serna
//25-09-2019

class ConverosrUnidades
{
    static void Main ()
    {
        int mmHg, atm, pa;
        System.Console.Write("Introduce los milímetros de mercurio: ");
        mmHg = System.Convert.ToInt32(System.Console.ReadLine());
        
        atm = mmHg/760;
        pa = (101325*mmHg)/760;
        System.Console.WriteLine("{0} mmHg son {1} atmósferas", mmHg, atm);
        System.Console.WriteLine("{0} mmHg son {1} pascales", mmHg, pa);
        
        int dec1, dec2;
        dec1 = 1000*mmHg/760%1000;
        dec2 = 1000*(101325*mmHg)/760%1000;
        System.Console.WriteLine("{0} mmHg son {1}.{2} atmósferas",
            mmHg, atm, dec1);
        System.Console.WriteLine("{0} mmHg son {1}.{2} pascales",
            mmHg, pa, dec2);
    }
}
