import java.util.Arrays;

public class SelectionSort {
    public static void main(String[] args) throws Exception {
        int[] array = {5,2,4,6,1,3};
        System.out.println("Initial array state:\t" + Arrays.toString(array));

        int arrayLength = array.length;
        for (int i = 0; i < arrayLength; i++) {
            int minimumValueIndex = i;

            // Find minimum value: start from i
            for (int j = i; j < arrayLength; j++) {
                if (array[j] < array[minimumValueIndex]){
                    minimumValueIndex = j;                    
                }
            }
            
            // Swapping values
            int temp = array[i];
            array[i] = array[minimumValueIndex];
            array[minimumValueIndex] = temp;

            System.out.println("Sorting array state:\t" + Arrays.toString(array));

        }

        System.out.println("Sorted array state:\t" + Arrays.toString(array));
    }
}
