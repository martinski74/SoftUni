import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by martin on 8.4.2016 г..
 */
public class ExamScore {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        sc.nextLine();
        sc.nextLine();  // skiping firs 3 lines
        sc.nextLine();

        Map<Integer, TreeMap<String, Double>> points = new TreeMap<>();
        while (true){
            String[]input = sc.nextLine().split("\\s*\\|\\s*");
            if (input.length < 4){
                break;
            }
            String student = input[1];
            int score = Integer.parseInt(input[2]);
            double grade= Double.parseDouble(input[3]);

            if (!points.containsKey(score)){
                points.put(score,new TreeMap<>());
            }
            points.get(score).put(student, grade);

        }
        //print output

        for (Integer score : points.keySet()) {
            System.out.print(score + " -> ");
            System.out.print(points.get(score).keySet());
            double sum =0;
            for (Double grade : points.get(score).values()) {
                sum += grade;
            }
            double avg = sum / points.get(score).values().size();
            System.out.printf("; avg=%.2f\n",avg);
        }
    }
}
