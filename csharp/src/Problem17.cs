using System;

public class Problem17
{
  private static readonly string[] zeroToTwenty = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
  private static readonly string[] multiplesOfTen = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
  private const string hundred = "hundred";
  private const string and = "and";
  private const string thousand = "onethousand";

  public static void Run(string[] args)
  {
    int limit = int.Parse(args[0]);
    
    int count = 0;
    for (int i = 1; i <= limit; i++)
    {
      count = count + writtenLength(i).Length;
      Console.WriteLine(i + ": " + writtenLength(i));
    }

    Console.WriteLine(count);
  }

  private static string writtenLength(int n)
  {
    if (n < 20) 
    {
      return zeroToTwenty[n];
    }
    else
    {
      return writtenLengthHelper(n);
    }
  }

  private static string writtenLengthHelper(int n)
  {
    if (n == 0)
    {
      return "";
    }
    else if (n < 20)
    {
      return zeroToTwenty[n];
    }
    else if (n < 100)
    {
      return multiplesOfTen[n/10] + writtenLengthHelper(n - 10*(n/10));
    }
    else if (n < 1000)
    {
      return zeroToTwenty[n/100] + hundred + (n/100*100 == n? "" : and) + writtenLengthHelper(n - 100*(n/100));
    }
    else //if (n == 1000)
    {
      return thousand;
    }
  }
}