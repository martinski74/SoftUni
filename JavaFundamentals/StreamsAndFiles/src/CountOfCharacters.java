import java.io.*;

public class CountOfCharacters {
    public static void main(String[] args) {
        try {
            BufferedReader bfr = new BufferedReader(new FileReader("resources/words.txt"));
            BufferedWriter bfw = new BufferedWriter(new FileWriter("resources/count-chars.txt"));
            String line = bfr.readLine().replaceAll("\\s+", "");

            String vowelsArr = "aeiou";
            String punctuationArr = "!,.?";
            int vowels = 0;
            int consonants = 0;
            int punktuation = 0;
            while (line != null) {
                for (int i = 0; i < line.length(); i++) {
                    if (vowelsArr.contains(line.charAt(i) + "")) {
                        vowels++;
                    } else if (punctuationArr.contains(line.charAt(i) + "")) {
                        punktuation++;
                    } else {
                        consonants++;
                    }
                }
                line = bfr.readLine();
            }
            bfw.write(String.format("Vowels: %d\n", vowels));
            bfw.write(String.format("Consonants: %d\n", consonants));
            bfw.write(String.format("Punctuation: %d\n", punktuation));
            bfr.close();
            bfw.close();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
