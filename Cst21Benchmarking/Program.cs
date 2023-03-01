using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

var results = BenchmarkRunner.Run<Demo>();

[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net70)]
[SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net60)]
[MemoryDiagnoser]
public class Demo
{
    [Benchmark(Baseline = true)]
    public string GetFullStringNormally()
    {
        string output = "";
        for (int i = 0; i < 100; i++)
        {
            output += i + " ";
        }
        return output;
    }

    [Benchmark]
    public string GetFullStringUsingStringBuilder()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < 100; i++)
        {
            sb.Append(i + " ");
        }
        return sb.ToString();
    }
}