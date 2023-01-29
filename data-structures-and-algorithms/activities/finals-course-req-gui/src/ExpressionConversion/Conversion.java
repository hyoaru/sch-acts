package ExpressionConversion;
import DataStructure.Stack;

public class Conversion {
    private String[] operators = {"-+", "/*", "^"};
    private String brackets = "{[()]}";
    private String operatorsStringified = "-+/*^";
    private String baseExpression;
    private String conversionProcess;
    private Stack stack;
    
    private String openingBrackets = brackets.substring(0, 3);
    private String closingBrackets = brackets.substring(3);
    private ConversionUtilities utilities = new ConversionUtilities(
        brackets, openingBrackets, closingBrackets);

    private int conversionProcessDelay = 500;

    public Conversion(){}

    private void setBaseExpression(String baseExpression){
        this.baseExpression = baseExpression;
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
    
    public String getConversionProcess(){
        return conversionProcess;
    }

    private String convertInfixToPX(String expression){
        setBaseExpression(utilities.addOpeningAndClosingBracketToExpression(expression));
        String[] expressionStringArray = utilities.stringToStringArray(baseExpression);
        String stackStringified = stack.toString();
        String concludingExpression = "";

        // System.out.println("Conversion Process");
        conversionProcess = "Element\t\t Stack\t\t Expression";
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
    
                conversionProcess += String.format("\n%s\t\t %s\t\t %s", element, stackStringified, concludingExpression);
            }

        } catch (Exception e) {
            concludingExpression = " ";
        }

        return concludingExpression;

    }

    public String convertInfixToPostfix(String expression){
        String outputExpression = convertInfixToPX(expression);
        return outputExpression;
    }

    public String convertInfixToPrefix(String expression){
        String reversedExpression = utilities.reverseBracketsPosition(utilities.reverseString(expression));
        String outputExpression = utilities.reverseBracketsPosition(utilities.reverseString(convertInfixToPX(reversedExpression)));
        return outputExpression;
    }

    private String convertPxToInfix(String expression){
        setBaseExpression(expression);
        String[] expressionStringArray = utilities.stringToStringArray(baseExpression);
        String concludingExpression = "";

        conversionProcess = "Element\t\t Stack";
        try {
            for (int i = 0; i < expressionStringArray.length; i++) {
                String element = expressionStringArray[i];
                String stackTop = stack.peek();
                
                boolean elementIsOperator = operatorsStringified.contains(element);
                boolean elementIsOperand = !elementIsOperator;
    
                if (elementIsOperand){
                    stack.push(element);
                } else {
                    if (elementIsOperator){
                        stackTop = stack.peek();
                        String operandB = stackTop;
                        stack.pop();

                        stackTop = stack.peek();
                        String operandA = stackTop;
                        stack.pop();

                        String expressionToPush = String.format("%s%s%s", operandA, element, operandB);
                        stack.push(utilities.addOpeningAndClosingBracketToExpression(expressionToPush));
                    }
                }

                conversionProcess += String.format("\n%s\t\t %s", element, stack.toString());  
            }
            
            String stackStringified = stack.toString();
            concludingExpression = stackStringified;
            
        } catch (Exception e) {
            concludingExpression = " ";
        }

        return concludingExpression;
    }

    public String convertPostfixToInfix(String expression){
        String outputExpression = convertPxToInfix(expression);
        return outputExpression;
    }

    public String convertPrefixToInfix(String expression){
        String reversedExpression = utilities.reverseString(expression);
        String outputExpression = utilities.reverseBracketsPosition(utilities.reverseString(convertPxToInfix(reversedExpression)));
        return outputExpression;
    }
    
    public String convertPrefixToPostfix(String expression){
        String infixExpression = convertPrefixToInfix(expression);
        String toInfixExpressionConversionProcess = getConversionProcess();
        String outputExpression = convertInfixToPostfix(infixExpression);
        String toOutputExpressionConversionProcess = getConversionProcess();
        conversionProcess = String.format(
            "Prefix to Infix\n%s\n\nInfix to Postfix\n%s", 
            toInfixExpressionConversionProcess, 
            toOutputExpressionConversionProcess);
        
        return outputExpression;
    }
    
    public String convertPostfixToPrefix(String expression){
        String infixExpression = convertPostfixToInfix(expression);
        String toInfixExpressionConversionProcess = getConversionProcess();
        String outputExpression = convertInfixToPrefix(infixExpression);
        String toOutputExpressionConversionProcess = getConversionProcess();
        conversionProcess = String.format(
            "Postfix to Infix\n%s\n\nInfix to Prefix\n%s", 
            toInfixExpressionConversionProcess, 
            toOutputExpressionConversionProcess);
        
        return outputExpression;
    }

}
