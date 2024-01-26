﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace KoltokProjekt
{
    internal class Koltok
    {
       
        private string fajlKotoSzavak;
        
        private List<Kolto> koltok;

       

        public Koltok(List<Kolto> koltok, string fajlKotoSzavak)
        {
            this.koltok = koltok;
            this.fajlKotoSzavak = fajlKotoSzavak;
            Beolvas();
            Console.WriteLine(  "Beolvasás kész");
        }

        private void Beolvas()
        {
            foreach (var kolto in koltok)
            {
                string content = File.ReadAllText(kolto.fajlKolto);
                char[] hatarolo = { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' };
                string[] mindenSzo = content.ToLower().Split(hatarolo , StringSplitOptions.RemoveEmptyEntries);
                kolto.KoltoSzavaiKiszed(mindenSzo);

            }
        }

        

    }
}