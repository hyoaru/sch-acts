import java.util.Scanner;

import ExpressionConversion.ExpressionConversion;

public class App {
    public static void main(String[] args) throws Exception {
        ExpressionConversion expressionConversion = new ExpressionConversion();
        Scanner input = new Scanner(System.in);

        System.out.println("Data Structures and Algorithms");
        System.out.println("Expression Converter");
        System.out.println("\tA: Infix to postfix \n\tB: Infix to prefix");
        System.out.print("Input: ");
        String userInput = input.next();

        System.out.print("\nEnter expression: ");
        String expression = input.next();
        if (userInput.equalsIgnoreCase("a")){
            expressionConversion.convertInfixToPostfix(expression);
        } else if (userInput.equalsIgnoreCase("b")){
            expressionConversion.convertInfixToPrefix(expression);
        }

        input.close();
    }
}
