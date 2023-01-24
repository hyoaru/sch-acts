import java.util.Arrays;
import java.util.Scanner;

public class App {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
        int[] array = {1,4,5,7,9,12,15,18,19,22,25,29,40,50};
        BinarySearch binarySearch = new BinarySearch(array);
        
        String userInput;
        do {
            System.out.println("\nArray: " + Arrays.toString(array));
            System.out.print("Enter number to find: ");
            userInput = input.nextLine().strip();
            int itemToFind = Integer.parseInt(userInput);
            int itemFoundAt = binarySearch.search(itemToFind);
    
            if (itemFoundAt != -1){
                System.out.println(String.format("Item found at index: %d.", itemFoundAt));
            } else {
                System.out.println("Item not found.");
            }
        } while (!userInput.equals("-1"));

        input.close();
    }
}
