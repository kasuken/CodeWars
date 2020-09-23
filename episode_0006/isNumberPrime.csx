  public static bool IsPrime(int n)
  {
      if (n<=1) return false;

      for (int i = 2; i < System.Math.Sqrt(n); i++)
      {
          if (n % i == 0)  return false;
      }

    return true;
  }

Console.WriteLine(IsPrime(0));
Console.WriteLine(IsPrime(1));
Console.WriteLine(IsPrime(10));
Console.WriteLine(IsPrime(2));
Console.WriteLine(IsPrime(123123));