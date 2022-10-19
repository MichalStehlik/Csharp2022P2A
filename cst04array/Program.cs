/*
var y = .8f;
var e = 0;
while (y > .1)
{
    y /= 2;
    //Console.WriteLine(y + " " + e);
    e += 10;
}
Console.WriteLine(e);
*/
// -- Pole
/*
int a = 3;
int[] cisla1;
int[] cisla2 = new int[3]; // 3 prvky s defaultni hodnota
Console.WriteLine(cisla2[0]);
cisla2[0] = 1; // 8, 9, 10
// int[] cisla3 = new int[3] {1,2,3};
int[] cisla3 = { 1, 2, 3, 4 };
cisla3[0] = 10;
Console.WriteLine(cisla3);
for (int i = 0; i < cisla3.Length; i++)
{
    Console.Write(i);
    Console.WriteLine(cisla3[i]);
}
int j = 0;
foreach(var x in cisla3)
{
    Console.Write(j++);
    Console.WriteLine(x);
}
*/
// -- 
/*
int[] znamky = new int[100];
znamky[0] = 1;
znamky[1] = 1;
znamky[2] = 2;
znamky[3] = 4;
znamky[6] = 1;
//znamky[101] = 6;
var pocet = 4;
var jednicky = 0;
foreach(int x in znamky)
{
    Console.Write(x);
}
for(int i = 0; i < pocet; i++)
{
    if (znamky[i] == 1) jednicky++;
}
Console.WriteLine(jednicky);
*/
/*
int[,] vysky = new int[3, 2];
vysky[0, 0] = 100;
vysky[1, 0] = 10;
vysky[2, 0] = 100;
vysky[0, 1] = 20;


int[,] vysky2 =
{
    {100,200,100 }, //stehlik[0]
    {50,100,150 } 
};

for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.WriteLine(vysky2[i,j]);
    }
}

foreach (var x in vysky2)
{
    Console.WriteLine(x); // prochazi hodnoty jako by bylo jednorozmerne
}

Console.WriteLine(vysky2.Length); // 6

// jagged 2d array
int[][] data = new int[3][];
data[0] = new int[2] { 0, 1 };
data[1] = new int[3] { 2, 3, 4 };
data[2] = new int[] { 5, 6 };

foreach(var radek in data)
{
    foreach (var hodnota in radek)
    {
        Console.Write(hodnota);
    }
    Console.WriteLine();
}
*/
using System.Runtime.Serialization.Formatters;

int[] pole = { 1,5,8,6,2,3,4,1,5 };
//Console.WriteLine(Array.MaxLength); // maximální počet prvků
//Array.Clear(pole); // vynulování
//Array.Fill(pole,5); // naplnění 5
//pole = Range(1,10); // vlastní funkce Range
//Array.Sort(pole); // seřazení pole
//Array.Reverse(pole); // obrácení pole
/*
Console.WriteLine(Array.IndexOf(pole, 6));
Console.WriteLine(Array.IndexOf(pole, 7));
Console.WriteLine(Array.LastIndexOf(pole, 1));

int[] pole2 = pole; // reference na stejné místo
int[] pole3 = (int[])pole.Clone(); // mělká kopie
pole2[1] = 500;
pole3[2] = 1000;
*/
pole = IncrementArray1(pole,1);
IncrementArray2(ref pole,1);

ResizeArray(ref pole, pole.Length + 3);
foreach (var x in pole)
{
    Console.Write(x + ";");
}
Console.WriteLine();
/*
foreach (var x in pole2)
{
    Console.Write(x + ";");
}
Console.WriteLine();
foreach (var x in pole3)
{
    Console.Write(x + ";");
}
Console.WriteLine();
*/
int[] Range(int min, int max)
{
    int[] res = new int[max - min + 1];
    for (int i = 0; i <= max - min; i++)
    {
        res[i] = min + i;
    }
    return res;
}

void ResizeArray(ref int[] arr, int newSize)
{
    int[] res = new int[newSize];
    for(int i = 0; i < res.Length; i++)
    {
        if (i < arr.Length) res[i] = arr[i];
    }
    arr = res;
}

int[] IncrementArray1(int[] arr, int value)
{
    int[] res = new int[arr.Length];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = arr[i] + value;
    }
    return res;
}

void IncrementArray2(ref int[] arr, int value)
{
    int[] res = new int[arr.Length];
    for (int i = 0; i < res.Length; i++)
    {
        arr[i] += value;
    }
}