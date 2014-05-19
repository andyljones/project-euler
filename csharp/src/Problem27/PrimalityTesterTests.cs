using NUnit.Framework;

[TestFixture]
class PrimalityTesterTests
{
    [TestCase(1, false)]
    [TestCase(4, false)]
    [TestCase(6, false)]
    public void isPrime_ShouldReturnFalse_ForTheseCases(int input, bool expected)
    {
        var sut = new PrimalityTester();

        bool actual = sut.isPrime(input);

        Assert.AreEqual(expected, actual);
    }

    [TestCase(2, true)]
    [TestCase(3, true)]
    [TestCase(5, true)]
    public void isPrime_ShouldReturnTrue_ForTheseCases(int input, bool expected)
    {
        var sut = new PrimalityTester();

        bool actual = sut.isPrime(input);

        Assert.AreEqual(expected, actual);
    }
}
