import java.math.BigDecimal;
import java.util.Locale;
import java.util.Scanner;

public class SimpleExpression {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().trim().split("[ ]+");
        String inputStr = "";
        for (int i = 0; i < input.length; i++) {
            inputStr += input[i];
        }
        String[] digits = inputStr.split("[+-]+");
        String[] operstor = inputStr.split("[0123456789.]+");
        BigDecimal output = new BigDecimal(digits[0]);
        for (int i = 0; i < operstor.length - 1; i++) {
            if (operstor[i + 1].equals("+")) {
                output = output.add(new BigDecimal(digits[i + 1]));
            } else {
                output = output.subtract(new BigDecimal(digits[i + 1]));
            }
        }
        System.out.println(output);

    }
}
