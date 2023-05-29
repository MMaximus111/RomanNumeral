namespace RomanToInteger;

public static class RomanNumeral
{
    private static readonly IReadOnlyDictionary<char, int> _romanNumerals;
    // private static readonly IReadOnlyDictionary<char, IReadOnlyCollection<int>> _validRomanNumeralSubtractions;

    static RomanNumeral()
    {
        // _validRomanNumeralSubtractions = new Dictionary<char, IReadOnlyCollection<int>>
        // {
        //     ['I'] = new[] { 5, 10 },
        //     ['X'] = new[] { 50, 100 },
        //     ['C'] = new[] { 500, 1000 }
        // };

        _romanNumerals = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };
    }

    public static int Parse(string romanNumeral)
    {
        //ValidateRomanNumeral(romanNumeral);

        int result = 0;

        for (int i = 0; i < romanNumeral.Length; i++)
        {
            char letter = romanNumeral[i];

            int current = _romanNumerals[letter];
            int next = 0;

            if (i + 1 < romanNumeral.Length)
            {
                next = _romanNumerals[romanNumeral[i + 1]];
            }

            if (current >= next)
            {
                result += current;
            }
            else
            {
                result -= current;

                // if (_validRomanNumeralSubtractions.TryGetValue(letter, out IReadOnlyCollection<int>? validSubtractionValues)
                //     && validSubtractionValues.Contains(next))
                // {
                //     result -= current;
                // }
                // else
                // {
                //     throw new NotSupportedException("Invalid Roman Numeral");
                // }
            }
        }

        return result;
    }

    // private static void ValidateRomanNumeral(string romanNumeral)
    // {
    //     if (string.IsNullOrWhiteSpace(romanNumeral))
    //     {
    //         throw new ArgumentException("Roman numeral cannot be null or empty", nameof(romanNumeral));
    //     }
    //
    //     foreach (char romanNumeralChar in romanNumeral)
    //     {
    //         if (!_romanNumerals.ContainsKey(romanNumeralChar))
    //         {
    //             throw new ArgumentException("Roman numeral contains invalid characters", nameof(romanNumeralChar));
    //         }
    //     }
    // }
}