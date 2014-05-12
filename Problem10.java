class Problem10 {

  private static final int LIMIT = 2000000;

  public static void main(String args[]) {
    System.out.println(sumOfPrimes(LIMIT));
  }

  private static long sumOfPrimes(final int limit) {
    final boolean[] range = new boolean[limit];       

    for (int i = 2; i < Math.sqrt(limit); i++) {
      if (range[i] == false) { 
        for (int j = 2*i; j < limit; j = j + i) {
          range[j] = true;
        }
      }
    }

    long sum = 0;
    for (int i = 2; i < limit; i++) {
       if (range[i] == false) { sum = sum + i; }
    }

    return sum;
  }
}