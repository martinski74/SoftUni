import java.io.*;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class CreateZipArchive {
    public static void main(String[] args) throws IOException {
        ZipOutputStream zos= new ZipOutputStream(new FileOutputStream("resources/res/text-file.zip"));
        FileInputStream fis = new FileInputStream(new File("resources/res/words.txt"));
        int buffer=fis.read();
        zos.putNextEntry(new ZipEntry("words.txt"));
        while (buffer!=-1){
            zos.write(buffer);
        }
        zos.closeEntry();
        zos.putNextEntry(new ZipEntry("count-chars.txt"));
        fis=new FileInputStream(new File("resources/res/count-chars.txt"));
        while ((buffer=fis.read())!=-1){
            zos.write(buffer);
        }
        zos.closeEntry();
        zos.putNextEntry(new ZipEntry("lines.txt"));
        fis= new FileInputStream("recources/res/lines.txt");
        while ((buffer=fis.read())!=-1){
            zos.write(buffer);
        }
        zos.closeEntry();
        zos.finish();
        zos.close();
    }
}
