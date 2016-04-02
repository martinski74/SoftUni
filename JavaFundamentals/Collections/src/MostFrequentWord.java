import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().toLowerCase().split("\\W+");
        Map<String, Integer> wordCounter = new TreeMap<>();

        int maxCount = 0;
        for (String word : input) {
            Integer wordCount = wordCounter.get(word);
            if (wordCount == null) {
                wordCount = 0;
            }
            wordCounter.put(word, wordCount + 1);
        }

        int maxValue=0;
        for (Integer integer : wordCounter.values()) {
            if (integer > maxValue){
                maxValue=integer;
            }
        }
        for (Map.Entry<String,Integer>strIntegerEntry:wordCounter.entrySet()){
            if (strIntegerEntry.getValue() == maxValue){
                System.out.println(strIntegerEntry.getKey()+" -> "+maxValue+" times");
            }
        }
    }
}
