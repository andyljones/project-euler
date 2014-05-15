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
  public static void main(final String[] args) {
    final int limit = Integer.parseInt(args[0]);
    System.out.println("hi");
    System.out.println(sumOfAmicables(limit));
  }

  private static int sumOfAmicables(final int limit) {
    int sum = 0;
    for (int i = 1; i < limit; i++) {
      if (isAmicableNumber(i)) {
        sum = sum + i;
      }
    }

    return sum;
  }

  private static boolean isAmicableNumber(final int n) {
    System.out.println("Number " + n);
    final int sumOfNsDivisors = sumOfDivisors(n);
    System.out.println("Sum of divisors " + sumOfNsDivisors);
    final int sumOfDivisorsOfSumOfDivisors = sumOfDivisors(sumOfNsDivisors);
    System.out.println("Sum of divisors of sum of divisors " + sumOfDivisorsOfSumOfDivisors);

    System.out.println("");

    return sumOfDivisorsOfSumOfDivisors == n && sumOfNsDivisors != n;
  }

  private static int sumOfDivisors(final int n) {
    int sum = 1;
    for (int i = 2; i < Math.sqrt(n); i++) {
      if (n/i * i == n) {
        sum = sum + i;
        sum = sum + n/i;
      }
    }

    final int sqrtOfN = (int)Math.sqrt(n);
    if (sqrtOfN*sqrtOfN == n && n != 1) {
      sum = sum + sqrtOfN;
    }

    return sum;
  }
}