// Find all abundant numbers below 28123
//
// Find all sums of those abundant numbers. Use a hashset to track them.
//
// Sum the entries which haven't been set.

package Problem23;

import org.junit.*;

public class Problem23Tests {
  
  @Test
  public void given24_sumOfNonabundantSums_ShouldReturn24() {
    final int data = 24;
    
    final int expected = 24;
    final int actual = Problem23.sumOfNonabundantSums(data);
    
    Assert.assertEquals(expected, actual);
  }
  
  @Test
  public void given28123_sumOfNonabundantSums_ShouldReturnResult() {
    final int data = 28123;
    
    final int expected = 24;
    final int actual = Problem23.sumOfNonabundantSums(data);
    
    Assert.assertEquals(expected, actual);
  }

}