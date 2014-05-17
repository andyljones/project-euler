package Problem24;

import java.util.Arrays;
import java.util.List;

import org.junit.*;

public class Problem24Tests {

  @Test
  public void Lexicographically4thPermutation_Of012_ShouldBe120() {
    final int upperBound = 2;
    final int count = 4;
    
    final List<Integer> expected = Arrays.asList(1, 2, 0);
    final List<Integer> actual = Problem24.getPermutation(upperBound, count-1);

    Assert.assertEquals(expected, actual);
  }
  
  @Test
  public void LexicographicallyMillionthPermutation_Of0123456789_ShouldBe120() {
    final int upperBound = 9;
    final int count = 1000000;
    
    final List<Integer> expected = Arrays.asList(2, 7, 8, 3, 9, 1, 5, 4, 6, 0);
    final List<Integer> actual = Problem24.getPermutation(upperBound, count-1);

    Assert.assertEquals(expected, actual);
  }

}  