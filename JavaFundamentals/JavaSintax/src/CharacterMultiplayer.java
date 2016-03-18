import java.util.Scanner;

public class CharacterMultiplayer {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] str = scan.nextLine().split(" ");

        int sum = getCharCodeSum(str[0], str[1]);
        System.out.println(sum);


    }

    public static int getCharCodeSum(String str1, String str2) {
        int sum = 0;
        int longerString = Math.max(str1.length(), str2.length());
        for (int i = 0; i < longerString; i++) {
            int code1 = 1;
            int code2 = 1;
            if (i < str1.length()) {
                code1 = str1.charAt(i);
            }
            if (i < str2.length()) {
                code2 = str2.charAt(i);
            }
            sum += code1 * code2;
        }
        return sum;
    }
}
