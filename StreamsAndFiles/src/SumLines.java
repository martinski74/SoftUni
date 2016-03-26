import java.io.*;

public class SumLines {
    public static void main(String[] args) {
        File file = new File("resources/lines.txt");
        try {
            BufferedReader bfr = new BufferedReader(new FileReader(file));
            String line= bfr.readLine();
            while (line!=null){
                int sum=0;
                for (int i = 0; i <line.length() ; i++) {
                    sum+=line.charAt(i);
                }
                line= bfr.readLine();
                System.out.println(sum);
            }



        } catch (FileNotFoundException e) {
            System.out.println("File not found.");
        } catch (IOException e) {
            System.out.println("Can not read file.");
        }
    }
}
