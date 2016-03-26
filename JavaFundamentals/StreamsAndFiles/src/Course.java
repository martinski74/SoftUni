import java.io.Serializable;

public class Course implements Serializable {
    public String name;
    public Integer numberOfStudents;

    Course(String nameInput, Integer numberOfStudentsInput) {
        name = nameInput;
        numberOfStudents = numberOfStudentsInput;
    }
    public void printInfo() {
        System.out.println(name + " " + numberOfStudents);
    }

}
