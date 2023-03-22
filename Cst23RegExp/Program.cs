using System.Text.RegularExpressions;

string[] partNumbers = { "1298-673-4192", "A08Z-931-468a", "_A90-123-129X", "12345-KKA-1230", "0919-2893-1256" };
string pattern = @"^[A-Z0-9]\d{2}[A-Z0-9](-\d{3}){2}[A-Z0-9]$";
foreach (string partNumber in partNumbers)
{
    if (Regex.IsMatch(partNumber, pattern, RegexOptions.IgnoreCase))
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}

string pattern2 = @"\ba\w*\b";
string input = "An extraordinary day dawns with each new day.";
Match m = Regex.Match(input, pattern2, RegexOptions.IgnoreCase);
if (m.Success)
    Console.WriteLine("Found '{0}' at position {1}.", m.Value, m.Index);
else
    Console.WriteLine("---"); // <--

string pattern3 = @"\b\w+es\b"; // slovo obsahující písmena "es" - [mezera][slovo]es[mezera]
string sentence = "NOTES: Any notes or comments are optional.";
foreach (Match match in Regex.Matches(sentence, pattern3, RegexOptions.None, TimeSpan.FromSeconds(1)))
{
    Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index); // notes
}

string input2 = "This is   text with   far  too   much   white space.";
string pattern4 = "\\s+"; // alespoň jeden netisknutelný znak
string replacement = " ";
string result = Regex.Replace(input2, pattern4, replacement);
Console.WriteLine(result);

string pattern5 = @"\d+"; // alespoň jedna číslice
Regex rgx = new Regex(pattern5);
string input3 = "123ABCDE456FGHIJKL789MNOPQ012";
string[] result2 = rgx.Split(input3); // '', 'ABCDE', 'FGHIJKL', 'MNOPQ', ''
foreach(var x in result2)
{
    Console.WriteLine(x);
}