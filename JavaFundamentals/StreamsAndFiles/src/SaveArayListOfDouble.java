import java.io.*;
import java.util.ArrayList;
import java.util.Locale;

public class SaveArayListOfDouble {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        Locale.setDefault(Locale.ROOT);
        ObjectOutputStream oos =new ObjectOutputStream(new FileOutputStream("resources/doubles.list"));
        ObjectInputStream ois = new ObjectInputStream(new FileInputStream("resources/doubles.list"));

        ArrayList<Double> doubles= new ArrayList<>();
        doubles.add(1.1);
        doubles.add(3.4);
        doubles.add(5.12);
        oos.writeObject(doubles);
        oos.flush();

        System.out.println(ois.readObject());
        ois.close();
    }
}
