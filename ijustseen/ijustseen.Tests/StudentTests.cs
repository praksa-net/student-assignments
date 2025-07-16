using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;

public class StudentTests
{
    [Fact]
    public void IzracunajProsek_ReturnsCorrectAverage()
    {
        var student = new Student { Ocene = new int[] { 5, 4, 3 } };
        Assert.Equal(4.0, student.IzracunajProsek());
    }

    [Theory]
    [InlineData(new int[] { 5, 5, 5 }, Uspeh.Odlican)]
    [InlineData(new int[] { 4, 4, 4 }, Uspeh.VrloDobar)]
    [InlineData(new int[] { 3, 3, 3 }, Uspeh.Dobar)]
    [InlineData(new int[] { 2, 2, 2 }, Uspeh.Dovoljan)]
    [InlineData(new int[] { 1, 1, 1 }, Uspeh.Nedovoljan)]
    [InlineData(new int[] { }, Uspeh.NemaOcena)]
    public void OdrediUspeh_ReturnsCorrectUspeh(int[] ocene, Uspeh expected)
    {
        var student = new Student { Ocene = ocene };
        Assert.Equal(expected, student.OdrediUspeh());
    }
} 