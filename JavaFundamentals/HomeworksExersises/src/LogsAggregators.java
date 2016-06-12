import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


public class LogsAggregators {
    public static void main(String[] args) {

        String[] text = {"Test", "text", "words", "Count", "words", "Count", "teSt"};
        Scanner sc = new Scanner(text.toString());
        Map<String, Integer> wordsCount = new TreeMap<>();
        for (String word : text) {
            Integer count = wordsCount.get(word);
            if (count == null) {
                count = 0;
            }
            wordsCount.put(word, count + 1);
        }
        for (Map.Entry<String, Integer> wordEnty : wordsCount.entrySet()) {
            System.out.printf("word %s -> %d times.%n", wordEnty.getKey(), wordEnty.getValue());
        }

    }
}
