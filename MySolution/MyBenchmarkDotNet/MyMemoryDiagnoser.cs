using BenchmarkDotNet.Attributes;

namespace MyBenchmarkDotNet;

[MemoryDiagnoser]
public class MyMemoryDiagnoser
{
    [Benchmark]
    public string MyBenchmark()
    {
        return "MyBenchmark";
    }
}
