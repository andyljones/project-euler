using System.Diagnostics;
using System;
using System.IO;
using System.Linq;

class Problem18
{
  public static void Run(string[] args)
  {
    string inputPath = args[0];
    int[][] inputTriangle = ParseInput(inputPath);

    int[] maxSums = inputTriangle[0];
    for (int i = 1; i < inputTriangle.Length; i++) 
    {
      Console.WriteLine("Iteration " + i);
      maxSums = maxSumsOfNextRow(inputTriangle[i], maxSums);
    }

    Console.WriteLine(maxSums.Max());

  }

  private static int[][] ParseInput(string inputPath)
  {
    string[] lines = File.ReadAllLines(inputPath);
    int[][] result = lines.Select(l => l.Split(new char[] {' '}).Select(num => int.Parse(num)).ToArray()).ToArray();
     
    return result;
  }

  private static int[] maxSumsOfNextRow(int[] nextRow, int[] maxSumsSoFar)
  {
    Debug.Assert(nextRow.Length == maxSumsSoFar.Length + 1, "Next row is not one longer than previous row!");

    Console.WriteLine("Length " + maxSumsSoFar.Length);
    int[] result = new int[nextRow.Length];
    result[0] = nextRow[0] + maxSumsSoFar[0];
    for (int i  = 1; i < result.Length - 1; i++)
    {
      Console.WriteLine("Count " + i);
      int firstOption = maxSumsSoFar[i-1] + nextRow[i];
      int secondOption = maxSumsSoFar[i] + nextRow[i];

      result[i] = Math.Max(firstOption, secondOption);
    }

    result[result.Length - 1] = maxSumsSoFar[maxSumsSoFar.Length-1] + nextRow[result.Length - 1];

    return result;
  }
}