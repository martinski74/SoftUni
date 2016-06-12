import com.sun.org.apache.xpath.internal.SourceTree;

import java.util.Scanner;

public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        System.out.print(input[0] + " ");
        for (int i = 1; i < input.length; i++) {
            if (input[i - 1].equals(input[i])) {
                System.out.print(input[i]+" ");
            }else {
                System.out.println();
                System.out.print(input[i]+" ");
            }
        }
    }
}
