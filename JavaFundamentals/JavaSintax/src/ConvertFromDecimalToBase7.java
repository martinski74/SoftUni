import java.util.Locale;
import java.util.Scanner;

public class ConvertFromDecimalToBase7 {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        System.out.println(Integer.toString(a,7));

    }
}
