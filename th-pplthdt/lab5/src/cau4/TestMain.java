package cau4;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class TestMain {
    public static void main(String[] args) throws IOException {
        File file = new File("E:\\java\\th-pplthdt\\lab5\\src\\cau4\\test.txt");
        FileWriter writer = new FileWriter("E:\\java\\th-pplthdt\\lab5\\src\\cau4\\test.txt");
        if (file.exists()) {
            if (file.isDirectory()) {
                System.out.println("The directory exists");
            } else {
                System.out.println("The file exists");
                writer.write("Hello");

            }
        } else {
            if (file.isDirectory()) {
                System.out.println("The directory doesn't exists");
            } else {
                System.out.println("The file doesn't exists");
            }
        }
    }
}
