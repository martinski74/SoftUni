import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class SaveArrayOfDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ArrayList<Double> doubles = new ArrayList<Double>();
        doubles.add(1.1);
        doubles.add(2.3);
        doubles.add(4.5);
        doubles.add(6.7);
        try (
                ObjectOutputStream ous = new ObjectOutputStream(
                        new BufferedOutputStream(
                                new FileOutputStream("resources/doubles.list")))

        ) {
            ous.writeObject(doubles);
        }
        ObjectInputStream ois = new ObjectInputStream(
                new BufferedInputStream(
                        new FileInputStream("resources/doubles.list")));

        System.out.println(ois.readObject().toString());

    }
}
