import java.util.Locale;
import java.util.Scanner;

public class CalcExpresion {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();
        // first expresion
        double number = (((a * a) + (b * b)) / ((a * a) - (b * b)));
        double power = (a + b + c) / Math.sqrt(c);
        double result1 = Math.pow(number, power);
        // second expresion
        double number2 = ((a * a) + (b * b) - (c * c * c));
        double power2 = a - b;
        double result2 = Math.pow(number2, power2);

        double avg1 = (a + b + c) / 3.0;
        double avg2 = (result1 + result2) / 2;
        double diff = Math.abs(avg1 - avg2);
        // output
        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", result1, result2, diff);


    }
}
