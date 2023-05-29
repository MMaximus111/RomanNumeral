using BenchmarkDotNet.Running;

namespace RomanNumeralBenchmarks;

public class Program
{
    static void Main()
    {
        BenchmarkRunner.Run<Benchmarks>();
    }
}