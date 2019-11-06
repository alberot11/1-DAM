//CelsiusToFarenheitConverter
//ByAlbertoGirónSerna

using System;

class CelsiusToFarenheit
{
    static void Main ()
    {
        int celsius, farenheit;
        Console.Write("how many celsius degrees do you need to convert?");
        celsius=Convert.ToInt32(Console.ReadLine());
        farenheit=(celsius*9/5)+32;
        Console.Write("(0) celsius equals to (1) farenheit" celsius, farenheit);
    }
}
