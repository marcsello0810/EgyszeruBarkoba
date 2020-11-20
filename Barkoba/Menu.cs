using System;

namespace Barkoba
{
    static public class Menu
    {
        static public void opciovalasztas()
        {
            Console.WriteLine("A megfelelő opció kiválasztásához a sorszámot kérem!\n [1] Játék indítása [2] Rekord [3] Kilépés ");
            string valmenupont = Console.ReadLine();

            switch (valmenupont)
            {
                case "1":
                    Jatek.jatekinditas();
                    break;
                case "2":
                    RekordKiiras.rekordotkiir();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Nincs ilyen menüpont!");
                    opciovalasztas();
                    break;
            }
        }
    }
}
