import java.util.Locale;
import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        int a = Integer.parseInt(sc.nextLine());
        double b = sc.nextDouble();
        double c = sc.nextDouble();
        String strA = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
        System.out.printf("|%-10X|", a);
        System.out.printf("%10s|", strA);
        System.out.printf("%10.2f|", b);
        System.out.printf("%-10.3f|", c);

    }
}
