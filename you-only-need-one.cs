using System;

public class Kata
{
  public static bool Check(object[] a, object x)
  {
    int pos = Array.IndexOf(a, x);
    if (pos > -1)
    {
      return true;
    } else
    {
      return false;
    }
  }
}