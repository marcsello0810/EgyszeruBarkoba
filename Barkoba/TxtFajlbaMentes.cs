using System.IO;

namespace Barkoba
{
    class TxtFajlbaMentes
    {
        static public void fajlbament(int tippszam, string nev)
        {
            using (StreamWriter sw = new StreamWriter("Statistic.txt", append: true))
            {
                sw.WriteLine(tippszam + ";" + nev);
            }
        }
    }
}
