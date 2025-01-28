using BreakInfinity;
using System;

public static class BigDoubleFormatter
{
    public static string FormatBigDouble(BigDouble value)
    {
        if (value < 1_000)
            return value.ToString("F0"); // No decimal places for values less than 1000

        string[] suffixes = { "", "K", "M", "B", "T", "Q", "Qn", "Sx", "Sp", "Oc", "No", "Dc" };
        int order = 0;

        // Calculate the order of magnitude for the suffix
        while (value >= 1_000 && order < suffixes.Length - 1)
        {
            order++;
            value /= 1_000;
        }

        // If the value exceeds 1000 * Dc, switch to scientific notation
        if (order == suffixes.Length - 1 && value >= 1_000)
        {
            // Switch to scientific notation
            BigDouble exponent = BigDouble.Floor(BigDouble.Log10(value) + (order * 3)); // Calculate total exponent
            BigDouble coefficient = value / BigDouble.Pow(10, BigDouble.Floor(BigDouble.Log10(value))); // Normalize coefficient

            // Format the coefficient and exponent
            string formattedCoefficient = coefficient.ToString("F2");
            string formattedExponent = FormatExponent(exponent);

            return $"{formattedCoefficient}e{formattedExponent}";
        }

        // Format the number with two decimal places and append the suffix
        return value.ToString("F2") + suffixes[order];
    }

    private static string FormatExponent(BigDouble exponent)
    {
        // Convert the exponent to a string and format it with commas
        string exponentString = exponent.ToString("F0");
        return FormatWithCommas(exponentString);
    }

    private static string FormatWithCommas(string number)
    {
        // Insert commas into the number string
        int index = number.Length - 3;
        while (index > 0)
        {
            number = number.Insert(index, ",");
            index -= 3;
        }
        return number;
    }
}
