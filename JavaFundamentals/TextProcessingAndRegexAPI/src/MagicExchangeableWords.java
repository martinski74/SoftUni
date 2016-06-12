import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class MagicExchangeableWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");

        System.out.println(exchangeable(input));
    }

    private static boolean exchangeable(String[] input) {

        Map<Character, Character> exchangebleMap = new LinkedHashMap<>();
        for (int i = 0; i < input[0].length(); i++) {
            if (!exchangebleMap.containsKey(input[0].charAt(i))){
                exchangebleMap.put(input[0].charAt(i),input[1].charAt(i));
            }else if (!exchangebleMap.get(input[0].charAt(i)).equals(input[1].charAt(i))){
                return false;
            }
        }

        return true;
    }
}
