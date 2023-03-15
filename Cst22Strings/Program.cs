using System.Globalization;
using System.Text;
/*
System.String s = "Ahoj";
int a = 12;
Console.WriteLine(s + a);
Console.WriteLine(String.Format("Tohle je {0} {1}", s, a));
Console.WriteLine($"Tohle je {s} {a}");
Console.WriteLine(@"Verbatim řetězec
    může být klidně na víc řádek a nejsou
    v nich interpretovány únikové sekvence, 
    ""uvozovky"" je potřeba zdvojit.");
Console.WriteLine("Nazdar \n světe \b\b\b");

StringBuilder sb = new StringBuilder("Ahoj");
for (int i = 0; i < 10; i++)
{
    sb.Append(i.ToString());
}
Console.WriteLine(sb.ToString());

string s1 = "Hey World, you still there?";
Console.WriteLine(s1[1]); // e

string source = "The mountains are behind many clouds today.";
bool containsSearchResult = source.Contains("are");
Console.WriteLine(containsSearchResult);

var replacement = source.Replace("mountains", "peaks");
Console.WriteLine(replacement);
var replacement2 = source.Replace(' ', '_');
Console.WriteLine(replacement2);

string toRemove = "many ";
string result = string.Empty;
int l = source.IndexOf(toRemove);
if (l >= 0)
{
    result = source.Remove(l, toRemove.Length); // od kterého znaku, kolik znaků
}
Console.WriteLine(source);
Console.WriteLine(result);
*/

decimal value = 123.456m;
Console.WriteLine("Your account balance is {0:C2}.", value); // $123.46
Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture)); // $12,345.68
Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("da-DK"))); // 12.345,679 kr

int value2 = 12345;
Console.WriteLine(value2.ToString("D")); // 12345
Console.WriteLine(value2.ToString("D8")); // 00012345

int value3 = 100;
Console.WriteLine(value3.ToString("x")); // 2045e
Console.WriteLine(value3.ToString("X")); // 2045E
Console.WriteLine(value3.ToString("X8")); // 0002045E

