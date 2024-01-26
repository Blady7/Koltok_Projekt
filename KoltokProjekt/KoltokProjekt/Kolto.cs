using System;
using System.Collections.Generic;

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
            foreach (var szo in mindenSzo)
            {
                if (!koltoSzavai.ContainsKey(szo))
                {
                    koltoSzavai.Add(szo, 1);
                }
                else
                {
                    koltoSzavai[szo]++;
                }
            }
        }
    }
}