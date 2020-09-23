  public static string Problem(String a)
  {

      double i = 0;

       if (!double.TryParse(a, out i))
       {
           return "Error";
       }

        i = (i * 50) + 6;

    return i.ToString();
  }

  Console.WriteLine(Problem("12345"));
  Console.WriteLine(Problem("12345"));
  Console.WriteLine(Problem("12345"));
  Console.WriteLine(Problem("12345"));