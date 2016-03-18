import java.util.Scanner;

public class HitTheTarget {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int target = Integer.parseInt(scan.nextLine());
        for (int a = 1; a <= 20; a++) {
            for (int b = 1; b <= 20; b++) {
                if ((a + b) == target) {
                    System.out.printf("%d + %d = %d", a, b, target);
                    System.out.println();
                } else if ((a - b) == target){
                    System.out.printf("%d - %d = %d", a, b, target);
                    System.out.println();
                }
            }
        }
    }
}
