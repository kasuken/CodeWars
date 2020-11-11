    public static long MinValue(int[] a)
    {
       return int.Parse(a.Distinct().OrderBy(u=> u).Select(u=> u.ToString()).Aggregate((a,b) => a + b));
    }

    int [] marks = new int[] { 1, 3, 1, 1, 4};

    Console.WriteLine(MinValue(marks));