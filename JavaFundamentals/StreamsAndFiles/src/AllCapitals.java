import java.io.*;

public class AllCapitals {
<<<<<<< HEAD
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
=======
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
>>>>>>> df17aa815b4b88f27a7f10ad520adae7f0781a6e
