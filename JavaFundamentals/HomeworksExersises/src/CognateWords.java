import java.util.ArrayList;
import java.util.HashSet;
import java.util.Scanner;

/**
 * Created by martin on 8.4.2016 г..
 */
public class CognateWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split("[^a-zA-Z]+");
        HashSet<String>output =new HashSet<>();

        for (int a = 0; a < input.length; a++) {
            for (int b = 0; b < input.length; b++) {
                for (int c = 0; c < input.length; c++) {
                    if (a != b) {
                        if ((input[a] + input[b]).equals(input[c])) {
                            output.add(input[a] + "|" + input[b] + "=" + input[c]);
                        }
                    }
                }
            }

        }
        if (output.isEmpty()) {
            System.out.println("No");
        } else {
            for (String s : output) {
                System.out.println(s);
            }
        }
    }
}
