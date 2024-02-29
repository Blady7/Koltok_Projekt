Ez a C# nyelven írt egy privát statikus (private static) metódus, amelynek a neve "Beolvas". A metódus a megadott "kotoszavak.txt" nevű fájlból olvas be sorokat, majd ezeket soronként eltárolja a kivetelek nevű statikus változóban.

A try-catch blokkot használja annak érdekében, hogy kezelje a lehetséges IOException kivételt, ami akkor dobódhat, ha valami probléma van a fájl olvasása közben.

Ha a fájl olvasása sikeres, akkor