import java.io.*;

public class CopyJpgFile {
    public static void main(String[] args) {

        File file = new File("resources/pic.jpg");
        File file1 = new File("resources/copy.jpg");
        try {
            FileInputStream fis = new FileInputStream(file);
            FileOutputStream fos = new FileOutputStream(file1);

            byte[]buffer = new byte[(int)file.length()];
            fis.read(buffer);
            fos.write(buffer);

        } catch (FileNotFoundException e) {
            System.err.println("File not found");
        } catch (IOException e) {
            System.err.println("Cannot read file");
        }


    }
}
