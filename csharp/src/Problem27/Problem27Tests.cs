using NUnit.Framework;
using System;

[TestFixture]
class Problem27Tests
{
    [Test]
    public void CoeffProd_ShouldFindEulersQuadratic_AndReturn41()
    {
        int expected = -41;
        int actual = Problem27.CoefficientProductWithLongestPrimeSequence(2, 42);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CoeffProd_ShouldFindEightyPrimeQuadratic_AndReturn126479()
    {
        int expected = -126479;
        int actual = Problem27.CoefficientProductWithLongestPrimeSequence(80, 1602);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void scratch()
    {
        Console.WriteLine(Problem27.CoefficientProductWithLongestPrimeSequence(1000, 1000));
    }
}

