package ExpressionConversion;
public class ConversionUtilities {
    private String brackets;
    private String openingBrackets;
    private String closingBrackets;

    ConversionUtilities(String brackets, String openingBrackets, String closingBrackets){
        this.brackets = brackets;
        this.openingBrackets = openingBrackets;
        this.closingBrackets = closingBrackets;
    }

    public ConversionUtilities() {
    }

    public String[] stringToStringArray(String stringToConvert){
        String[] stringToConvertArray = new String[stringToConvert.length()];
        for (int i = 0; i < stringToConvert.length(); i++) {
            stringToConvertArray[i] = Character.toString(stringToConvert.toCharArray()[i]);
        }

        return stringToConvertArray;
    }

    public String reverseString(String stringToReverse){
        char[] stringToReverseCharArray = stringToReverse.toCharArray();
        String reversedString = "";
        for (int i = stringToReverseCharArray.length - 1; i >= 0; i--) {
            reversedString = reversedString.concat(Character.toString(stringToReverseCharArray[i]));
        }
        return reversedString;
    }

    public String addOpeningAndClosingBracketToExpression(String expression){
        String modifiedExpression = String.format("(%s)", expression);
        return modifiedExpression;
    }

    public String stringArraytoString(String[] stringArray){
        String stringConverted = "";
        for (String string : stringArray) {
            stringConverted += string;
        }
        return stringConverted;
    }

    public String removeBrackets(String stringToRemoveBracketsFrom){
        String stringStrippedBrackets = stringToRemoveBracketsFrom;
        for (String bracket : stringToStringArray(brackets)) {
            stringStrippedBrackets = stringStrippedBrackets.replace(bracket, "");
        }
        return stringStrippedBrackets;
    }

    public String reverseBracketsPosition(String stringToReverseBrackets){
        String[] stringToReverseBracketsArray = stringToStringArray(stringToReverseBrackets);
        
        for (int i = 0; i < stringToReverseBracketsArray.length; i++) {
            String character = stringToReverseBracketsArray[i];
            if (openingBrackets.contains(character)){
                String[] closingBracketsReversed = stringToStringArray(reverseString(closingBrackets));
                String openingBracket = character;
                int indexOfBracket = openingBrackets.indexOf(openingBracket);
                String closingBracket = closingBracketsReversed[indexOfBracket];
                stringToReverseBracketsArray[i] = closingBracket;
            } else if (closingBrackets.contains(character)){
                String closingBracket = character;
                int indexOfBracket = reverseString(closingBrackets).indexOf(closingBracket);
                String openingBracket = stringToStringArray(openingBrackets)[indexOfBracket];
                stringToReverseBracketsArray[i] = openingBracket;
            }
        }

        String stringReversedBrackets = stringArraytoString(stringToReverseBracketsArray);
        return stringReversedBrackets;
    }

}
