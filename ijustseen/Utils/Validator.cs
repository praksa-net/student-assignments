class Validator
{
  public Validator() { }

  public static bool ValidateOcena(int ocena)
  {
    if (ocena < 1 || ocena > 5)
    {
      return false;
    }
    return true;
  }

  public static int getValidatedIntString()
  {
    try
    {
      string input = Console.ReadLine();
      if (!IsNameValid(input))
      {
        throw new FormatException();
      }
      return int.Parse(input);
    }
    catch
    {
      Console.WriteLine("Unos nije validan. Molimo unesite ceo broj.");
      return getValidatedIntString();
    }
  }
  
  public static bool IsNameValid(string input)
  {
    return !string.IsNullOrWhiteSpace(input);
  }
}