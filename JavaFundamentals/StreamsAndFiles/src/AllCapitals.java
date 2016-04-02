import java.io.*;

public class AllCapitals {
    public static void main(String[] args) throws FileNotFoundException, IOException {
        File file = new File("resources/lines2.txt");
        BufferedReader bfr = new BufferedReader(new FileReader(file));
        String line = bfr.readLine();
        String ressultUp = "";
        while (line != null) {
            ressultUp += line.toUpperCase() + "\n";

            line = bfr.readLine();
        }
        PrintWriter print = new PrintWriter(new FileWriter("resources/lines2.txt"));
        print.write(ressultUp);
        bfr.close();
        print.close();

    }
}