import java.util.Scanner;

public class CalculateN {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();

        System.out.println(factorial(n));
    }

    private static long factorial(int n) {
        if (n == 1 || n == 0) {
            return 1;
        }
        return n * factorial(n - 1);

    }
}
