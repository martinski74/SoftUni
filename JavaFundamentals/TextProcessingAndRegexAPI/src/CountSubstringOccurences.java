import java.util.Scanner;

public class CountSubstringOccurences {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String text = sc.nextLine().toLowerCase();
        String substr = sc.nextLine().toLowerCase();

        int counter = 0;
        int substrLengt = text.length() - substr.length();
        for (int i = 0; i <= substrLengt; i++) {
            if (text.substring(i, i + substr.length()).equals(substr)) {
                counter++;
            }
        }
        System.out.println(counter);

    }
}
