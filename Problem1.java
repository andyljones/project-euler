class Problem1 {
  
  public static void main(String[] args) {
    final int sum = getSumOfMultiples(3, 5, 1000);
    System.out.println("Sum is " + sum);
  }

  private static int getSumOfMultiples(int a, int b, int limit) {
    final int sumOfMultiplesOfa = a*sumIntegersUpTo((limit-1)/a);
    final int sumOfMultiplesOfb = b*sumIntegersUpTo((limit-1)/b);
    final int sumOfMultiplesOfab = a*b*sumIntegersUpTo((limit-1)/(a*b));

    return sumOfMultiplesOfa + sumOfMultiplesOfb - sumOfMultiplesOfab;        
  }

  private static int sumIntegersUpTo(int n) {
    return n*(n+1)/2;
  }
  
}