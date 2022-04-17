package cau5;

import java.nio.file.Files;
import java.nio.file.Paths;

public class TestMain {
    public static void main(String[] args) {
        Employee emp1 = new Employee("1", "employ1", 10);
        Employee emp2 = new Employee("2", "employ2", 20);
        String pathToInput = "E:\\java\\th-pplthdt\\lab5\\src\\cau5\\data.txt";
//        Files.write(Paths.get(pathToInput), emp1.getBytes());
    }
}
