import java.util.*;

public class App {
    public static void main(String[] args) throws Exception {
        int[] array = { 6, 11, 13, 2, 1, 7, 3, 8, 9};
        int targetValue = 10;

        HashMap<Integer, Integer> valueComplementMap = new HashMap<>();
        for (int value : array) {   // n
            if (value >= targetValue) { continue; }     // c1
            int complement = targetValue - value;   // c2
            valueComplementMap.put(value, complement);  // c3
            
            // Using the complements as keys to ensure that 
            // the [value, complement] to be printed is both in the original array 
            
            if (valueComplementMap.get(complement) != null) {   // c4
                System.out.println(String.format("[%d, %d]", value, valueComplementMap.get(value)));    // c5
            }
        }  

        // Time complexity calculation: (c5 + c4 + c3 + c2 + c1) n 
        // Overall calculation: cn
        // Ignoring the constant time: O(n)
    }
}
