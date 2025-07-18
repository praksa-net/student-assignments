# 🌐 Migracija na ASP.NET Core Web API – Projekat ijustseen

Ovaj vodič pokazuje kako postojeću konzolnu aplikaciju (projekt ijustseen) možeš lako da prevedeš u RESTful Web API pomoću ASP.NET Core.

---

## 🧠 Šta sadrži postojeći projekat?

- `StudentApp` – logika za unos i prikaz studenata
- `Validator` – provera unosa (godina, ocena...)
- `StudentFactory` – generisanje test podataka
- `Student` + `Uspeh` modeli – reprezentacija studenata i njihovog uspeha
- `studenti.json` – fajl za snimanje/čitanje podataka

---

## 🎯 Ciljevi Web API-ja

- Prikaz svih studenata (GET)
- Dodavanje studenta (POST)
- (opciono) Čuvanje u JSON fajl (FileSystem umesto baze)

---

## 📁 Nova struktura Web API projekta

```
/Controllers
    StudentController.cs

/Models
    Student.cs
    Uspeh.cs

/Services
    StudentService.cs
    IStudentService.cs

/Utils
    Validator.cs
    StudentFactory.cs

Program.cs
studenti.json
```

---

## 🧰 Koraci za migraciju

### 1. Kreiraj novi projekat

```bash
dotnet new webapi -n StudentApi
cd StudentApi
```

---

### 2. Kopiraj modele i util klase

- Prebaci `Student.cs`, `Uspeh.cs` u folder `/Models`
- Prebaci `Validator.cs` i `StudentFactory.cs` u `/Utils`

---

### 3. Napravi `StudentService`

```csharp
public interface IStudentService
{
    void DodajStudenta(Student student);
    List<Student> VratiSve();
}

public class StudentService : IStudentService
{
    private readonly List<Student> _studenti;

    public StudentService()
    {
        _studenti = StudentFactory.CreateMockStudents(5);
    }

    public void DodajStudenta(Student student) => _studenti.Add(student);
    public List<Student> VratiSve() => _studenti;
}
```

Registruj ga u `Program.cs`:

```csharp
builder.Services.AddSingleton<IStudentService, StudentService>();
```

---

### 4. Kreiraj `StudentController`

```csharp
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _servis;

    public StudentController(IStudentService servis)
    {
        _servis = servis;
    }

    [HttpGet]
    public IActionResult VratiSve() => Ok(_servis.VratiSve());

    [HttpPost]
    public IActionResult Dodaj([FromBody] Student s)
    {
        _servis.DodajStudenta(s);
        return Ok(s);
    }
}
```

---

### 5. Opcioni deo: rad sa `studenti.json`

Ako želiš da snimaš/čitaš fajl, koristi `System.Text.Json` i `File.WriteAllText/ReadAllText` metode u servisu.

---

## ✅ Sledeći koraci

- Dodaj validaciju u `POST` endpoint
- Dodaj API testove (`xUnit`)
- Dodaj podršku za čuvanje u bazi (`EF Core`)
- Napravi frontend (React, Blazor ili Angular)

---

Ova migracija ti omogućava lakše testiranje, frontend integraciju i kasnije povezivanje sa bazom.