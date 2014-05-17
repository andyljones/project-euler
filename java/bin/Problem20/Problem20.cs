using System;
using System.Numerics;
using System.Linq;

public class Problem20
{
  public static void Main() 
  {
    BigInteger n = 1;
    for (int i = 1; i < 100; i++) {
      n = n*i;
    } 

    string digits = n.ToString();
    int sum = digits.Select(d => (int)Char.GetNumericValue(d)).Sum();

    Console.WriteLine(sum);
  }
}