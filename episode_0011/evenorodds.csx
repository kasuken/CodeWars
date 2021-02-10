public static string EvensAndOdds(int num)
{
    int fromBase = 10;
    int toBase = 16;

    if (num % 2 == 0)
        toBase = 2;

    return Convert.ToString(Convert.ToInt32(num.ToString(), fromBase), toBase);
}

Console.WriteLine(EvensAndOdds(5));
Console.WriteLine(EvensAndOdds(10));