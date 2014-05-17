package Problem21;

import org.junit.Assert;
import org.junit.Test;

public class Problem21Tests {

    @Test
    public void sumOfAmicables_Below10_ShouldBeZero() {
    	final int data = 10;        
    
        final int expected = 0;
    	final int actual = Problem21.sumOfAmicables(data);
    
     	Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void sumOfAmicables_Below221_ShouldBe280() {
        final int data = 221;        
    
        final int expected = 220;
        final int actual = Problem21.sumOfAmicables(data);
    
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void sumOfAmicables_Below10000_ShouldBe31626() {
        final int data = 10000;       
    
        final int expected = 31626;
        final int actual = Problem21.sumOfAmicables(data);
    
        Assert.assertEquals(expected, actual);
    }
}
