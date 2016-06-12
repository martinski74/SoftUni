import java.util.Arrays;
import java.util.Scanner;

public class SortArray {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.length ; i++) {
            numbers[i]= sc.nextInt();
        }
        Arrays.sort(numbers);
        for (int number : numbers) {
            System.out.print(number+" ");
        }
    }
}
