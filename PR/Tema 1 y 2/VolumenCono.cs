//le pides al usuario el radio y la altura de un cono y le tienes que dar el volumen del cono.
//Alberto Girón serna

using System;
class VolumenCono
{
static void Main ()
{
    int radio, altura, volumen;
    Console.Write("dime el radio del cono: ") ;
    radio=Convert.ToInt32(Console.ReadLine());
    Console.Write("dime la altura del cono: ") ;
    altura=Convert.ToInt32(Console.ReadLine());
    volumen= radio*radio*31416*altura/10000/3;
    //las divisiones tienen que ir al final.
    Console.Write(volumen);
}
}
    
    
