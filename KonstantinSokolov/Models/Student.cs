using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinSokolov.Models
{
    public class Student
    {
        public string Ime;
        public string Prezime;
        public int GodinaRodjenja;
        public List<int> Ocene;

        public Student()
        {
            Ime = string.Empty;
            Prezime = string.Empty;
            GodinaRodjenja = 0;
            Ocene = new List<int>();
        }
        public Student(string ime, string prezime, int godinaRodjenja, List<int> ocene)
        {
            Ime = ime;
            Prezime = prezime;
            GodinaRodjenja = godinaRodjenja;
            Ocene = ocene;
        }


        public double IzracunajProsek()
        {
            if (Ocene.Count == 0) return 0;
            return Ocene.Average();
        }


        public Uspeh OdrediUspeh()
        {
            var prosek = IzracunajProsek();
            if (prosek >= 4.5f) return Uspeh.Odlican;
            if (prosek >= 3.5f) return Uspeh.VrloDobar;
            if (prosek >= 2.5f) return Uspeh.Dobar;
            if (prosek >= 1.5f) return Uspeh.Dovoljan;
            return Uspeh.Nedovoljan;
        }
    }
}
