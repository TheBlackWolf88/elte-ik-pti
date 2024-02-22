A Föld hidrológiai körfolyamatában a különböző földterületek befolyásolják az időjárást az időjárások
hatására pedig megváltozik egy földterület fajtája. Egy földterületnek a fajtáján (puszta, zöld,
mocsaras) kívül ismert a neve, és a tárolt vízmennyisége (km3-ben). A földterületek feletti közös
levegőnek ismert a páratartalma.
Az időjárás a levegő aznapi páratartalmától függ:
• 70% felett esős lesz, és ilyenkor a páratartalom lecsökken 30%-ra
• 40% alatt napos lesz
• 40 és 70% között felhős vagy esős: az utóbbi esélye (páratartalom-40)*3,3 százalék
Az egyes földterületek – a megadásuk sorrendjében – reagálnak az időjárásra: változik a
vízmennyiségük, és ez alapján módosítják a levegő páratartalmát, és változhat a felszínük.
• Puszta: a levegő páratartalmát 3%-kal növeli. Napos időben a vízmennyisége 3 km3-rel
csökken, felhős időben 1 km3-rel, esőben 5km3-rel nő. 15 km3-nél magasabb vízmennyiség
mellett a terület zölddé válik.
• Zöld: a levegő páratartalmát 7%-kal növeli. Napos időben a vízmennyisége 6 km3-rel csökken,
felhős időben 2 km3-rel, esőben 10 km3-rel nő. A terület 50 km3 feletti vízmennyiség esetén
mocsarassá; 16 km3 alatt pusztává változik.
• Mocsaras: a levegő páratartalmát 10%-kal növeli. Napos időben a vízmennyisége 10 km3-rel
csökken, felhős időben 3 km3-rel, esőben 15km3-rel nő. 51 km3 alatti vízmennyiség esetén a
terület zölddé változik.
Készítsen használati eset diagramot, ahol a légkör és egy terület szempontjából lényeges eseteket,
valamint ezek kapcsolatát ábrázolja. Adjon meg olyan szekvencia diagramot, amely a légkör és egy
terület közötti kommunikációban érintett metódusokat mutatja meg. Rajzolja fel a légkör időjárásának
és egy terület felszínének állapotgép diagramját! Készítse el az osztály diagramot! Használjon állapot
és látogató tervezési mintákat.
Implementálja a modellt, és oldja meg az alábbi feladatot: Adjuk meg 10 kör után a legvizesebb
földterület nevét vízmennyiségével együtt! Körönként mutassuk meg a földterületek összes
tulajdonságát!
A program egy szövegfájlból olvassa be az adatokat! Ennek első sora a földterületek feletti levegő
kezdeti páratartalmát adja meg (természetes szám). A következő sorok tartalmazzák a földterületek
adatait szóközökkel elválasztva (egy sor – egy terület): a terület nevét (szóköz nélküli sztring), fajtáját
(egy karakter azonosítja: p - puszta, z - zöld, t - tavas), és a kezdeti vízmennyiségét. A program kérje be
a fájl nevét, majd jelenítse is meg a tartalmát. (Feltehetjük, hogy a fájl formátuma helyes.) Egy
lehetséges bemenet:
