import com.sun.xml.internal.fastinfoset.util.CharArray;

import java.util.Locale;
import java.util.Scanner;

public class OddEvenPairs {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner scan = new Scanner(System.in);
        String[] numbers = scan.nextLine().split(" ");

        if (numbers.length % 2 != 0) {
            System.out.println("Invalid length");
        } else {
            for (int i = 0; i < numbers.length; i += 2) {
                int first = Integer.parseInt(numbers[i]);
                int second = Integer.parseInt(numbers[i + 1]);

                String text = "different";
                if (first % 2 == 0 && second % 2 == 0) {
                    text = "both are even";
                } else if (first % 2 != 0 && second % 2 != 0) {
                    text = "both are odd";
                }
                System.out.printf("%d, %d -> %s\n",first,second,text);
            }

        }

    }
}
