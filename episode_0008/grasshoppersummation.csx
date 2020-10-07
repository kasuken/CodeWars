    public static int summation(int num)
    {
        var sum = 1;

        for (int i = 2; i <= num; i++)
        {
            sum += i;
        }

        return sum;
    }

    Console.WriteLine(summation(10));
    Console.WriteLine(summation(8));
    Console.WriteLine(summation(22));
    Console.WriteLine(summation(100));