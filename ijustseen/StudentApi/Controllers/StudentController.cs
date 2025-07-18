using Microsoft.AspNetCore.Mvc;

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

    [HttpGet("najbolji")]
    public IActionResult VratiNajboljeg()
    {
        var najbolji = _servis.VratiNajboljeg();
        if (najbolji == null) return NotFound("Nema studenata.");
        return Ok(najbolji);
    }

    [HttpGet("najgori")]
    public IActionResult VratiNajgoreg()
    {
        var najgori = _servis.VratiNajgoreg();
        if (najgori == null) return NotFound("Nema studenata.");
        return Ok(najgori);
    }

    [HttpPost]
    public IActionResult Dodaj([FromBody] Student s)
    {
        // Валидация
        if (s == null || string.IsNullOrWhiteSpace(s.Ime) || string.IsNullOrWhiteSpace(s.Prezime) || s.GodinaRodjenja < 1900 || s.GodinaRodjenja > 2025 || s.Ocene == null || s.Ocene.Length == 0 || s.Ocene.Any(o => o < 1 || o > 5))
        {
            return BadRequest("Neispravni podaci o studentu. Proverite ime, prezime, godinu rođenja (1900-2025) i ocene (1-5)." );
        }
        _servis.DodajStudenta(s);
        return Ok(s);
    }

    [HttpPost("sacuvaj")]
    public IActionResult SacuvajUFajl([FromQuery] string file = null)
    {
        _servis.SacuvajUFajl(file);
        return Ok("Studenti su sačuvani u fajl.");
    }

    [HttpPost("ucitaj")]
    public IActionResult UcitajIzFajla([FromQuery] string file = null)
    {
        _servis.UcitajIzFajla(file);
        return Ok("Studenti su učitani iz fajla.");
    }
}