using System;
using System.IO;
using System.Linq;
using System.Numerics;

public class Problem14 
{
  private const string inputFilePath = "Problem14Input.txt"; 
 
  public static void Main() 
  {
    BigInteger[] input = GetInput(inputFilePath);
   
    BigInteger sum = input.Aggregate((i, j) => i + j);

    Console.WriteLine(sum);
  }
 
  private static BigInteger[] GetInput(string inputFilePath) 
  {
    string[] lines = File.ReadAllLines(inputFilePath);

    return lines.Select(line => BigInteger.Parse(line)).ToArray();
  }
  
}