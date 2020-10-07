using System.Collections.Generic;
public static string sayMeOperations(string stringNumbers)
{

    List<string> results = new List<string>();
    var numbers = stringNumbers.Split(" ");
    for (int i = 0; i <= numbers.Length - 3; i++)
    {
        var a = int.Parse(numbers[i]);
        var b = int.Parse(numbers[i + 1]);
        var c = int.Parse(numbers[i + 2]);
        
        if (a + b == c)
        {
            results.Add("addition");
            continue;
        }
        if (a - b == c)
        {
            results.Add("subtraction");
            continue;
        }
        if (a * b == c)
        {
            results.Add("multiplication");
            continue;
        }
        if (b != 0 && a / b == c)
        {
            results.Add("division");
            continue;
        }
    }
    ;
    return string.Join(", ", results).Trim();
}

sayMeOperations("1 2 3 5 8");
sayMeOperations("9 4 5 20 25");