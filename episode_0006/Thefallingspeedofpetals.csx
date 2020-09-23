  public static double SakuraFall(double v)
  {
    if (v <= 0)
        return 0;

    return (5 * 80 / v);
  }

  Console.WriteLine(SakuraFall(40));