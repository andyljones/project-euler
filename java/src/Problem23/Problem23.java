// Find all abundant numbers below 28123
//
// Find all sums of those abundant numbers. Use a hashset to track them.
//
// Sum the entries which haven't been set.

package Problem23;

import java.util.*;


public class Problem23 {
  public static int sumOfNonabundantSums(final int limit) {
    List<Integer> abundantNumbers = generateAbundantNumbers(limit);

    BitSet numbers = new BitSet(limit + 1);
    for (int i = 0; i < abundantNumbers.size(); i++) {
      for (int j = i; j < abundantNumbers.size(); j++) {
        final int sum = abundantNumbers.get(i) + abundantNumbers.get(j);
        if (sum <= limit) {
          numbers.set(sum);
        }
      }
    }

    int total = 0;
    for (int i = 1; i <= limit; i++) {
      if (!numbers.get(i)) {
        total = total + i;
      }
    }

    return total;
  }

  private static List<Integer> generateAbundantNumbers(final int limit) {
    final List<Integer> results = new ArrayList<>();
    for (int i = 1; i <= limit; i++) {
      if (isAbundant(i)) {
        results.add(i);
      }
    }
     
    return results;
  }

  private static boolean isAbundant(final int n) {
    int sum = 0;
    
    for (int i = 2; i < Math.sqrt(n); i++) {
      if (n % i == 0) {
        sum = sum + i + n/i;
      }
    }

    if (n % Math.sqrt(n) == 0.0) {
      sum = sum + (int)Math.sqrt(n);  
    }

    return sum > n;
  }
}