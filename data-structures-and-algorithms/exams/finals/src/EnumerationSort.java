import java.util.Arrays;

public abstract class EnumerationSort {
    public static void main(String[] args){
        int[] unsortedArray = {2,5,0,4};
        int[] sortedArray = new int[unsortedArray.length];

        System.out.println("Initial array state:\t" + Arrays.toString(unsortedArray));
        for (int i = 0; i < unsortedArray.length; i++) {
            int currentItem = unsortedArray[i];
            int sortedArrayPosition = 0;
            for (int j = 0; j < unsortedArray.length; j++) {
                if (currentItem > unsortedArray[j]) {
                    sortedArrayPosition++;
                }
            }
            sortedArray[sortedArrayPosition] = currentItem;
            System.out.println("Sorting array state:\t" + Arrays.toString(sortedArray));
        }

        System.out.println("Sorted array state:\t" + Arrays.toString(sortedArray));
    }   
}
