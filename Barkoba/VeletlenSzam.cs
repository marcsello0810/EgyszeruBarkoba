using System;

namespace Barkoba
{
    static public class VeletlenSzam
    {
        static public int szamvalasztas()
        {
            Random r = new Random();
            int szam = r.Next(0, 100);
            return szam;
        }
    }
}
