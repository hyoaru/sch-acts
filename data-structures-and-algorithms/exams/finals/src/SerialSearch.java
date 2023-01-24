import java.util.Arrays;
import java.util.Scanner;

public class SerialSearch {
    public static void main(String[] args){
        Scanner input = new Scanner(System.in);
        int[] array = {5,4,1,2,6,7,9};

        System.out.println("Array: " + Arrays.toString(array));
        System.out.print("Number to find: ");
        int numberToFind = input.nextInt();

        int indexFoundAt = -1;
        for (int i = 0; i < array.length; i++) {
            int currentItem = array[i];
            if (currentItem == numberToFind){
                indexFoundAt = i;
                break;
            }
        }

        if (indexFoundAt != -1) {
            System.out.println("Found at index: " + indexFoundAt);
        } else {
            System.out.println("Item not found!");
        }

        input.close();
    }
}
