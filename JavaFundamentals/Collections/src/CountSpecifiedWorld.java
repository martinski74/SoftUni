import java.util.Scanner;

public class CountSpecifiedWorld {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] inputText = scan.nextLine().split("\\W+");
        String word = scan.nextLine();
        int count = 0;
        for (String s : inputText) {
            if (s.equalsIgnoreCase(word)) {
                count++;
            }
        }
        System.out.println(count);
    }
}
