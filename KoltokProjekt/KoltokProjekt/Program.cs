using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoltokProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string fajlKolto = "Petofi.txt";
            List<Kolto> koltok = new List<Kolto>();
            string nevKolto = "Petőfi Sándor";
            koltok.Add(new Kolto(fajlKolto, nevKolto));
            // fajlKolto = "Ady.txt";
            // nevKolto = "Ady Endre";
            //koltok.Add(new Kolto(fajlKolto, nevKolto));

            //fajlKolto = "Arany.txt";
            // nevKolto = "Arany János";
            //koltok.Add(new Kolto(fajlKolto, nevKolto));

            string fajlKotoSzavak = "kotoszavak.txt";
           

            Koltok k = new Koltok(koltok, fajlKotoSzavak);
            Console.ReadLine();
        }
    }
}
