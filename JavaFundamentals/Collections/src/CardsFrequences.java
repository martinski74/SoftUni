import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class CardsFrequences {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split(" ");
        Map<String, Integer> cardsMap = new LinkedHashMap<>();

        for (String word : input) {
            String card = word.substring(0, word.length() - 1);
            Integer count = cardsMap.get(card);
            if (count == null) {
                count = 0;
            }
            cardsMap.put(card,count+1);
        }
        for (Map.Entry<String,Integer>stringIntegerEntry:cardsMap.entrySet()){
            double apeerinance = stringIntegerEntry.getValue()*100/input.length;
            System.out.printf("%s -> %.2f%%",stringIntegerEntry.getKey(),apeerinance);
            System.out.println();
        }

    }
}
