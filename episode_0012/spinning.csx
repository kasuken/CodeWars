public static string SpinWords(string sentence)
{
    var words = sentence.Split(" ");

    var result = string.Empty;

    foreach (var item in words)
    {
        result += " ";

        if (item.Length < 5)
        {
            result += item;
            continue;
        }

        result += new string(item.Reverse().ToArray());
    }

    return result.Trim();
}

Console.WriteLine(SpinWords("Hey fellow warriors"));