using System;
using BreakInfinity;

public static class BigDoubleExtensions
{
    public static BigDouble Pow(this BigDouble baseValue, BigDouble exponent)
    {
        if (baseValue <= 0)
            throw new System.ArgumentException("Base must be greater than zero.");
        if (exponent == 0)
            return BigDouble.One;

        // Use natural logarithm (base e)
        return BigDouble.Exp(exponent * BigDouble.Log(baseValue, new BigDouble(Math.E)));
    }
}
