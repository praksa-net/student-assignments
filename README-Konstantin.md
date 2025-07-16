# Student Management Console App

Ova aplikacija omogućava unos, validaciju i prikaz podataka o studentima kroz konzolni interfejs. Podaci se mogu prikazivati u različitim formatima: tekstualno (console) ili JSON. Sistem podržava kreiranje mock podataka i pisanje podataka u fajl.

## 🧱 Struktura projekta

```
/Models
    Student.cs
    Uspeh.cs

/Services
    /Printers
        IStudentPrinter.cs
        StudentConsolePrinter.cs
        StudentJsonPrinter.cs
    StudentApp.cs
    StudentInputService.cs

/Utils
    Validator.cs
    StudentFactory.cs

Program.cs
```

---

## 🚀 Pokretanje aplikacije

U `Program.cs` se koristi `StudentApp.Run()` metoda za pokretanje aplikacije. Primer:

```csharp
var consolePrinter = new StudentConsolePrinter();
StudentApp.Run(printer: consolePrinter, useMocks: false);
```

---

## 🧩 Dependency Injection (DI)

**Dependency Injection** je obrazac dizajna koji omogućava bolju fleksibilnost i testabilnost aplikacije tako što zavisnosti (npr. `IStudentPrinter`) ne instancira direktno klasa već ih dobija "spolja".

Umesto:

```csharp
var printer = new StudentConsolePrinter();
```

Koristimo DI kontejner da registrujemo i automatski dobavimo zavisnosti.

### 🔧 Kako koristiti DI preko `Microsoft.Extensions.DependencyInjection`

1. Instaliraj NuGet paket:

```bash
dotnet add package Microsoft.Extensions.DependencyInjection
```

2. Konfiguriši DI u `Program.cs`:

```csharp
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IStudentPrinter, StudentConsolePrinter>();
services.AddSingleton<StudentApp>();

var provider = services.BuildServiceProvider();
var app = provider.GetRequiredService<StudentApp>();
app.Run(useMocks: false);
```

3. Ukloni `static` iz `StudentApp.Run()` i koristi instancu kao gore.

---

## 🧪 Testiranje sa xUnit

[xUnit](https://xunit.net/) je popularni framework za unit testiranje u .NET-u.

### ✅ Instalacija

Dodaj xUnit i .NET runner:

```bash
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
dotnet add package Microsoft.NET.Test.Sdk
```

### 🧪 Primer test klase

```csharp
using Xunit;
using KonstantinSokolov.Models;

public class StudentTests
{
    [Fact]
    public void IzracunajProsek_VracaTacanProsek()
    {
        var student = new Student("Ana", "Jovanovic", 2001, new List<int> { 5, 4, 3 });
        double prosek = student.IzracunajProsek();
        Assert.Equal(4.0, prosek, precision: 1);
    }

    [Theory]
    [InlineData(4.8, Uspeh.Odlican)]
    [InlineData(3.6, Uspeh.VrloDobar)]
    [InlineData(2.6, Uspeh.Dobar)]
    public void OdrediUspeh_VracaOcekivaniUspeh(double prosek, Uspeh ocekivani)
    {
        var student = new Student("Test", "Test", 2000, new List<int>());
        student.Ocene = Enumerable.Repeat((int)Math.Round(prosek), 5).ToList();
        Assert.Equal(ocekivani, student.OdrediUspeh());
    }
}
```

### ▶️ Pokretanje testova

Pokreni testove iz terminala:

```bash
dotnet test
```

---

## 📌 Moguća proširenja

- UI (WinForms, WPF ili Blazor)
- Čuvanje i učitavanje iz CSV ili baze podataka
- Bolja logika za rukovanje greškama
- API sloj (npr. ASP.NET Web API)

---

## 📞 Kontakt

Autor: *Konstantin Sokolov (primer)*