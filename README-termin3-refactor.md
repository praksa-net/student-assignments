# 🔧 Refaktorisanje i unapređenje projekta "Student"

Ovaj dokument sadrži predloge za refaktorisanje i proširenje postojećeg programa koji obrađuje informacije o studentima. Cilj je vežbanje pisanja čistog, organizovanog i proširivog koda koristeći osnovne koncepte C# jezika.

---

## ✅ 1. Izdvajanje logike iz `Main()` u posebnu klasu

**Zadatak:**  
Premesti logiku unosa i ispisa iz `Main()` metode u posebnu klasu (npr. `StudentApp`).

**Primer:**
```csharp
class Program
{
    static void Main(string[] args)
    {
        StudentApp.Pokreni();
    }
}
```

---

## ✅ 2. Odvajanje ispisa u posebnu klasu `StudentPrinter`

**Zadatak:**  
Napravi klasu `StudentPrinter` koja prikazuje podatke o studentu:

```csharp
public static class StudentPrinter
{
    public static void Prikazi(Student s)
    {
        // Console.WriteLine za ime, prezime, ocene itd.
    }
}
```

---

## ✅ 3. Unapređenje unosa brojeva sa `try-catch`

**Zadatak:**  
Napravi metodu (umesto TryParse):
```csharp
int UnesiBroj(string poruka)
```
koja koristi `try-catch` i ponavlja unos dok ne unese validan broj.

---

## ✅ 4. Korišćenje `enum` za uspeh

**Zadatak:**  
Zameni `string` u `OdrediUspeh()` sa `enum Uspeh`.

```csharp
enum Uspeh { Nedovoljan, Dovoljan, Dobar, VrloDobar, Odlican }

public Uspeh OdrediUspeh() { ... }
```

---

## ✅ 5. Uklanjanje višestrukog računanja proseka

**Zadatak:**  
U metodi `OdrediUspeh()`, poziv `IzracunajProsek()` se pojavljuje više puta. Izračunaj jednom, sačuvaj u lokalnu promenljivu.

---

## ✅ 6. Dodavanje testnih (mock) podataka

**Zadatak:**  
Dodaj klasu `StudentFactory` sa metodom:

```csharp
public static Student CreateMockStudent()
```

koja vraća unapred popunjenog studenta (radi bržeg testiranja).

---

## ✅ 7. Unos više studenata

**Zadatak:**  
U `Main()` omogući unos više studenata pomoću `while` petlje, dok korisnik ne unese `"kraj"`. Na kraju ispiši sve unesene studente.

---

## ✅ 8. Snimanje u JSON fajl (BONUS)

**Zadatak:**  
Koristi `System.Text.Json` da serijalizuješ listu studenata u fajl:

```csharp
string json = JsonSerializer.Serialize(listaStudenata);
File.WriteAllText("studenti.json", json);
```

---

## ✅ 9. Validacija praznih stringova

**Zadatak:**  
Proširi `Validator`:

```csharp
public static bool IsNameValid(string input)
{
    return !string.IsNullOrWhiteSpace(input);
}
```

Koristi ovo prilikom unosa imena i prezimena.

---

## ✅ 10. Korišćenje interfejsa (BONUS)

**Zadatak:**  
Napravi interfejs `IStudentPrinter` i klasu `ConsoleStudentPrinter` koja ga implementira.

**Cilj:** Priprema za testiranje ili za zamenu prikaza (npr. fajl, web).

---

## 📁 Predlog organizacije projekta

```
/Models/
  Student.cs
  Uspeh.cs

/Services/
  StudentApp.cs
  Validator.cs

/Utils/
  StudentPrinter.cs
  StudentFactory.cs

Program.cs
```

---