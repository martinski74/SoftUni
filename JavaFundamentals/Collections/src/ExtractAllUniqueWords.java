import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] text = scan.nextLine().toLowerCase().split("\\W+");

        Set<String> uniqueWords = new TreeSet<>();
        for (String s : text) {
            uniqueWords.add(s);
        }
        System.out.println(String.join(" ",uniqueWords));

    }
}
