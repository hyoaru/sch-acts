import java.util.Arrays;

public class InsertionSort {
    public static void main (String[] args){
        int[] array = {2,3,4,1,7,5};

        System.out.println("Initial array state:\t" + Arrays.toString(array));
        for (int i = 0; i < array.length-1; i++) {
            int nextItemIndex = i+1;
            int currentItem = array[i];
            int nextItem = array[i+1];

            if (nextItem < currentItem) {
                int targetIndex = getTargetIndexWhereToShiftLeft(array, nextItem);

                // Main logic: Insertion or swapping or shifting left
                //      Swapping from right to left
                //      From the nextItemIndex to targetIndex
                for (int j = nextItemIndex; j >= 1 + targetIndex; j--) {
                    int temp = array[j];
                    array[j] = array[j-1];
                    array[j-1] = temp;
                }
            }

            System.out.println("Sorting array state:\t" + Arrays.toString(array));

        }
        System.out.println("Sorted array state:\t" + Arrays.toString(array));


    }

    public static int getTargetIndexWhereToShiftLeft(int[] array, int itemToCompare){
        int targetIndex = -1;
        for (int i = 0; i < array.length; i++) {
            if (itemToCompare < array[i]){
                targetIndex = i;
                break;
            }
        }

        return targetIndex;
    }


}
