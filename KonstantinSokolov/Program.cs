using System;

namespace KonstantinSokolov
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();


            Console.WriteLine("Unesite ime studenta:");
            student1.Ime = Console.ReadLine();
            Console.WriteLine("Unesite prezime studenta:");
            student1.Prezime = Console.ReadLine();

            Console.WriteLine("Unesite godinu rođenja studenta:");
            int godinaRodjenja;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out godinaRodjenja) && Validator.IsYearOfBirthCorrect(godinaRodjenja))
                {
                    student1.GodinaRodjenja = godinaRodjenja;
                    break;
                }
                Console.WriteLine("Neispravna godina rođenja. Pokušajte ponovo:");
            }

            Console.WriteLine("Unesite ocene studenta. Unesite end da biste stali");
            List<int> ocene = new List<int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                    break;
                if (int.TryParse(input, out int ocena) && Validator.IsGradeCorrect(ocena))
                {
                    ocene.Add(ocena);
                }
                else
                {
                    Console.WriteLine("Neispravna ocena. Pokušajte ponovo:");
                }
            }


            Console.WriteLine($"Ime: {student1.Ime}");
            Console.WriteLine($"Prezime: {student1.Prezime}");
            Console.WriteLine($"Godina rođenja: {student1.GodinaRodjenja}");
            Console.WriteLine("Ocene: " + string.Join(", ", student1.Ocene));

            Console.WriteLine($"Prosek ocena: {student1.IzracunajProsek()}");
            Console.WriteLine($"Uspeh: {student1.OdrediUspeh()}");

        }
    }

    class Student
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
        public float IzracunajProsek()
        {
            if (Ocene == null || Ocene.Count == 0)
                return 0;

            float suma = 0;
            foreach (int ocena in Ocene)
            {
                suma += ocena;
            }
            return suma / Ocene.Count;
        }

        public string OdrediUspeh()
        {
            if(IzracunajProsek() >= 4.5)
            {
                return "Odlican";
            }
            else if (IzracunajProsek() >= 3.5)
            {
                return "Vrlo dobar";
            }
            else if (IzracunajProsek() >= 2.5)
            {
                return "Dobar";
            }
            else if(IzracunajProsek() >= 1.5)
            {
                return "Dovoljan";
            }
            else
            {
                return "Nedovoljan";
            }
        }
    }
    class Validator
    {
        public static bool IsGradeCorrect(int grade)
        {
            return grade >= 1 && grade <= 5;
        }
        public static bool IsYearOfBirthCorrect(int year)
        {
            int currentYear = DateTime.Now.Year;
            return year > 1900 && year <= currentYear;
        }
    }
}
