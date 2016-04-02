import java.io.*;

public class CountCharcterTypes {
    public static void main(String[] args) throws IOException {
        File file = new File("resources/words.txt");
        File file1 = new File("resources/count-chars.txt");
        BufferedReader bfr = new BufferedReader(new FileReader(file));
        BufferedWriter bfw = new BufferedWriter(new FileWriter(file1));
        String line = bfr.readLine().replaceAll("\\s+", "");


        int vowels = 0;
        int consonats = 0;
        int punctuation = 0;
        while (line != null) {
            for (int i = 0; i < line.length(); i++) {
                if (line.charAt(i) == 'a' || line.charAt(i) == 'e' || line.charAt(i) == 'i' || line.charAt(i) == 'o' || line.charAt(i) == 'u') {
                    vowels++;
                } else if (line.charAt(i) == '!' || line.charAt(i) == '?' || line.charAt(i) == '.' || line.charAt(i) == ',') {
                    punctuation++;
                } else {
                    consonats++;
                }
            }
            line = bfr.readLine();
        }
        bfw.write(String.format("Vowels: %d\n", vowels));
        bfw.write(String.format("Consonants: %d\n", consonats));
        bfw.write(String.format("Punctuation: %d\n", punctuation));
        bfr.close();
        bfw.close();
    }
}
