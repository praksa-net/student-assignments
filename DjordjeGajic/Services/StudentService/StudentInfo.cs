using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DjordjeGajic
{
    internal class StudentInfo:IStudentPrinter
    {
        public void PrikazInformacija(Student s)
        {
            Console.WriteLine("Informacije o studentu:");
            PrintName(s.Ime, s.Prezime);
            PrintBirthYear(s.GodinaRodjenja);
            PrintGrades(s.Ocene);
            PrintProsekUspeh(s);
        }

        public void PrintBirthYear(int year)
        {
            Console.WriteLine($"Godina rodjenja: {year}");
        }

        public void PrintGrades(List<int> grades)
        {
            Console.WriteLine("Ocene studenta");
            foreach (int grade in grades)
            {
                Console.Write(grade + " ");
            }
        }

        public void PrintName(string name, string lastname)
        {
            Console.WriteLine($"Ime i prezime: {name} {lastname}");
        }

        public void PrintProsekUspeh(Student s)
        {
            Console.WriteLine($"Prosek i uspeh: {s.IzracunajProsek()} - {s.OdrediUspeh()}");
        }

        public StudentInfo(Student s)
        {
            Console.WriteLine();
            PrikazInformacija(s);
        }
    }
}
