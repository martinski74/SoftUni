import java.util.Scanner;

public class CountAllWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] text = sc.nextLine().split("\\W+");
        System.out.println(text.length);

    }
}
