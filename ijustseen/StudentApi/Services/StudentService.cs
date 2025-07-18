using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

public interface IStudentService
{
    void DodajStudenta(Student student);
    List<Student> VratiSve();
    Student VratiNajboljeg();
    Student VratiNajgoreg();
    void SacuvajUFajl(string filePath = "studenti.json");
    void UcitajIzFajla(string filePath = "studenti.json");
}

public class StudentService : IStudentService
{
    private readonly List<Student> _studenti;
    private readonly string _defaultFile = "studenti.json";

    public StudentService()
    {
        _studenti = StudentFactory.CreateMockStudents(5);
    }

    public void DodajStudenta(Student student) => _studenti.Add(student);
    public List<Student> VratiSve() => _studenti;

    public Student VratiNajboljeg()
    {
        if (_studenti.Count == 0) return null;
        return _studenti.OrderByDescending(s => s.IzracunajProsek()).FirstOrDefault();
    }

    public Student VratiNajgoreg()
    {
        if (_studenti.Count == 0) return null;
        return _studenti.OrderBy(s => s.IzracunajProsek()).FirstOrDefault();
    }

    public void SacuvajUFajl(string filePath = null)
    {
        if (filePath == null) filePath = _defaultFile;
        var options = new JsonSerializerOptions { WriteIndented = true };
        options.Converters.Add(new JsonStringEnumConverter());
        string json = JsonSerializer.Serialize(_studenti, options);
        File.WriteAllText(filePath, json);
    }

    public void UcitajIzFajla(string filePath = null)
    {
        if (filePath == null) filePath = _defaultFile;
        if (!File.Exists(filePath)) return;
        var options = new JsonSerializerOptions();
        options.Converters.Add(new JsonStringEnumConverter());
        string json = File.ReadAllText(filePath);
        var studenti = JsonSerializer.Deserialize<List<Student>>(json, options);
        if (studenti != null)
        {
            _studenti.Clear();
            _studenti.AddRange(studenti);
        }
    }
}