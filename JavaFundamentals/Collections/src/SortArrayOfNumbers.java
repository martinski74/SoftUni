import com.sun.org.apache.xpath.internal.SourceTree;

import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        int[]arrInt= new int[n];
        for (int i = 0; i < n; i++) {
            arrInt[i]= scan.nextInt();
        }
        Arrays.sort(arrInt);

        for (int i : arrInt) {
            System.out.print(i+" ");
        }
    }
}
