import java.util.Arrays;
import java.util.Random;

public class App {
    public static void main(String[] args) throws Exception {
        Random random = new Random();
        int[] intArray = new int[8];

        // Data input: generating random numbers using the random library
        // and filling the array up using a for loop 
        for (int i = 0; i < intArray.length; i++) {
            intArray[i] = random.nextInt(50) + 1;
        }

        // Process: making the process non-destructive; 
        // hence, avoiding inplace operation and making a new array instead
        int intArrayReversedIndex = 0;
        int[] intArrayReversed = new int[intArray.length];
        for (int i = intArray.length - 1; i > -1; i--) {
            intArrayReversed[intArrayReversedIndex] = intArray[i];
            intArrayReversedIndex++;
        }

        // Output: printing the string representations of the array
        // using the 'Arrays' library and the 'toString' method
        String intArrayStringified = Arrays.toString(intArray);
        String intArrayReversedStringified = Arrays.toString(intArrayReversed);

        System.out.println("Original value of the array: " + intArrayStringified);
        System.out.println("Reverse value of an array: " + intArrayReversedStringified);
        
    }
}
