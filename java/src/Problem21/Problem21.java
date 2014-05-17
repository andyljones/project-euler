package Problem21;

import java.util.concurrent.*;
import java.util.*;

// Sum of all amicable numbers
// sumOfAmicables(int limit)
// - For 1 through limit, check if i is an amicable number
// - If it is, add it to the total
// - Return total.
//
// isAmicableNumber(int n)
// - Get sumOfDivisors(n)
// - Get sumOfDivisors(sumOfDivisors(n))
// - If they match, return true
//
//
// sumOfDivisors(int n)
// - Start with sum = 1
// - For 2 through sqrt(n), if i is a divisor of n, add it and its partner to sum
// - Check if sqrt(n)sqrt(n) == n, and add it to sum if so
// - Return sum

public class Problem21
{
  private static final int NO_OF_CORES = Runtime.getRuntime().availableProcessors();

  public static int sumOfAmicables(final int limit) {
    System.err.format("Using %d threads\n", NO_OF_CORES);
    final ExecutorService execService = Executors.newFixedThreadPool(NO_OF_CORES);

    Collection<Callable<Integer>> tasks = new ArrayList<>();
    for (int i = 1; i < limit; i++) {
      final Integer n = i;
      tasks.add(() -> isAmicableNumber(n)? n : 0);
    }

    int sum = 0;
    try {
        List<Future<Integer>> results = execService.invokeAll(tasks);
        for (Future<Integer> result : results) {
            sum = sum + result.get();
        }
    } catch (InterruptedException | ExecutionException e) {
        System.err.format("One or more tasks failed to return a result. Stack trace follows:\n");
        e.printStackTrace();
    } finally {
        execService.shutdown();
    }
    
    return sum;
  }

  private static boolean isAmicableNumber(final int n) {
    final int sumOfNsDivisors = sumOfDivisors(n);
    final int sumOfDivisorsOfSumOfDivisors = sumOfDivisors(sumOfNsDivisors);

    return sumOfDivisorsOfSumOfDivisors == n && sumOfNsDivisors != n;
  }

  private static int sumOfDivisors(final int n) {
    int sum = 1;
    for (int i = 2; i < Math.sqrt(n); i++) {
      if (i % n == 0) {
        sum = sum + i;
        sum = sum + n/i;
      }
    }

    final int sqrtOfN = (int)Math.sqrt(n);
    if (sqrtOfN % n == 0 && n != 1) {
      sum = sum + sqrtOfN;
    }

    return sum;
  }
}