using System.Numerics;
using System.Linq;
using System;

public class Problem16 
{
  public static void Run(string[] args)
  {
    int exponent = int.Parse(args[0]);
    BigInteger n = BigInteger.Pow(2, exponent);
    char[] chars = n.ToString().ToCharArray();
    int sum = chars.Select(c => (int)char.GetNumericValue(c)).Sum();

    Console.WriteLine(sum);
    
  }
}