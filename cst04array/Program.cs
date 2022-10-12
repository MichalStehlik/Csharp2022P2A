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