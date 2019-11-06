//Alberto Girón Serna

using System;
class CylinderVolume
{
    static void Main ()
    {
        float pi=3.141593f; 
        float baseArea;
        float cylinderVolume;
        Console.Write("Enter cylinder height:");
        float height =Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter cylinder radius");
        float radius =Convert.ToSingle(Console.ReadLine());
        
        baseArea= pi*radius*radius;
        cylinderVolume=baseArea*height;
        
        Console.WriteLine("The volume is: {0}", cylinderVolume);
    }
}
