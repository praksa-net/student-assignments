# 🧪 xUnit Testiranje – Prvi koraci

## 📌 Šta je testiranje?
Testiranje znači da automatski proveravaš da li tvoj program radi ispravno. Umesto da ti ručno unosiš podatke i čitaš rezultat – pišeš test koji to uradi za tebe.

## 🤖 Šta je xUnit?

xUnit je alat za pisanje i pokretanje testova u C# aplikacijama.

## 🔧 Instalacija

U terminalu (unutar foldera projekta) pokreni:

```
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
dotnet add package Microsoft.NET.Test.Sdk
```

## ✍️ Primer testiranja proseka studenta

### Kod koji testiramo:

```csharp
public class Student
{
    public int[] Ocene;

    public double IzracunajProsek()
    {
        if (Ocene == null || Ocene.Length == 0) return 0;
        return Ocene.Average();
    }
}
```

### Test za to:

```csharp
using Xunit;

public class StudentTests
{
    [Fact]
    public void IzracunajProsek_VracaOcekivaniProsek()
    {
        var student = new Student();
        student.Ocene = new int[] { 4, 5, 3 };

        double prosek = student.IzracunajProsek();

        Assert.Equal(4.0, prosek, 1); // očekujemo 4.0, sa tolerancijom
    }
}
```

## 🧪 Šta znače `[Fact]` i `Assert.Equal()`?
- `[Fact]` označava da je to test metoda.
- `Assert.Equal(ocekivano, stvarno)` proverava da li su vrednosti iste.

## ▶️ Kako pokrećemo testove?

Pokreni u terminalu:

```
dotnet test
```

Dobićeš izveštaj: koji test je prošao, koji nije.

## 📌 Zašto je ovo korisno?

- Ne moraš da ručno testiraš svaki put.
- Ako nešto pokvariš u kodu – test će odmah reći.
- Programi u firmama često imaju i po 10.000 testova.

---

**xUnit** ti pomaže da pišeš sigurniji i pouzdaniji kod.
Vežbom će ti postati logično i jednostavno. Počni od malih testova i korak po korak napreduj.