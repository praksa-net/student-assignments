# 🎓 Vodič za projekat: Student Menadžment Aplikacija

Dobrodošao/la u mini projekat koji simulira unos i obradu studentskih podataka kroz konzolnu C# aplikaciju.

Ovaj projekat ti pomaže da:
- vežbaš rad sa klasama, metodama i enumeracijama,
- primeniš osnovne principe OOP-a (enkapsulacija, razdvajanje odgovornosti),
- koristiš kolekcije (`List<T>`),
- obradiš unos korisnika i prikažeš rezultate.

---

## 🗂️ Struktura projekta

```
/Models
    Student.cs        - Klasa koja predstavlja studenta (ime, prezime, godine, ocene)
    Uspeh.cs          - Enumeracija uspeha (Odličan, VrloDobar...)

/Utils
    StudentFactory.cs - Kreira nove ili testne studente, unosi ocene
    StudentPrinter.cs - Prikazuje informacije o studentima u konzoli
    Validator.cs      - Proverava validnost unosa i ocena

Program.cs           - Ulazna tačka aplikacije
```

---

## ▶️ Kako da koristiš aplikaciju

1. Pokreni aplikaciju (`F5` ili `dotnet run`).
2. Aplikacija će te tražiti da unosiš ime, prezime, godinu rođenja i ocene.
3. Kada napišeš `"kraj"` kao ime, unos se prekida.
4. Na kraju se prikazuje prvi student i broj ukupnih studenata.

---

## 🧪 Sledeći korak: Testiranje sa xUnit (opciono)

xUnit je framework za automatsko testiranje. Omogućava da proveriš da li tvoje metode vraćaju očekivane rezultate.

### ✅ Instalacija:
```bash
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
dotnet add package Microsoft.NET.Test.Sdk
```

### 🧪 Primer testa:
```csharp
[Fact]
public void IzracunajProsek_VracaTacanProsek()
{
    var student = new Student("Ana", "Petrovic", 2005) {
        Ocene = new int[] { 5, 4, 3 }
    };
    var prosek = student.IzracunajProsek();
    Assert.Equal(4.0, prosek);
}
```

Testove pokrećeš sa:
```bash
dotnet test
```

---

## 💡 Predlozi za dalje:

- Izdvoj unos korisnika iz klasa (`Console.ReadLine`) u posebnu klasu `InputService`.
- Napravi fajl printer koji čuva studente u JSON fajl.
- Dodaj validaciju godina rođenja.
- Prikaz statistike: najviši prosek, broj odličnih studenata, itd.

---

## 📌 Cilj projekta

Ovaj projekat ti pomaže da uvežbaš osnovne koncepte objektno-orijentisanog programiranja, da strukturiraš aplikaciju i da pišeš kod koji se lako održava i proširuje.

Srećno! 🚀