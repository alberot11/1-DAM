//Alberto Girón Serna

using System;
class PartidaTerminadaBool
{
    static void Main ()
    {
        bool partidaTerminada= false;
        int vidas= 3, nivel= 45;
        
        partidaTerminada= vidas>0&&nivel<=99 ? true : false;
    }
}
