import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class CombineListOfLetters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char[]line1=scan.nextLine().replaceAll("\\W", "").toCharArray();
        char[]line2=scan.nextLine().replaceAll("\\W", "").toCharArray();

        ArrayList<Character> firstLine = new ArrayList<>();
        ArrayList<Character> secondLine = new ArrayList<>();

        for (char c : line1) {
            firstLine.add(c);
        }
        for (char c : line2) {
            secondLine.add(c);
        }
        List<Character> resultLine = new ArrayList<>(firstLine);

        for (Character character : secondLine) {
            if (!resultLine.contains(character)){
                firstLine.add(character);
            }
        }
        for (Character character : firstLine) {
            System.out.print(character+" ");
        }


    }
}
