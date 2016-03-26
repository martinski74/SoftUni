import java.io.*;

public class SaveACustomObjectInFile {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ObjectOutputStream oos = new ObjectOutputStream(
                new FileOutputStream("resources/course.save"));
        ObjectInputStream ois = new ObjectInputStream(
                new FileInputStream("resources/course.save"));
        Course course = new Course("Programming", 220);
        oos.writeObject(course);
        Course readerObject = (Course) ois.readObject();
        readerObject.printInfo();
    }

}

