# 🚀 Plan migracije na ASP.NET Core Web API – Projekat KonstantinSokolov

Ovaj dokument prikazuje kako da postojeću konzolnu aplikaciju preoblikujemo u savremeni RESTful Web API korišćenjem ASP.NET Core.

---

## 🎯 Cilj Web API aplikacije

- Dodavanje i prikaz studenata preko HTTP zahteva
- Vraćanje proseka i uspeha po studentu
- Prikaz svih studenata kao JSON
- Priprema za proširenje (baza, autentifikacija, frontend)

---

## 🧱 Arhitektura Web API verzije

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

Program.cs
Startup.cs (ako koristiš stariju verziju)
```

---

## ⚙️ Koraci implementacije

### 1. Kreiraj novi ASP.NET Web API projekat

```bash
dotnet new webapi -n StudentApi
cd StudentApi
```

### 2. Prebaci modele iz postojećeg koda

Iz foldera `Models` kopiraj `Student.cs` i `Uspeh.cs` u `/Models` Web API projekta.

---

### 3. Napravi `StudentService`

Umesto `StudentApp`, koristi klasu koja rukuje listom studenata:

```csharp
public interface IStudentService
{
    void DodajStudenta(Student student);
    List<Student> VratiSve();
}

public class StudentService : IStudentService
{
    private readonly List<Student> _studenti = new();

    public void DodajStudenta(Student student) => _studenti.Add(student);
    public List<Student> VratiSve() => _studenti;
}
```

Registruj servis u `Program.cs`:

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

    [HttpPost]
    public IActionResult DodajStudenta([FromBody] Student student)
    {
        _servis.DodajStudenta(student);
        return Ok(student);
    }

    [HttpGet]
    public IActionResult VratiSve()
    {
        return Ok(_servis.VratiSve());
    }
}
```

---

### 5. Omogući enum kao string u JSON

```csharp
builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
```

---

## ✅ Dodatne ideje za proširenje

- Validacija pomoću `FluentValidation`
- Dodavanje baze (EF Core + SQLite)
- API testovi (npr. `xUnit + WebApplicationFactory`)
- Frontend deo (Blazor, React, Angular)

---

## 🧪 Testiranje API-ja

Koristi `curl`, `Postman` ili ugrađeni Swagger UI (automatski dostupan na `https://localhost:xxxx/swagger`).

---

## 🏁 Zaključak

Struktura projekta `KonstantinSokolov` je već modularna i idealna za prelazak na Web API.  
Logika ostaje ista – menja se samo način komunikacije (HTTP umesto konzole).