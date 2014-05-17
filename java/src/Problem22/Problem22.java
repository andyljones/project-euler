// Read file in
// Sort in alphabetical order
// For each line index:
//   Calculate the nameValue(lines[i])
//   Add i*nameValue(lines[i]) to sum

package Problem22;

import java.util.*;
import java.util.stream.Collectors;
import java.io.IOException;
import java.nio.file.*;
import java.nio.charset.*;

class Problem22 {

  public static int nameScores(String inputFilePath) {

    List<String> lines = Arrays.asList(getLines(inputFilePath).get(0).split("\",\""));
    lines = lines.stream().map(s -> s.replaceAll("[^\\w]", "")).collect(Collectors.toList());
    Collections.sort(lines);
    int sum = 0;
    for (int i = 0; i < lines.size(); i++) {
      sum = sum + (i+1)*lineValue(lines.get(i));
    }

    return sum;
  }
  
  private static List<String> getLines(String inputFilePath) {
      List<String> lines = new ArrayList<>();
      try {
          lines = Files.readAllLines(Paths.get(inputFilePath), Charset.defaultCharset());
      } catch (IOException ioe) {
          System.err.format("Failed to open input file");
          ioe.printStackTrace();
      }
      
      return lines;
  }
  
  private static int lineValue(String line) {
      final int result = line.trim().chars().map(c -> (Character.getNumericValue(c) - Character.getNumericValue('A') + 1)).sum();
    
      return result;
  }
}