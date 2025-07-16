using Xunit;

public class ValidatorTests
{
    [Theory]
    [InlineData(1, true)]
    [InlineData(5, true)]
    [InlineData(0, false)]
    [InlineData(6, false)]
    public void ValidateOcena_WorksCorrectly(int ocena, bool expected)
    {
        Assert.Equal(expected, Validator.ValidateOcena(ocena));
    }

    [Theory]
    [InlineData("Test", true)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void IsNameValid_WorksCorrectly(string input, bool expected)
    {
        Assert.Equal(expected, Validator.IsNameValid(input));
    }
} 