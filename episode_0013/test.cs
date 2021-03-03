    using System.Text.RegularExpressions;
    
    string regex = @"[0-9]+.[0-9]+"; // a mano ma non ne sono certo :D
    Regex reg = new Regex(regex, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
    MatchCollection matchedWords = reg.Matches(book); // qua passiamo la stringa
    foreach(match in matchedWords)
    {

    }