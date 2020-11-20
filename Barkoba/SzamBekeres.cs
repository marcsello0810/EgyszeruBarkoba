using System;

namespace Barkoba
{
    class SzamBekeres
    {
        static public int szamotbeker()
        {
            Console.WriteLine("Tippelj egy számot!\n");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return szam;
        }
    }
}
