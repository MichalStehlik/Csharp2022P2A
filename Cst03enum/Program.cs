// Enum

using System.Text;

Color bg = Color.White;
Console.WriteLine(bg);
Console.WriteLine((int)bg);

// Operatory
// unarni
// !x
// binarni
// a + b
// ternarni
int a = 0;
int c = 4;
Console.WriteLine(a == 0 ? "Nic" : "Neco");
int b = 12 + --c + ((a == 0) ? 2 : 4);
Console.WriteLine(b);
// a++ postincrement, a--, ++a, --a
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
// složené operátory
a += 100;
a = + 100;

string str = "A" + "AA";
str = str + "AAA";
Console.WriteLine(str);

StringBuilder sb = new StringBuilder();
sb.Append("A");
sb.Append("AA");
sb.Append("AAA");
Console.WriteLine(sb.ToString());

StringBuilder sb2 = null;
sb2?.Append("B");

/*
 * x! = x * ... * 6 * 5 * 4 * 3 * 2 * 1
 */

int Factorial(int x)
{
    if (x <= 1) return x;
    return x * Factorial(x - 1);
}

int x = 0;
int? y = null;

public enum Color {
    Red,
    Green,
    Blue,
    White,
    Black
}

public enum Gender
{
    Unknown = 0,
    Male = 1,
    Female = 2,
    Other = 3
}
