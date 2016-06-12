import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by martin on 7.4.2016 г..
 */
public class SumCards {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        ArrayList<Integer> cards = new ArrayList<>();

        for (int i = 0; i < input.length; i++) {
            String card = input[i].substring(0, 1);
            if (card.equals("1")) {
                card = "10";
            } else if (card.equals("J")) {
                card = "12";
            } else if (card.equals("Q")) {
                card = "13";
            } else if (card.equals("K")) {
                card = "14";
            } else if (card.equals("A")) {
                card = "15";
            }
            cards.add(Integer.parseInt(card));

        }
        int weight = 0;
        int counter=0;
        for (int i = 0; i < cards.size() - 1; i++) {
            if (!cards.get(i).equals(cards.get(i+1))){
                if (counter!=1){
                    weight += counter * cards.get(i)*2;
                }else {
                    weight += cards.get(i);
                }
                counter=1;
            } else {
                counter++;
            }

        }
        System.out.println(weight);
    }
}