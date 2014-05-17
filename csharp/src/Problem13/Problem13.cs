using System;
using System.IO;
using System.Linq;
using System.Numerics;

public class Problem13 
{
  private const string inputFilePath = "Problem13Input.txt"; 
 
  public static void Run() 
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