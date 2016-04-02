import java.util.Scanner;
//Write a program to count the number of words in given sentence.
// Use any non-letter character as word separator.
public class CountAllWords {
    public static void main(String[] args) {
        Scanner scan =new Scanner(System.in);
        String[]input =scan.nextLine().split("\\W+");

        System.out.println(input.length);
    }
}
