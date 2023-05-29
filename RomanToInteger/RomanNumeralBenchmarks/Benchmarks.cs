using BenchmarkDotNet.Attributes;
using RomanToInteger;

namespace RomanNumeralBenchmarks;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Benchmark]
    public void ParseRomanNumeral()
    {
        RomanNumeral.Parse("MMCLXVI");
    }
}