public static string Balance(string book)
{
    var returnValue = string.empty;

		string book = "1000.00!=\n125 Market !=:125.45\n126 Hardware =34.95\n127 Video! 7.45\n128 Book   :14.32\n129 Gasoline ::16.10";
    
    string regex = @"[0-9A-Za-z\.\s]+"; // a mano ma non ne sono certo :D
    Regex reg = new Regex(regex, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
    MatchCollection matchedWords = reg.Matches(book); // qua passiamo la stringa
		
	var pulita = string.Join("", matchedWords.Select(m => m.Value));
		
	pulita = pulita.Replace("   ", " ").Replace("  ", " ");
		
	

	
    foreach(var match in matchedWords)
    {
		
    }
	
		pulita = pulita.Replace(" ", "_");
		
			Console.WriteLine(pulita);
	}

    return book;
}


String b1 = "1000.00!=\n125 Market !=:125.45\n126 Hardware =34.95\n127 Video! 7.45\n128 Book   :14.32\n129 Gasoline ::16.10";

Console.WriteLine(Balance(b1));

// [0-9A-Za-z\.\s]+