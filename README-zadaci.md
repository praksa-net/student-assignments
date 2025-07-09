# 🧠 Zadaci za vežbu – Osnovni C# koncepti i kontrola toka

Ovi zadaci prate metode iz primera u `Program.cs` i služe kao praktične vežbe za početnike.

---

## 🔹 `hello()`
**Zadatak:**  
Napiši metodu koja pozdravlja korisnika sa porukom:  
`Zdravo, [ime]!` gde se ime unosi sa tastature.

🧩 *Cilj:* Vežba sa metodama, rad sa stringovima i `Console.ReadLine`.

---

## 🔹 `variablesAndConstants()`
**Zadatak:**  
Deklariši sledeće promenljive i konstante:
- `string` za ime
- `int` za broj godina
- `const double` za broj Pi

Ispiši ih na ekranu.

✍️ *Zamka:* Pokušaj da promeniš `const` i objasni grešku.

---

## 🔹 `overflowing()`
**Zadatak:**  
Kreiraj `byte` sa vrednošću `255`, dodaj 1 i ispiši rezultat.  
Zatim koristi `checked` blok i uporedi ponašanje.

```csharp
checked
{
    byte b = 255;
    b += 1; // Šta se dešava ovde?
}
```

🧩 *Cilj:* Razumevanje overflow-a i zaštite pomoću `checked`.

---

## 🔹 `scope()`
**Zadatak:**  
Deklariši `int x = 10` u spoljašnjem bloku.  
Unutar unutrašnjeg bloka dodaj `int y = 20` i ispiši oba.  
Zatim pokušaj da ispišeš `y` van tog unutrašnjeg bloka.

🧩 *Zamka:* Promenljive postoje samo unutar svog opsega (`scope`).

---

## 🔹 `typeConversion()`
**Zadatak:**  
Napravi `int` promenljivu i automatski je dodeli `double`-u.  
Zatim pretvori nazad u `int` (eksplicitna konverzija).

✍️ *Zamka:* Probaj sa `double` vrednošću 10.9 – da li se decimalni deo gubi?

---

## 🔹 `operators()`
**Zadatak:**  
Unesi dva broja i primeni:
- Zbir (`+`)
- Razliku (`-`)
- Količnik (`/`)
- Proizvod (`*`)
- Ostatak pri deljenju (`%`)

🧩 *Cilj:* Razumevanje osnovnih aritmetičkih operatora.

---

## 🔹 `logicalOperators()`
**Zadatak:**  
Unesi dve `bool` vrednosti (npr. `true`, `false`) i proveri:
- `x && y`
- `x || y`
- `!x`

✍️ *Zamka:* Probaj da kombinuješ uslove u `if` izrazu.

---

## 🔹 `ifExample()`
**Zadatak:**  
Unesi broj i ispiši `"Broj je veći od 5"` samo ako je uslov tačan.

🧩 *Cilj:* Razumevanje jednostavne uslovne logike.

---

## 🔹 `ifElseExample()`
**Zadatak:**  
Unesi broj i proveri da li je paran ili neparan.

✍️ *Zamka:* Dodaj proveru ako je broj 0 da ispiše `"Broj je nula"`.

---

## 🔹 `switchExample()`
**Zadatak:**  
Unesi broj 1–7 i pomoću `switch` ispisi koji je to dan u nedelji.

🧩 *Zamka:* Dodaj `default` blok koji hvata nevažeće unose.

---

## 🔹 `whileLoopExample()`
**Zadatak:**  
Korisnik unosi šifru sve dok ne unese `"1234"`.  
Ispiši `"Pristup dozvoljen"` kad unese tačnu vrednost.

✍️ *Zamka:* Ograniči broj pokušaja na 3 – koristi brojač.

---

## 🔹 `forLoopExample()`
**Zadatak:**  
Pomoću `for` petlje ispiši brojeve od 1 do 10.  
Zatim izmeni da ispisuje samo **parne brojeve**.

🧩 *Cilj:* Ponavljanje uz kontrolu toka pomoću `if`.

---

## 🔹 `foreachLoopExample()`
**Zadatak:**  
Napravi niz imena i pomoću `foreach` ispiši svako ime.  
Zatim filtriraj i ispiši samo ona koja imaju više od 4 slova.

✍️ *Zamka:* Možeš kombinovati `foreach` sa `if`.

---

## 🎯 BONUS kombinovani zadaci

### 🔸 Kombinacija petlje + uslov:
Napravi niz celih brojeva i ispiši **samo one koji su deljivi sa 3**.

### 🔸 Konverzija + uslov:
Unesi decimalni broj, konvertuj u `int`, pa proveri da li je paran.

### 🔸 Analiza stringova:
Unesi niz imena i ispiši samo ona koja počinju na slovo `A`.

---

✔️ Preporuka: učenici mogu praviti nove metode za svaki zadatak da uvežbaju organizaciju koda (`void` metode sa dobrim imenima).