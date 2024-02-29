#1
- Minden költőnek létrehoztam egy „nevKolto” és egy „fajlKolto” változót. Majd ezeket beadtam egy „Kolto” nevezetű osztályba.

#2
- Egy ciklust használva végig megy a „koltok” nevű objektumon. A „char hatarolo” -ban a határoló karaktereket egy tömbben letárolom, majd a „mindenSzo” -ban le veszem az összes betűt kisbetűre, és kitörlöm az üres részeket.

#3
- Először létrehoztam egy üres „gyakorisag” nevű szótárat, amelyben tárolni fogja a szavak gyakoriságát (azaz, hogy hány alkalommal fordulnak elő).
  
- Ezután egy ciklust használva a „mindenSzo” tömbön, hogy végigmegy az összes szón. Minden szónál ellenőrzi, hogy az nem szerepel-e a „Kivetelek.KivetelLista()” metódus által visszaadott kivételek listájában, és hogy a szó hossza nagyobb-e mint 1 karakter. Ha mindkét feltétel teljesül, akkor folytatja a feldolgozást.
  
- Ezután létrehoz egy top25Szavak változót, amely a leggyakrabban előforduló 25 szót tartalmazza, rendezve a gyakoriságuk alapján csökkenő sorrendben.

#4
- Egy statikus osztályban, beolvastam a „kotoszavak.txt” -t. Majd vissza adtam egy „KivetelLista” listában.