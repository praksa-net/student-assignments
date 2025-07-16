# 📘 Refaktorisanje i Nadogradnja: Projekat MileMacin

Ovaj dokument sadrži predloge za refaktorisanje koda i dodatni zadatak za proširenje funkcionalnosti.

---

## ✅ Refaktorisanje – Predlozi

### 🔧 1. Spoji `Prosek_I_Uspeh.cs` u `Student.cs`

Metode za izračunavanje proseka i određivanje uspeha treba da budu u samoj klasi `Student`.

**Primer:**

_Pre:_
```csharp
public static double IzracunajProsek(Student s) { ... }
```

_Posle:_
```csharp
public double IzracunajProsek() { ... }
```

---

### 🔧 2. Preimenuj `Ocene.cs` u `OcenaValidator.cs`

Fajl sadrži validaciju ocena, pa ime treba da odražava tu funkcionalnost.

```csharp
public static class OcenaValidator
```

---

### 🔧 3. Podeli `StudentApp.cs`

`StudentApp` trenutno obavlja sve (unos, obrada, ispis). Predlog je da se podeli na:

- `StudentInputService` – za unos
- `StudentProcessor` – za računanje proseka i uspeha
- `StudentPrinter` – za ispis

---

### 🔧 4. Koristi interfejse za ispis

Zameni `Console.WriteLine()` sa interfejsom `IPrinter`. Tako omogućavaš testiranje i lakši prelazak na druge UI sisteme (npr. Web API).

```csharp
public interface IPrinter
{
    void Ispisi(string tekst);
}
```

---

### 🔧 5. Dodaj `ToString()` u klasu `Student`

Omogući ispis studenta direktno:

```csharp
public override string ToString()
{
    return $"{Ime} {Prezime} - {IzracunajProsek():0.00} - {OdrediUspeh()}";
}
```

---

## 🚀 Dodatni zadatak: Više studenata

### 🎯 Cilj

- Omogućiti unos više studenata
- Prikaz svih studenata
- Prikaz najboljeg i najgoreg po proseku

### 🔨 Koraci

1. Dodaj listu:
```csharp
List<Student> studenti = new List<Student>();
```

2. Omogući unos više studenata:
```csharp
while (true)
{
    Console.WriteLine("Unesi ime studenta ili 'kraj': ");
    string ime = Console.ReadLine();
    if (ime.ToLower() == "kraj") break;

    // ostali podaci...
}
```

3. Ispis svih studenata:
```csharp
foreach (var s in studenti)
    Console.WriteLine(s);
```

4. Najbolji student:
```csharp
var najbolji = studenti.OrderByDescending(s => s.IzracunajProsek()).FirstOrDefault();
Console.WriteLine($"Najbolji student: {najbolji}");
```

---

## 🧠 BONUS: Priprema za Web API

Strukturom `Model + Service + IO`, tvoj kod postaje pogodan za korišćenje u ASP.NET Web API aplikaciji.

---

Srećno sa refaktorisanje i nadogradnjom! 🚀