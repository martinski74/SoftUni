import java.util.Locale;
import java.util.Scanner;

public class FromBase7ToDecimal {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        int a = Integer.parseInt(sc.nextLine(),7);
        System.out.println(Integer.toString(a,10));
    }
}
