import java.io.*;

public class sumLines {
    public static void main(String[] args) throws IOException {
        File file = new File("resources/lines.txt");
        BufferedReader bfr = new BufferedReader(new FileReader(file));
        String line = bfr.readLine();
        while (line != null) {
            int sum = 0;
            for (int i = 0; i < line.length(); i++) {
                sum += line.charAt(i);
            }
            System.out.println(sum);

            line = bfr.readLine();
        }
        bfr.close();

    }
}
