using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinSokolov.Services.Printers
{
    public class StudentConsolePrinter : IStudentPrinter
    {
        public void Prikazi(Models.Student student)
        {
            Console.WriteLine($"Ime: {student.Ime}");
            Console.WriteLine($"Prezime: {student.Prezime}");
            Console.WriteLine($"Godina rođenja: {student.GodinaRodjenja}");
            Console.WriteLine("Ocene: " + string.Join(", ", student.Ocene));
            Console.WriteLine($"Prosek ocena: {student.IzracunajProsek()}");
            Console.WriteLine($"Uspeh: {student.OdrediUspeh()}");
            Console.WriteLine(new string('-', 20));
        }
        public void PrikaziListu(IEnumerable<Models.Student> studenti)
        {
            Console.WriteLine("Lista studenata:");
            foreach (var student in studenti)
            {
                Prikazi(student);
            }
        } 
    }
}
