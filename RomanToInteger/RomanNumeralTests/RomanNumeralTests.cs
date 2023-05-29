using FluentAssertions;
using RomanToInteger;

namespace RomanNumeralTests;

public class RomanNumeralTests
{
    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("-")]
    [InlineData("DT")]
    [InlineData("IIII")]
    [InlineData("XXXX")]
    [InlineData("CCCC")]
    [InlineData("MMMM")]
    [InlineData("VV")]
    [InlineData("LL")]
    [InlineData("DD")]
    [InlineData("IM")]
    [InlineData("XM")]
    [InlineData("VM")]
    [InlineData("LM")]
    [InlineData("DM")]
    [InlineData("IC")]
    [InlineData("VC")]
    [InlineData("LC")]
    [InlineData("DC")]
    [InlineData("ID")]
    [InlineData("VD")]
    [InlineData("LD")]
    [InlineData("XD")]
    public void InvalidNumeralsMustThrowException(string romanNumeral)
    {
        Action act = () => RomanNumeral.Parse(romanNumeral);

        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData("I", 1)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    [InlineData("IV", 4)]
    [InlineData("VI", 6)]
    [InlineData("LX", 60)]
    [InlineData("XL", 40)]
    [InlineData("XC", 90)]
    [InlineData("CX", 110)]
    [InlineData("DCLXXVII", 677)]
    [InlineData("XV", 15)]
    [InlineData("MMMI", 3001)]
    [InlineData("MMMXI", 3011)]
    [InlineData("MMCXI", 2111)]
    [InlineData("MMCLXI", 2161)]
    [InlineData("MMCLXVI", 2166)]
    [InlineData("MMCLXVII", 2167)]
    [InlineData("MMCLXVIII", 2168)]
    [InlineData("CD", 400)]
    [InlineData("CDL", 450)]
    [InlineData("CDXC", 490)]
    [InlineData("CDXCIX", 499)]
    [InlineData("CDXCIV", 494)]
    public void CorrectNumeralsMustParse(string romanNumeral, int expected)
    {
        RomanNumeral.Parse(romanNumeral).Should().Be(expected);
    }
}