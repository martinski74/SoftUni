import sun.plugin2.gluegen.runtime.StructAccessor;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class StartsEndsWithCapitalLetters {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input= sc.nextLine();
        Pattern pattern = Pattern.compile("\\b[A-Z][a-zA-Z]*[A-Z]\\b");
        Matcher matcher = pattern.matcher(input);

        while (matcher.find()){
            System.out.print(matcher.group()+" ");
        }
    }
}
