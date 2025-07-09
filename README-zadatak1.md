1. Napravi klasu `Student` koja ima sledeća **svojstva**:
   - `Ime` (string)
   - `Prezime` (string)
   - `GodinaRodjenja` (int)
   - `Ocene` (lista `int`)

2. Dodaj **metode** u klasu:
   - `IzracunajProsek()` – vraća prosečnu ocenu
   - `OdrediUspeh()` – vraća `"Odličan"`, `"Vrlo dobar"`, `"Dobar"`, `"Dovoljan"` ili `"Nedovoljan"` na osnovu proseka

3. U `Main()` metodi:
   - Unesi podatke o studentu (ime, prezime, godina rođenja)
   - Unesi broj ocena i zatim sve ocene (koristeći `for` petlju)
   - Prikazi sve podatke o studentu, uključujući prosek i uspeh

4. Dodaj `static` metodu u posebnu klasu `Validator` koja proverava da li je ocena u dozvoljenom opsegu (1–5).