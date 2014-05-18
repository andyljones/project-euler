using System;
using System.Collections.Generic;
using System.Linq;

static class Problem27
{
    public readonly int result;

    public static int CoefficientProductWithLongestPrimeSequence(int maxA, int maxB)
    {
        var tester = new PrimalityTester();

        var lengths = from a in Enumerable.Range(0, maxA)
                      from b in Enumerable.Range(0, maxB)
                      select Tuple.Create(a * b, NumberOfPrimesGeneratedByCoefficients(a, b, tester));

        var result = lengths.OrderBy(tuple => tuple.Item2).First();

        return result;
    }

    private static int NumberOfPrimesGeneratedByCoefficients(int a, int b, PrimalityTester tester)
    {
        int lengthOfPrimeSequence = 0;
        while (tester.isPrime(evaluateQuadratic(a, b, lengthOfPrimeSequence)))
        {
            lengthOfPrimeSequence = lengthOfPrimeSequence + 1;
        }

        return lengthOfPrimeSequence;
    }

    private static int evaluateQuadratic(int a, int b, int x)
    {
        return x*x + a*x + b;
    }


}

