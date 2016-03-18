import java.util.Locale;
import java.util.Random;
import java.util.Scanner;

public class RandomizeNumbsFromNToM {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        int m = Integer.parseInt(sc.nextLine());
        Random rnd = new Random();
        for (int i = Math.min(n, m); i <= Math.max(n, m); i++) {
            int range = Math.abs(n - m + 1);                    // I am using the formila: rnd.nextInt(max-min+1)+min;
            int randomNumber = rnd.nextInt(range) + Math.min(n,m);
            System.out.print(randomNumber + " ");
        }
    }
}
