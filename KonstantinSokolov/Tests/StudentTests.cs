using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using KonstantinSokolov.Models;

namespace KonstantinSokolov.Tests
{
    public class StudentTests
    {
        [Fact]
        public void IzracunajProsek_ReturnCorrectAverage()
        {
            // Arrange
            var student = new Student
            {
                Ime = "Marko",
                Prezime = "Markovic",
                GodinaRodjenja = 2000,
                Ocene = new List<int> { 5, 4, 3, 5, 4, 5, 2, 3, 1 }
            };
            // Act
            double prosek = student.IzracunajProsek();
            // Assert
            Assert.Equal(3.556, prosek, 0.01);
        }

        [Theory]
        [InlineData(4.8, Uspeh.Odlican)]
        [InlineData(3.7, Uspeh.VrloDobar)]
        [InlineData(2.6, Uspeh.Dobar)]
        public void OdrediUspeh_ReturnsCorrectUspeh_ForRealAverage(double prosek, Uspeh expectedUspeh)
        {
            // Arrange
            var student = new Student
            {
                Ime = "Ana",
                Prezime = "Anic",
                GodinaRodjenja = 2001
            };

            int brojOcena = 5;

            int sum = (int)Math.Round(prosek * brojOcena);

            int baseGrade = Math.Clamp(sum / brojOcena, 1, 5);

            int extra = sum % brojOcena;
            int higherGrade = Math.Clamp(baseGrade + 1, 1, 5);

            var ocene = Enumerable
                .Repeat(baseGrade, brojOcena - extra)
                .Concat(Enumerable.Repeat(higherGrade, extra))
                .ToList();


            student.Ocene = ocene;

            // Act
            Uspeh uspeh = student.OdrediUspeh();

            // Assert
            Assert.Equal(expectedUspeh, uspeh);
        }


    }
}
