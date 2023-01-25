/*
int a = 1;
int b = 2;

Console.WriteLine(DoSmartOperation(1,2, Addition));
Console.WriteLine(DoSmarterOperation(1,3, Addition));
Console.WriteLine(
    DoSmarterOperation(1, 3, (i,j) => { return i - j; })
    );
Console.WriteLine(DoSmartOperation(1, 2, (i,j) => (i * j)));
*/

List<int> data = new List<int>{ 1,2,3,4,5,6,7,8,9,11};
/*
foreach(int x in MySuperExtensions.Odd(data))
{
    Console.WriteLine(x);
}
*/
foreach (int x in data.Odd())
{
    Console.WriteLine(x);
}
foreach (int x in data.BiggerThen(5))
{
    Console.WriteLine(x);
}

static class MySuperExtensions
{
    public static List<int> Odd(this List<int> input)
    {
        List<int> ints = new List<int>();
        foreach(var x in input)
        {
            if (x % 2 == 1) ints.Add(x);
        }
        return ints;
    }

    public static List<int> BiggerThen(this List<int> input, int threshold)
    {
        List<int> ints = new List<int>();
        foreach (var x in input)
        {
            if (x > threshold) ints.Add(x);
        }
        return ints;
    }
} 
/*
int DoSmartOperation(int o, int p, NumBinOp op)
{
    return op(o, p);
}
int DoSmarterOperation(int o, int p, Func<int, int, int> op)
{
    return op(o, p);
}
int Addition(int m, int n) { return m + n; }

delegate int NumBinOp(int x, int y);
*/