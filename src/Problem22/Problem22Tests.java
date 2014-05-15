package Problem22;

import org.junit.*;

public class Problem22Tests {
  
  @Test
  public void OnInputTextFile_NameScores_ShouldReturn() {
    final String data = "src/Problem22/names.txt";

    System.err.format("Result is %d\n", Problem22.nameScores(data));
  }
  
  
}