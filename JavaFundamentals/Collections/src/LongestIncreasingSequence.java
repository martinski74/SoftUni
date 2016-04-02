import java.util.Scanner;

//Write a program to find all increasing sequences inside an array of integers. The integers are
//given in a single line, separated by a space. Print the sequences in the order of their appearance
//in the input array, each at a single line. Separate the sequence elements by a space. Find also
//the longest increasing sequence and print it at the last line. If several sequences have the same
//longest length, print the leftmost of them.
public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] numbersAsString = scan.nextLine().split(" ");
        int[] numbers = new int[numbersAsString.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(numbersAsString[i]);
        }
        int largestSeq = 1;
        int temp = 1;
        int index = 0;
        System.out.print(numbers[0]);
        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i] > numbers[i - 1]) {
                temp++;
                System.out.print(" " + numbers[i]);
            } else {
                temp = 1;
                System.out.println();
                System.out.print(numbers[i]);
            }
            if (temp > largestSeq) {
                largestSeq = temp;
                index = i;
            }

        }
        System.out.println();
        System.out.print("Longest: ");
        for (int i = 0; i <largestSeq ; i++) {
            System.out.print(numbers[index-largestSeq+1+i]+ " ");
        }

    }
}
