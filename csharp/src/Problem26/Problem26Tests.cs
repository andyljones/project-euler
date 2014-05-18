using NUnit.Framework;
using System;

[TestFixture]
class Problem26Tests
{
    [TestCase(2, 1)]
    [TestCase(3, 1)]
    [TestCase(6, 1)]
    [TestCase(7, 6)]
    public void FractionDigitCycleLength_OnSpecificDenominators_IsCorrect(int input, int expected)
    {
        // Exercise
        int actual = Problem26.FractionDigitsCycleLength(input);

        // Validation
        Assert.AreEqual(expected, actual);
    }

    //[Test]
    //public void LongestCycleLength_Under1000_IsCorrect()
    //{
    //    Console.WriteLine(Problem26.LongestCycleLength(1000));
    //}
}