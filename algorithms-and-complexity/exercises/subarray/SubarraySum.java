import java.util.*;

public class SubarraySum {
    public static void main(String[] args) throws Exception {
        int[] array = new int[] {1,2,3,4};
        String[] arrayStringified = (
            Arrays.toString(array)
            .replace("[", "").replace("]", "")
            .replace(" ", "").split(","));
        
        List<String> elementList = Arrays.asList(arrayStringified);
        List<String> subArrays = getSubarray(elementList);
        subArrays = formatSubarray(subArrays.subList(1, subArrays.size()));
        System.out.println(String.format("Subarrays: %s", subArrays));
        System.out.println(String.format("Maximum subarray sum: %d", getSubarraySum(array)));
    }

    public static int getSubarraySum(int[] array) {
        int highestValue = array[0];
        int secondHighestValue = array[0];

        for (int value : array) {
            if (value > highestValue){
                secondHighestValue = highestValue;
                highestValue = value;
            }
        }

        return highestValue + secondHighestValue;
    }

    public static List<String> getSubarray(List<String> elements) {
        if (elements.size() == 0){
            return new ArrayList<>(Arrays.asList(""));
        } else {
            String firstElement = elements.get(0);
            List<String> restOfElements = elements.subList(1, elements.size());
            List<String> combinationsWithoutFirst = getSubarray(restOfElements);
            List<String> combinationsWithFirst = new ArrayList<>();

            for (String combination : combinationsWithoutFirst) {
                combination += "." + firstElement;
                combinationsWithFirst.add(combination);
            }

            List<String> combinationToReturn = new ArrayList<>();
            combinationToReturn.addAll(combinationsWithoutFirst);
            combinationToReturn.addAll(combinationsWithFirst);
            
            return combinationToReturn;
        }
    }

    public static List<String> formatSubarray(List<String> subArrays) {
        for (int i = 0; i < subArrays.size(); i++) {
            String subArray = subArrays.get(i);
            String formattedSubArray = String.format(
                "[%s]", (
                    subArray.replace(".", ",")
                    .substring(1, subArray.length()))
            );
            subArrays.set(i, formattedSubArray);
        }

        return subArrays;
    }
}
