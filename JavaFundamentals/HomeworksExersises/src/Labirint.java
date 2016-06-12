import jdk.nashorn.internal.runtime.regexp.joni.ScanEnvironment;

import java.util.Scanner;

public class Labirint {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        String[]text = sc.nextLine().split("[\\W]+");
        System.out.println(text.length);
        int upCount=0;
        int lowCount= 0;
        for (String s : text) {

            if (s.equals(s.toLowerCase())){
                lowCount++;
            } if (s.equals(s.toUpperCase())){
                upCount++;
            }
        }
        System.out.println(upCount);
        System.out.println(lowCount);
    }
}
