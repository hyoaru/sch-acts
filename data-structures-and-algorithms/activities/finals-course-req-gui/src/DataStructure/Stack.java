package DataStructure;

public class Stack {
    int stackSize;
    private String[] stack;
    private int top = -1;

    public Stack(int stackSize){
        this.stackSize = stackSize;
        stack = new String[this.stackSize];
    }

    public boolean isFull(){
        return top == stackSize-1;
    }

    public boolean isEmpty(){
        return top < 0;
    }
    
    public void push(String item) throws StackException{
        if (!isFull()){
            top += 1;
            stack[top] = item;
        } else {
            throw new StackException("Stack is full!");
            // System.out.println("Stack is full!");
        }
    }

    public void pop() throws StackException{
        if (isEmpty()){
            throw new StackException("Stack is empty!");
            // System.out.println("Stack is empty!");
        } else {
            top -= 1;
        }
    }
    
    public String peek(){
        if (!isEmpty()){
            return stack[top];
        } else {
            return " ";
        }
    }

    public void print() throws StackException{
        if (top < 0){
            throw new StackException("Stack is empty!");
            // System.out.println("Stack is empty!");
        } else {
            for (int i = 0; i <= top; i++) {
                System.out.println("\t" + stack[i]);
            }
        }
    }

    public String toString(){
        String stackStringified = "";
        for (int i = 0; i <= top; i++) {
            stackStringified += String.format("%s", stack[i]);
        }
        return stackStringified;
    }

}
