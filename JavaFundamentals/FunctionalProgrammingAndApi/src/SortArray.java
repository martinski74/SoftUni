import java.util.Arrays;
import java.util.Scanner;

public class SortArray {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] numbers = scan.nextLine().split("\\s+");
        String order = scan.nextLine();

        if (order.equals("Ascending")){
            Arrays.stream(numbers)
                    .sorted((a,b) -> a.compareTo(b))
                    .forEach(System.out::print);
        }else {
            Arrays.stream(numbers)
                    .sorted((a,b) -> b.compareTo(a))
                    .forEach(System.out::print);
        }
    }
}
