import java.io.*;

public class AllCapitals {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new FileReader("resources/lines2.txt"));

        String newLine = "";
        String line = reader.readLine();
        while (line != null) {
            newLine += line.toUpperCase() + "\r\n";
            line = reader.readLine();
        }
        BufferedWriter writer = new BufferedWriter(new FileWriter("resources/lines2.txt"));
        writer.write(newLine);
        writer.flush();
        reader.close();
        writer.close();

    }
}
