int a = 1;
int b = 2;

Console.WriteLine(DoSmartOperation(1,2, Addition));
Console.WriteLine(DoSmarterOperation(1,3, Addition));
Console.WriteLine(
    DoSmarterOperation(1, 3, (i,j) => { return i - j; })
    );
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