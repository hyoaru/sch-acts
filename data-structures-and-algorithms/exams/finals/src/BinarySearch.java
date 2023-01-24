import java.util.Arrays;

public class BinarySearch {
    private int[] array;
    private int[] subArray;
    private int[] range;
    private boolean isFound = false;
    
    private int leftIndex;
    private int rightIndex;
    private int midIndex;
    private int leftItem;
    private int rightItem;
    private int midItem;

    public BinarySearch(int[] array){
        this.array = array;
        subArray = this.array;
        range = new int[] {0, subArray.length-1};
        computeItemIndex();
    }

    private void computeItemIndex(){
        leftIndex = range[0];
        rightIndex = range[range.length-1];
        midIndex = averageOfArray(range);
        leftItem = array[leftIndex];
        rightItem = array[rightIndex];
        midItem = array[midIndex];
    }

    public int search(int numberToFind){
        int itemFoundAt = -1;
        if (midItem != numberToFind){
            boolean outOfRange = ((numberToFind < leftItem) | (numberToFind > rightItem));
            while ((isFound != true) & (!outOfRange) & (subArray.length != 0)){
                computeItemIndex();
                if (midItem > numberToFind){
                    setRange(leftIndex, midIndex-1);
                } else if (midItem < numberToFind){
                    setRange(midIndex+1, rightIndex);
                } else if (midItem == numberToFind) {
                    itemFoundAt = midIndex;
                    isFound = true;
                }
                
                subArray = subArrayFromRange(array, range);
            }
        } else {
            return midIndex;
        }

        return itemFoundAt;
    }

    public void setRange(int beginningIndex, int endIndex){
        range[0] = beginningIndex;
        range[1] = endIndex;
    }


    public int averageOfArray(int[] range){
        int sum = 0;
        for (int i = 0; i < range.length; i++) {
            sum += range[i];
        }

        int average = sum / (range.length);
        return average;
    }

    public int[] subArrayFromRange(int[] array, int[] range){
        int arrayLowerBracketIndex = range[0];
        int arrayUpperBracketIndex = range[1];

        int subArraySize = (arrayUpperBracketIndex + 1) - arrayLowerBracketIndex;
        int[] subArray = new int[subArraySize];

        int subArrayIndex = 0;
        for (int i = arrayLowerBracketIndex; i < arrayUpperBracketIndex+1; i++) {
            subArray[subArrayIndex] = array[i];
            subArrayIndex++;
        }

        return subArray;
    }
}
