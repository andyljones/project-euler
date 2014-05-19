using NUnit.Framework;
using System;

class Problem28Tests
{
    [Test]
    public void spiralDiagonalSum_ForA5by5Spiral_ShouldBe101()
    {
        int input = 5;
        int expected = 101;

        int actual = Problem28.SpiralDiagonalSum(input);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void scratch()
    {
        Console.WriteLine(Problem28.SpiralDiagonalSum(1001));
    }
}
