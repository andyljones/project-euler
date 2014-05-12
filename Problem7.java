import java.util.List;
import java.util.LinkedList;

class Problem7 {

  public static void main(String args[]) {
    List<Integer> primes = new LinkedList<Integer>();
    primes.add(2);

    for (int i = 0; i < 10001; i++) {
      System.out.println("Iteration " + i);
      primes.add(getNextPrime(primes));
    }

    System.out.println("10,001 prime is " + primes.get(10000));
  }

  private static int getNextPrime(List<Integer> primes) {
    int n = primes.get(primes.size() - 1) + 1;
     
    while (true) {
      if (isMultiple(n, primes)) {
        n = n+1;
      } else {
        System.out.println("New prime: " + n);
        return n;
      }
    }
  }

  private static boolean isMultiple(int n, List<Integer> primes) {
    for (Integer p : primes) {
      if ((n/p)*p == n) {
        return true;
      }
    }

    return false;
  }
}