// Základy CSharpu

/*
Programové konstrukce
- Blok
{ } Alt+N, Alt+B
- Podmínky
*/
int a = 1;
// -- Podmínka
if (a == 1)
{
    Console.WriteLine("Jedna");
};
// -- Větvení
if (a == 1)
{
    Console.WriteLine("Jedna");
}
else
{
    Console.WriteLine("Nejedna");
}
// -- Switch
switch (a)
{
    case 1: { Console.WriteLine("Jedna"); break; }
    case 2: { Console.WriteLine("Dva"); break; }
    default: { Console.WriteLine("Moc"); break; }
}

// - Cykly
// -- While
while (a < 1)
{
    a = a + 1;
    a += 1;
    a++;
    Console.WriteLine(a);
}
// nemusí proběhnout ani jednou
// čtení z databáze nebo souboru

// -- Do..while
do
{
    Console.WriteLine(a);
    a += 1;
}
while (a < 100);
// proběhne jednou
// vstup z klávesnice

// -- For
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i);
}
// pevný a předem daný počet iterací

for (; ; ) // nekonečný cyklus
{
    a = a + 1;
    if (a % 2 == 0) continue; // další  iterace cyklu
    Console.WriteLine("+");
    if (a > 120) break; // cyklus ukončí
}

// -- Foreach
int[] pole = { 0, 1, 2, 3 };
foreach (int y in pole)
{
    Console.WriteLine(y);
}
// procházení pole  nebo kolekce

// - proměnné a datové typy
int b;
if (b == 1)
{
    // xc
    int c;
    // c
    // c
    // c
}
// xc

int d; // deklarace
int e = 1; // inicializace

// int f = null;
int? g = null;
string txt = String.Empty;
float d = 0.1f;
double e = 0.1;
string f = "Ahoj";
char g = 'X';
bool h = true;
//int i = null; // int nemůže být null
int? i = null; // ale existuje int?