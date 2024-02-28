using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoltokProjekt
{
    public static class Kivetelek
    {
        public static string[] kivetelek;

        static Kivetelek()
        {
            Beolvas();
        }

        private static void Beolvas()
        {
            try
            {
                kivetelek = File.ReadAllLines("kotoszavak.txt");
                //foreach (var line in lines)
                //{
                //    kivetelek.Add(line);
                //}
            }
            catch (IOException e)
            {
                // Ide jöhet a hiba kezelése, például:
                // Console.WriteLine("Hiba történt a fájl olvasása közben: " + e.Message);
                // vagy logolás stb.
            }
        }

        public static string[] KivetelLista()
        {
            return kivetelek;
        }
    }
}
