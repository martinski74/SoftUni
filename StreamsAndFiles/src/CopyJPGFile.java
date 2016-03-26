import java.io.*;

public class CopyJPGFile {
    public static void main(String[] args) throws IOException {
        File input=new File("resources/mini.jpg");
        File output=new File("resources/copied-pictur.jpg");
        FileInputStream fis = new FileInputStream(input);
        FileOutputStream fos = new FileOutputStream(output);

        byte[]buffer= new byte[(int)input.length()];
        fis.read(buffer);
        fos.write(buffer);
        fis.close();
        fos.close();

    }
}
