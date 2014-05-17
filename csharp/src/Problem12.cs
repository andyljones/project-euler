using System;

public class Problem12 
{
  private const int MIN_DIVISORS = 500;

  public static void Run() 
  {
    int n = 1;
    while (NumberOfDivisors(TriangularNumber(n)) < MIN_DIVISORS) 
    {
      n = n + 1; 
    }
    
    Console.WriteLine("First triangular number with more than " + MIN_DIVISORS + " divisors is " + TriangularNumber(n));
  }
  
  private static int TriangularNumber(int n)
  {
    return n*(n+1)/2;
  }

  private static int NumberOfDivisors(int n) 
  {
    int count = 0;
    for (int i = 1; i < Math.Sqrt(n); i++) {
      bool iIsDivisorOfn = (n/i*i == n);

      if (iIsDivisorOfn) 
      { 
        count = count + 2;
      }
    }

    if (Math.Sqrt(n) * Math.Sqrt(n) == n) 
    {
      count = count + 1;
    }
   
    return count;
  }
}