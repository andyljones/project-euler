// Initialize 0-9
// while there exists a k st a[k] < a[k+1]
// find the largest k st a[k] < a[k+1]
// find the largest l st a[k] < a[l]
// swap a[k] and a[l]
// reverse a[k+1] onwards

package Problem24;

import java.util.*;
import java.util.stream.Collectors;

public class Problem24 {

  public static List<Integer> getPermutation(final int numberOfElements, final int index) {
    List<Integer> permutation = java.util.stream.IntStream.range(0, numberOfElements + 1).boxed().collect(Collectors.toList());
    for (int i = 0; i < index; i++) {
      permutation = nextPermutation(permutation);
    }

    return permutation;
  }

  private static List<Integer> nextPermutation(final List<Integer> permutation) {
    if (permutation.size() < 1) {
      return new ArrayList<>(permutation);
    } else {
      List<Integer> result = new ArrayList<>(permutation);

      int k = permutation.size() - 2;
      while (k >= 1 && permutation.get(k) >= permutation.get(k+1)) { k--; }

      int l = permutation.size() - 1;
      while (l >= 1 && permutation.get(k) >= permutation.get(l)) { l--; }

      Collections.swap(result, k, l);
      Collections.reverse(result.subList(k+1, result.size()));
            
      return result;   
    }
  }

}