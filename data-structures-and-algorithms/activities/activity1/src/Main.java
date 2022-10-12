import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Random random = new Random();

        System.out.print("Enter a number: ");
        int numberToFind = input.nextInt();

        int[] arrayToSearch = new int[8];
        for (int index = 0; index < arrayToSearch.length; index++) {
            arrayToSearch[index] = random.nextInt(10) + 1; 
        }

        // Making a string representation of the array 
        String arrayToSearchStringified = "Elements of an array : ";
        for (int number : arrayToSearch) {
            arrayToSearchStringified += number + ", ";
        }

        arrayToSearchStringified = (
            arrayToSearchStringified
            .substring(0, arrayToSearchStringified.length() - 2)
            .replace(": ", ": [") + "]");

        System.out.println(arrayToSearchStringified);

        // Initializing `indexOfNumberToFind` to -1 and setting it to the index if it matches with a value in the array
        int indexOfNumberToFind = -1;
        for (int index = 0; index < arrayToSearch.length; index++) {
            if (numberToFind == arrayToSearch[index]) {
                indexOfNumberToFind = index;
                break;
            }
        }

        // Assigning the success message if `indexOfNumberToFind` is not equal to -1 and a not found message if not
        String remarks = (
            indexOfNumberToFind != -1
            ? "Number found at index: " + indexOfNumberToFind + "."
            : "Number to search not found.");
        
        System.out.println(remarks);

        input.close();
    }
}



