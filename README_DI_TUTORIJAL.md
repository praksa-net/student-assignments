# 🧩 Dependency Injection (DI) – Detaljan vodič za početnike

## 📌 Šta je Dependency Injection?

Dependency Injection (skraćeno DI) je način da **jedna klasa dobije ono što joj treba (zavisnosti)** *iz spoljnog sveta*, umesto da ih sama pravi.

Zamisli da praviš tortu. Ne praviš sam jaja, mleko i šećer – već ih dobijaš. Tako i klasa ne bi trebalo da pravi svoje "sastojke", već da ih dobije.

## ✅ Zašto se koristi?

- **Lakše testiranje** – možeš lako da zameniš pravu klasu lažnom (npr. `MockPrinter`)
- **Manje povezivanja (coupling)** – klase ne znaju tačno *ko* je druga strana
- **Fleksibilniji kod** – lakše menjanje ponašanja

---

## ⚙️ Klasičan (loš) primer – bez DI

```csharp
public class StudentApp
{
    private StudentPrinter printer = new StudentPrinter(); // direktno pravimo printer

    public void Pokreni()
    {
        printer.Stampaj("Zdravo!");
    }
}
```

Ovde `StudentApp` uvek koristi `StudentPrinter`. Ako želimo da štampa u fajl, moramo menjati `StudentApp`.

---

## 🔄 Rucna DI – bolja praksa

```csharp
public class StudentApp
{
    private IPrinter _printer;

    public StudentApp(IPrinter printer)  // U konstruktor ubacujemo zavisnost
    {
        _printer = printer;
    }

    public void Pokreni()
    {
        _printer.Stampaj("Zdravo!");
    }
}
```

Sada možemo lako da promenimo kako štampamo:

```csharp
var app = new StudentApp(new ConsolePrinter());
app.Pokreni();
```

Ili:

```csharp
var app = new StudentApp(new FilePrinter("output.txt"));
```

Ovo je **rucna injekcija** – sve povezujemo sami.

---

## 🧰 DI kontejner – automatska injekcija

Ako imamo više klasa koje zavise jedna od druge, teško je sve ručno povezivati. Zato koristimo **DI kontejner** – sistem koji automatski pravi i povezuje objekte.

Koristimo biblioteku:

```bash
dotnet add package Microsoft.Extensions.DependencyInjection
```

### 🧪 Primer

```csharp
// 1. Interfejs i klase
public interface IPrinter
{
    void Stampaj(string poruka);
}

public class ConsolePrinter : IPrinter
{
    public void Stampaj(string poruka) => Console.WriteLine(poruka);
}
```

```csharp
// 2. Aplikacija koja koristi printer
public class StudentApp
{
    private readonly IPrinter _printer;

    public StudentApp(IPrinter printer)
    {
        _printer = printer;
    }

    public void Pokreni()
    {
        _printer.Stampaj("Ćao iz DI sveta!");
    }
}
```

```csharp
// 3. Program.cs
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IPrinter, ConsolePrinter>();
services.AddTransient<StudentApp>();

var provider = services.BuildServiceProvider();
var app = provider.GetRequiredService<StudentApp>();
app.Pokreni();
```

---

## 🧠 Razlika: ručno vs DI kontejner

| Ručno | DI kontejner |
|-------|--------------|
| Moraš sve sam da povezuješ | Automatizuje povezivanje klasa |
| Dobro za male projekte | Idealno za veće aplikacije |
| Veća kontrola | Manje pisanja koda |

---

## 🧩 Vrste "životnog veka" objekta u DI kontejneru

Kada registruješ klasu, moraš reći DI kontejneru koliko dugo da "pamti" objekat.

### 1. `Singleton`  
– Kreira se **jedan** objekat za ceo program.  
– Koristi se kada nešto treba da bude globalno, npr. logovanje.

```csharp
services.AddSingleton<ILogger, ConsoleLogger>();
```

### 2. `Transient`  
– Svaki put kada se traži, pravi se **novi** objekat.  
– Idealno za lagane objekte, koji ne čuvaju stanje.

```csharp
services.AddTransient<IPrinter, ConsolePrinter>();
```

### 3. `Scoped`  
– Kreira se jedan objekat **po zahtevu** (npr. po HTTP zahtevu u web aplikacijama).  
– Manje se koristi u konzolnim aplikacijama, ali je važan za ASP.NET Core.

```csharp
services.AddScoped<IMojaServis, MojaServisImplementacija>();
```

---

## 🏁 Zaključak

- DI znači da **klasa ne pravi ono što koristi**, već to dobije spolja.
- Ručna DI je dobra za učenje.
- DI kontejner automatski povezuje klase za tebe.
- Singleton, Transient i Scoped određuju koliko puta se objekat pravi.

Ovo je jedan od najvažnijih principa u razvoju softvera, posebno u većim timovima i aplikacijama.