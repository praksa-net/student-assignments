using KonstantinSokolov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinSokolov.Utils
{
    internal class StudentFactory
    {
        public static Student CreateMockStudent()
        {
            return new Student
            {
                Ime = "Marko",
                Prezime = "Markovic",
                GodinaRodjenja = 2000,
                Ocene = new List<int> { 5, 4, 3, 5, 4 }
            }; 
        }
        public static List<Student> CreateMockStudents(int count)
        {
            var list = new List<Student>();
            for (int i = 1; i <= count; i++)
            {
                list.Add(new Student
                {
                    Ime = $"Student{i}",
                    Prezime = $"Prezime{i}",
                    GodinaRodjenja = 1995 + i % 10,
                    Ocene = new List<int> { 2 + i % 4, 3 + (i + 1) % 3, 5 }
                });
            }
            return list;
        }
    }
}
