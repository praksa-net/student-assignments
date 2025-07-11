using KonstantinSokolov.Models;
using KonstantinSokolov.Services.Printers;
using KonstantinSokolov.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinSokolov.Services
{
    public class StudentApp
    {

        public static void Run(IStudentPrinter printer, bool useMocks = false)
        {


            List<Student> students;

            if (useMocks)
            {
                students = StudentFactory.CreateMockStudents(5);
                Console.WriteLine("Korišćenje mock studenata:");
            }
            else
            {
                students = new List<Student>();
                Console.WriteLine("Unesite studente. Unesite 'kraj' za kraj unosa.");
                while (true)
                {
                    if(Console.ReadLine()?.ToLower() == "kraj")
                    {
                        break;
                    }

                    var s = new Student();

                    while(true)
                    {
                        Console.WriteLine("Unesite ime studenta:");
                        string ime = Console.ReadLine();
                        if (Validator.IsNameValid(ime))
                        {
                            s.Ime = ime;
                            break;
                        }
                        Console.WriteLine("Neispravno ime. Pokušajte ponovo.");
                    }


                    while (true)
                    {
                        Console.WriteLine("Unesite prezime studenta:");
                        string prezime = Console.ReadLine();
                        if (Validator.IsNameValid(prezime))
                        {
                            s.Prezime = prezime;
                            break;
                        }
                        Console.WriteLine("Neispravno prezime. Pokušajte ponovo.");
                    }

                    s.GodinaRodjenja = Validator.UnesiBroj("Unesite godinu rođenja studenta:");
                    while (!Validator.IsYearOfBirthCorrect(s.GodinaRodjenja))
                    {
                        Console.WriteLine("Neispravna godina rođenja. Pokušajte ponovo:");
                        s.GodinaRodjenja = Validator.UnesiBroj("Unesite godinu rođenja studenta:");
                    }

                    Console.WriteLine("Unesite ocene studenta (unesite 'end' za kraj unosa):");
                    while (true)
                    {
                        string input = Console.ReadLine();
                        if (input.ToLower() == "end")
                            break;
                        if (int.TryParse(input, out int ocena) && Validator.IsGradeCorrect(ocena))
                        {
                            s.Ocene.Add(ocena);
                        }
                        else
                        {
                            Console.WriteLine("Neispravna ocena. Pokušajte ponovo:");
                        }
                    }

                    students.Add(s);
                    Console.WriteLine("Student uspešno dodat.");

                }
            }

            Console.WriteLine("\nPrikaz studenata:");
            printer.PrikaziListu(students);
        }
    }
}
