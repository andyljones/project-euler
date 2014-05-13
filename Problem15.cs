using System;

public class Problem15
{
  private const int TARGET = 10;

  public static void Main()
  {
    var counter = new PathCounter(TARGET);
    Console.WriteLine(counter.getCount());
  }
}

class PathCounter
{
  private long[,] pathCounts;

  public PathCounter(int target) {
    pathCounts = InitializePathCounts(target);

    populatePathCounts();
  }

  private static long[,] InitializePathCounts(int target)
  {
    long[,] result = new long[target+1, target+1];
    for (int i = 0; i <= target; i++)
    {
      result[i, 0] = 1;
      result[0, i] = 1;
    }
   
    return result;
  }

  private void populatePathCounts()
  {
    for (int i = 1; i < pathCounts.GetLength(0); i++)
    {
      for (int j = 1; j < pathCounts.GetLength(1); j++)
      {
        pathCounts[i, j] = pathCounts[i-1, j] + pathCounts[i, j-1];
      }
    }
  }

  public long getCount()
  {
    return pathCounts[pathCounts.GetLength(0)-1, pathCounts.GetLength(1)-1];
  }
}