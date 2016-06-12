import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String text = sc.nextLine().toLowerCase();
        String word= sc.nextLine().toLowerCase();
        Pattern pattern= Pattern.compile("\\b" + word + "\\b");
        Matcher matcher = pattern.matcher(text);
        int counter=0;
        while (matcher.find()){
            counter++;
        }
        System.out.println(counter);
    }
}
