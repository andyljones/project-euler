using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class Problem14
{
  private const int LIMIT = 1000000;

  public static void Main()
  {
    var calc = new ChainLengthCalculator(LIMIT);
    Console.WriteLine(calc.getMaxLength());    
  }
}

class ChainLengthCalculator
{
  private readonly int[] chainLengths;

  public ChainLengthCalculator(int limit)
  {
    chainLengths = new int[limit + 1];
    chainLengths[1] = 1;

    populateChainLengthArray();
  }
  
  private void populateChainLengthArray()
  {
    for (int i = 1; i < chainLengths.Length; i++)
    {
      var chain = generateChain(i);
      pushChainIntoLengthArray(chain);
    }
  }

  private IList<long> generateChain(long n)
  {
    var result = new List<long>();
    while (n != 1)
    {
      if (n < chainLengths.Length && chainLengths[n] != 0)
      {
        break;
      } 
  
      result.Add(n);
      n = n%2 == 0? n/2 : 3*n + 1;
    }
    
    result.Add(n);

    return result;
  }

  private void pushChainIntoLengthArray(IList<long> chain)
  {
    for (int i = 0; i < chain.Count; i++) 
    {
      if (chain[i] < chainLengths.Length)
      {
        int distanceFromEnd = chain.Count - i - 1;
        chainLengths[chain[i]] = distanceFromEnd + chainLengths[chain.Last()];
      }
    }
  }

  public int getMaxLength() 
  { 
    int bestSoFar = 0;
    int maxSoFar = 0;
    for (int i = 0; i < chainLengths.Length; i++)
    {
      if (chainLengths[i] > maxSoFar)
      {
        bestSoFar = i;    
        maxSoFar = chainLengths[i];
      }
    }
    
    return bestSoFar;
  }
}