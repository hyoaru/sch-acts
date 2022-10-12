public class Main {
    public static void main(String[] args) {
        // TODO Auto-generated method stub
        int val2[] = new int[7];
        int min = 0, max = 0;

        // input
        for (int x = 0; x <= 6; x++) {
            val2[x] = 1 + (int) (Math.random() * 9);
        }

        for (int x = 0; x <= 6; x++) {
            System.out.print("[" + val2[x] + "]  ");
        }

        // MISSING CODE HERE
        // Initializing to the first index of the array in lieu to zero in case of zero not being part of the array
        min = val2[0];
        max = val2[0];
        for (int number : val2) {
            min = number < min ? number : min;
            max = number > max ? number : max;
        }

        // output
        System.out.println("\n\nThe smallest number in the array: " + min);
        System.out.println("The largest number in the array: " + max);

        System.exit(0);
    }
}

