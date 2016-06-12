import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractEmails {
    public static void main(String[] args) {
       Scanner sc = new Scanner(System.in);
        String someText = sc.nextLine();
        Pattern emails = Pattern.compile("[A-Za-z]+[.-_]*[A-Za-z]+@[A-Za-z]+[-]*[.A-Za-z]+[A-Za-z]");
        Matcher mach = emails.matcher(someText);

        while (mach.find()){
            System.out.println(mach.group());
        }

    }

}
