using BenchmarkDotNet.Attributes;
using System.Text;

namespace MyBenchmarkDotNet;

public class MyBenchmarkClass
{
    [GlobalSetup]
    public void GlobalSetup()
    {
        //called only once
        var rand = new Random();
    }

    [Benchmark]
    public string MyBenchmarkA()
    {
        string str = "MyBenchmark";
        for (int i = 0; i < 100; i++)
        {
            str += i.ToString();
        }

        return str;
    }
    [Benchmark]
    public string MyBenchmarkB()
    {
        string str = "MyBenchmark";
        for (int i = 0; i < 100; i++)
        {
            str = $"{str}{i}";
        }

        return str;
    }
    [Benchmark]
    public string MyBenchmarkC()
    {
        string str = "MyBenchmark";
        for (int i = 0; i < 100; i++)
        {
            str = string.Format("{0}{1}", str, i);
        }

        return str;
    }
    [Benchmark]
    public string MyBenchmarkD()
    {
        var builder = new StringBuilder("MyBenchmark");
        for (int i = 0; i < 100; i++)
        {
            builder.Append(i);
        }
        return builder.ToString();
    }

}
