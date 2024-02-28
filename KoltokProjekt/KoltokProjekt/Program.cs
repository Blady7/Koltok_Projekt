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


            List<Kolto> koltok = new List<Kolto>();
            string fajlKotoSzavak = "kotoszavak.txt";

            string fajlKolto = "Petofi.txt";
            string nevKolto = "Petőfi Sándor";
            koltok.Add(new Kolto(fajlKolto, nevKolto));
            fajlKolto = "Ady.txt";
            nevKolto = "Ady Endre";
            koltok.Add(new Kolto(fajlKolto, nevKolto));

            fajlKolto = "Arany.txt";
            nevKolto = "Arany János";
            koltok.Add(new Kolto(fajlKolto, nevKolto));

            Koltok k = new Koltok(koltok);


            Console.ReadLine();
        }
    }
}
