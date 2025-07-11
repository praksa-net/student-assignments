using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KonstantinSokolov.Services.Printers
{
    public class StudentJsonPrinter : IStudentPrinter
    {
        private readonly string _filePath;
        public StudentJsonPrinter(string filePath = "students.json")
        {
            _filePath = filePath;
        }

        public void Prikazi(Models.Student student)
        {
            try
            {
                var json = JsonSerializer.Serialize(student, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(_filePath, json);
                Console.WriteLine($"Student je uspešno sačuvan u fajl {_filePath}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Greška pri čuvanju studenta u fajl: {ex.Message}");
            }
        }
        public void PrikaziListu(IEnumerable<Models.Student> studenti)
        {
            try
            {
                var json = JsonSerializer.Serialize(studenti, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(_filePath, json);
                Console.WriteLine($"Lista studenata je uspešno sačuvana u fajl {_filePath}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Greška pri čuvanju liste studenata u fajl: {ex.Message}");
            }
        }
    }
}
