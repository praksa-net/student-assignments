
## ✨ Predlozi za refaktorisanje

| Problem | Predlog |
|--------|---------|
| `Console.ReadLine()` je direktno u `Student` i `Validator` 
| Odvojiti logiku unosa u posebnu klasu `InputService` 
|
| `Student` ima previše odgovornosti (unos, logika, prikaz) 
| Zadržati samo podatke i metode za izračunavanje (prosek, uspeh) 
|
| `Validator` ima i `Console.WriteLine()` | Validacija treba da bude nezavisna, bez ispisa 
|
| Nema provere za prazno ime, nevalidnu godinu, negativne ocene 
| Dodati dodatne validacije i poruke za greške |

---

## 🚀 Predlog za unapređenja

1. **Dodavanje više studenata** – Korisnik može unositi više studenata u listu.
2. **Ispis svih studenata** – Prikaz liste sa prosekom i uspehom.
3. **Čuvanje u fajl** – JSON ili CSV fajl sa podacima o studentima.
4. **Testiranje sa xUnit** – Npr. `Assert.Equal(4.0, student.IzracunajProsek());`
5. **Korišćenje `enum Uspeh` na bolji način** – Prevod vrednosti u string za ispis.

---
