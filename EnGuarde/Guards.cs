using System;

namespace EnGuarde
{
  public static class Guards
  {
    public static void Require(object o, string msg)
    {
      if (o is string && string.IsNullOrWhiteSpace(o as string))
        throw new ArgumentException(msg);

      if (o == null)
        throw new ArgumentException(msg);
    }

    public static void Require(params (object value, string errorMessage)[] args)
    {
      foreach (var a in args)
        Require(a.value, a.errorMessage);
    }
  }
}
