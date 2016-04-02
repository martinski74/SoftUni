
import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;


public class FilterArray {
    public static void main(String[] args) throws IOException {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split("\\W+");
        Arrays.stream(input)
                .filter(p -> p.length()>3)
                .forEach(p -> System.out.printf("%s ",p));


    }
}
