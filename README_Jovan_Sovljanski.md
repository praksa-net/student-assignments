# 📘 Refaktorisanje i Unapređenje: Projekat ConsoleApp1

Ovaj vodič sadrži predloge za poboljšanje koda i ideju za dodatno proširenje zadatka.

---

## ✅ Predlozi za refaktorisanje

### 🔧 1. Uklanjanje logike iz `Program.cs`

Trenutno se sav posao odvija direktno u `Program.cs`. Preporučuje se:
- kreiranje klase `StudentApp` koja sadrži glavnu logiku
- `Program.cs` treba da samo pokrene `StudentApp.Run()`

---

### 🔧 2. Razdvoj odgovornosti

**Trenutno stanje:** Klasa `Student` ima metode i za unos i za izračunavanje proseka.

**Predlog:**
- Klasa `Student` čuva podatke
- Nova klasa `StudentProcessor` – metode `IzracunajProsek`, `OdrediUspeh`
- Nova klasa `StudentInput` – sve što koristi `Console.ReadLine()`

---

### 🔧 3. Validacija ocena

Trenutno nema posebnog validatora ocena. Dodaj klasu `OcenaValidator.cs`:

```csharp
public static class OcenaValidator
{
    public static bool IsValid(int ocena) => ocena >= 1 && ocena <= 5;
}
```

---

### 🔧 4. `IspisStudenta` kao servis

Metode za ispis treba da se pozivaju preko interfejsa:

```csharp
public interface IPrinter
{
    void Prikazi(Student student);
}
```

Omogućava testiranje i laku zamenu (npr. Web vs Console).

---

### 🔧 5. Enum `Uspeh` može imati [Description] anotacije

Za čitljiviji ispis korisniku:

```csharp
public enum Uspeh
{
    [Description("Odličan")]
    Odlican,
    ...
}
```

---

## 🚀 Dodatni zadatak: Analiza grupe studenata

### 🎯 Cilj

Omogućiti unos više studenata i analizirati njihove uspehe.

### 🔨 Koraci

1. Dodaj listu:
```csharp
List<Student> studenti = new List<Student>();
```

2. Petlja za unos:
```csharp
while (true)
{
    Console.WriteLine("Unesite ime ili 'kraj':");
    string ime = Console.ReadLine();
    if (ime == "kraj") break;
    ...
}
```

3. Ispis svih studenata:
```csharp
foreach (var s in studenti)
    Console.WriteLine(s);
```

4. Analiza uspeha:
- Prosečan prosek cele grupe
- Broj odličnih, vrlo dobrih itd.

```csharp
var prosecnaOcena = studenti.Average(s => s.IzracunajProsek());
var brojOdlicnih = studenti.Count(s => s.OdrediUspeh() == Uspeh.Odlican);
```

---

## 💡 Bonus: Priprema za Web API

Refaktorisani kod sa servisima i interfejsima omogućava laku migraciju u ASP.NET API projekat.

---

Srećno sa refaktorisanje i nadogradnjom! 🚀