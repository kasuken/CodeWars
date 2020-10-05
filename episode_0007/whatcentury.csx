public static string WhatCentury(string year)
{
    var n_year = int.Parse(year);
    var n_century = (int)(n_year / 100) + ((n_year % 100 == 0) ? 0 : 1);

    int yearInt = int.Parse(year)/100;

    if (!(int.Parse(year.Substring(1, year.Length - 1)) == 0))
    yearInt++;

    string ordinale = "th";
    if (yearInt > 20) {
        switch (yearInt % 10) 
        { case 1:
                ordinale = "st";
            break;
            case 2:
                ordinale = "nd";
            break; 
            case 3:
                ordinale = "rd";
            break; 
            default: ordinale = "th"; break; } 
    }

    return $"{n_century}{ordinale}";
}

Console.WriteLine(WhatCentury("1999"));
Console.WriteLine(WhatCentury("2176"));