package ExpressionConversion;
import DataStructure.Stack;

public class ExpressionConversion {
    private String[] operators = {"-+", "/*", "^"};
    private String brackets = "{[()]}";
    private String operatorsStringified = "-+/*^";
    private String baseExpression;
    private Stack stack;
    
    private String openingBrackets = brackets.substring(0, 3);
    private String closingBrackets = brackets.substring(3);
    private ExpressionConversionUtilities utilities = new ExpressionConversionUtilities(
        brackets, openingBrackets, closingBrackets);

    private int conversionProcessDelay = 500;

    public ExpressionConversion(){}

    private void setBaseExpression(String baseExpression){
        this.baseExpression = utilities.addOpeningAndClosingBracketToExpression(baseExpression);
        stack = new Stack(baseExpression.length());
    }

    private int getOperatorPrecedence(String operator){
        int operatorPrecedence = 0;
        for (int i = 0; i < operators.length; i++) {
            String operatorGroup = operators[i];
            if (operatorGroup.contains(operator)){
                operatorPrecedence = i;
                break;
            }
        }
        return operatorPrecedence;
    }

    private boolean elementOperatorHasLowerPrecedence(String element){
        String stackTop = stack.peek();
        int elementOperatorPrecedence = getOperatorPrecedence(element);
        int stackOperatorPrecedence = getOperatorPrecedence(stackTop);

        boolean elementOperatorHasLowerPrecedence = elementOperatorPrecedence < stackOperatorPrecedence;
        return elementOperatorHasLowerPrecedence;
    }

    private boolean elementAndStackOperatorHasSamePrecedence(String element){
        String stackTop = stack.peek();
        int elementOperatorPrecedence = getOperatorPrecedence(element);
        int stackOperatorPrecedence = getOperatorPrecedence(stackTop);

        boolean elementAndStackOperatorHasSamePrecedence = elementOperatorPrecedence == stackOperatorPrecedence;
        return elementAndStackOperatorHasSamePrecedence;
    }

    private String convertInfixToPX(String expression){
        setBaseExpression(expression);
        String[] expressionStringArray = utilities.stringToStringArray(baseExpression);
        String stackStringified = stack.toString();
        String concludingExpression = "";

        System.out.println("Conversion Process");
        System.out.println("\tElement\t\t Stack\t\t Expression");
        try {
            for (int i = 0; i < expressionStringArray.length; i++) {
                String element = expressionStringArray[i];
                String stackTop = stack.peek();
                stackStringified = stack.toString();
                
                boolean elementIsOperator = operatorsStringified.contains(element);
                boolean elementIsBracket = brackets.contains(element);
                boolean elementIsOperand = ((!elementIsOperator) && (!elementIsBracket));

                if (elementIsOperand){
                    concludingExpression += element;
                } else {
                    boolean elementIsOpeningBracket = openingBrackets.contains(element);
                    boolean elementIsClosingBracket = closingBrackets.contains(element);
                    
                    if (elementIsOpeningBracket){
                        stack.push(element);
                    } else if (elementIsClosingBracket){
                        boolean stackTopIsOpeningBracket = openingBrackets.contains(stackTop);

                        while (!stackTopIsOpeningBracket){
                            stackTop = stack.peek();
                            stackTopIsOpeningBracket = openingBrackets.contains(stackTop);
                            if (stackTopIsOpeningBracket){
                                stack.pop();
                            } else {
                                stackStringified = stack.toString();
                                concludingExpression += stackTop;
                                stack.pop();
                            }
                        }
                    } else if (elementIsOperator){
                        boolean elementAndStackOperatorHasSamePrecedence = elementAndStackOperatorHasSamePrecedence(element);
                        boolean elementOperatorHasLowerPrecedence = elementOperatorHasLowerPrecedence(element);
                        boolean stackTopIsBracket = brackets.contains(stackTop);
                        
                        if (elementAndStackOperatorHasSamePrecedence & !stackTopIsBracket){
                            concludingExpression += stackTop;
                            stack.pop();
                            stack.push(element);
                        } else if (elementOperatorHasLowerPrecedence & !stackTopIsBracket){
                            concludingExpression += stackTop;
                            stack.pop();

                            stackTop = stack.peek();
                            elementAndStackOperatorHasSamePrecedence = elementAndStackOperatorHasSamePrecedence(element);
                            stackTopIsBracket = brackets.contains(stackTop);
                            if (elementAndStackOperatorHasSamePrecedence & !stackTopIsBracket){
                                stackTop = stack.peek();
                                concludingExpression += stackTop;
                                stack.pop();
                            }
                            stack.push(element);

                        } else {
                            stack.push(element);
                        }
                    }
                    
                }
    
                System.out.println(String.format("\t%s\t\t %s\t\t %s", element, stackStringified, concludingExpression));
            }

        } catch (Exception e) {
            
        }

        return concludingExpression;

    }

    public void convertInfixToPostfix(String expression){
        System.out.println("Starting expression: " + expression);
        String outputExpression = convertInfixToPX(expression);
        System.out.println("Output expression: " + outputExpression);
    }

    public void convertInfixToPrefix(String expression){
        String reversedExpression = utilities.reverseBracketsPosition(utilities.reverseString(expression));
        System.out.println("Starting expression: " + reversedExpression);
        String outputExpression = utilities.reverseBracketsPosition(utilities.reverseString(convertInfixToPX(reversedExpression)));
        System.out.println("Output expression: " + outputExpression);
    }

}
