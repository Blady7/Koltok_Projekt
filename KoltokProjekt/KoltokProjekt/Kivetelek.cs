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

            }
            catch (IOException e)
            {

            }
        }

        public static string[] KivetelLista()
        {
            return kivetelek;
        }
    }
}
