using System;
using System.Collections.Generic;
using System.Linq;

namespace KoltokProjekt
{
    internal class Kolto
    {
        public string fajlKolto;
        public string nevKolto;
        public Dictionary<string, int> koltoSzavai = new Dictionary<string, int>();

        public Kolto(string fajlKolto, string nevKolto)
        {
            this.fajlKolto = fajlKolto;
            this.nevKolto = nevKolto;
        }

        internal void KoltoSzavaiKiszed(string[] mindenSzo)
        {
            var gyakorisag = new Dictionary<string, int>();

            foreach (var szo in mindenSzo)
            {
                if (!Kivetelek.KivetelLista().Contains(szo) && szo.Length > 1)
                {
                    if (!gyakorisag.ContainsKey(szo))
                    {
                        gyakorisag.Add(szo, 1);
                    }
                    else
                    {
                        gyakorisag[szo]++;
                    }

                }
                
            }
            var top25Szavak = gyakorisag.OrderByDescending(pair => pair.Value).Take(25);

            Console.WriteLine("\n {0} legtöbbet használt szavai:", nevKolto);

            foreach (var pair in top25Szavak)
            {
                Console.WriteLine("{0}: {1} előfordulás", pair.Key, pair.Value);
            }


        }
    }
}