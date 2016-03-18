import java.util.Locale;
import java.util.Scanner;

public class GetAverage {
    public static void main(String[] args) {
        //Locale.setDefault(Locale.ROOT);
        Scanner input = new Scanner(System.in);
        double a = input.nextDouble();
        double b = input.nextDouble();
        double c = input.nextDouble();
        double avg = GetAverages(a, b, c);
        System.out.printf("%.2f\n",avg);
    }

    public static double GetAverages(double a, double b, double c) {
        double result = (a + b + c) / 3.0;
        return result;
    }
}
