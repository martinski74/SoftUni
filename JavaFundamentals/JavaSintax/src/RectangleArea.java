import java.util.Locale;
import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter a: ");
        int a = sc.nextInt();
        System.out.print("Enter b: ");
        int b = sc.nextInt();
        int area = a * b;
        System.out.println("Area is: " + area);
    }
}
