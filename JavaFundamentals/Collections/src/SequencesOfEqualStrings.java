import java.util.Scanner;

public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split(" ");

        for (int i = 0; i < input.length; i++) {
            System.out.print(input[i]);
            for (int j = i+1; j <input.length ; j++) {
                if (input[j].equals(input[i])){
                    System.out.print(" "+input[j]);
                    i++;
                }
            }
            System.out.println();
        }

    }
}
