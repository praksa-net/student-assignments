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
}