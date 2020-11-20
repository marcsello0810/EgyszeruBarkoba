using System;

namespace Barkoba
{
    static public class Vizsgalat
    {
        static public void vizsgal(int gondoltszam, string nev)
        {
            Console.WriteLine("Gondoltam egy számra.");
            int tippeltszam;
            int tippelesekszama = 0;
            bool nemtalalt = true;
            do
            {
                tippeltszam = SzamBekeres.szamotbeker();
                if (gondoltszam < tippeltszam)
                {
                    Console.WriteLine("A szám amire gondoltam kisebb.");
                }

                if (gondoltszam > tippeltszam)
                {
                    Console.WriteLine("A szám amire gondoltam nagyobb.");
                }

                if (gondoltszam == tippeltszam)
                {
                    nemtalalt = false;
                }

                tippelesekszama++;

            } while (nemtalalt);

            Console.WriteLine("Gratulálok! Eltaláltad");
            TxtFajlbaMentes.fajlbament(tippelesekszama, nev);
            Menu.opciovalasztas();
        }
    }
}
