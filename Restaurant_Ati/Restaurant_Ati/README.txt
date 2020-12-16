Információs rendszerek fejlesztése
Beadandó projektfeladat - Restaurant_Ati Namespace-el
2020/Őszi félév

Salamon Attila
ir0m54

Projekthez szükséges funkciók:
- XML feldolgozás (fájlból, vagy webszolgáltatásból) >> fájlból
-Adott tulajdonságú elemek törlése egy listából
- Írás CSV fájlba
- Enumeráció
	Több fajta megvalósításon is gondolkodtam, kezdetben autók alkatrészeivel, brandj-jével kapcsolatban program létrehozása, de aztán adatok hiányában végül egy éttermes program mellett döntöttem, amihez a 11 DB XML fájl én hoztam létre.

Restaurant.xml-ben 10 db étterem szerepel a tulajdonságaikkal, a kódban és a fájlokban is látható lesz (pl.Name, feedback, stb)
Mindegyik étteremhez tartozik egy heti menü (Egy napon lehet "A" és "B" menü közül választani), a választék éttermenként jelenik meg
A programomban adatok hiányában, csak egy hét menüjét jelenítem meg, azonban a programot tovább lehetne fejleszteni, hogy a megfelelő adatok birtokában, mindig az adott heti adatokat jelenítse meg

Ezt a részt volt a legnehezebb számomra megcsinálni, hiszen a XML beolvasásával mindig hibákba ütköztem és át kellett több oldal dokumentáción szenvednem magamat, mire végre müködőképes lett a program.
	Az aktuálisan kiválasztott étterem adatait egy button segitségével törölni lehet egyszerre a textboxokbol, ahol a menü jelenik meg és a comboBox-ból is, utána már csak a maradék étterem közül lehet választani.
	CSV fájl kiírást kétféle button-nel valósítottam meg. Az egyikben az aktuálisan kiválasztott étterem adatait tudjuk egy CSV-fájlba kiírni, a másikkal pedig mindig látható button-nel pedig az összes étterem adatát, amit az xml-ből ki tudunk nyerni, azokat ki tudjuk egy CSV-fájlba exportálni
	Az Enumerációt a feedbackekkel kapcsolatban hoztam létre, és a kódban használtam is a létrehozott enumot.


