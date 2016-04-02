import java.util.Scanner;
/* Write a program that enters an array of strings and
 * finds in it the largest sequence of equal elements.
 * If several sequences have the same longest length,
 * print the leftmost of them. The input strings are
 * given as a single line, separated by a space. */

public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split(" ");
        int maxLengt = 1;
        int count = 1;
        String largest = input[0];

        for (int i = 1; i < input.length; i++) {
            if (input[i].equals(input[i - 1])) {
                count++;
                if (count > maxLengt) {
                    maxLengt = count;
                    largest = input[i];
                }
            } else {
                count = 1;
            }

        }
        for (int j = 0; j < maxLengt; j++) {
            System.out.print(largest+" ");
        }
    }
}
