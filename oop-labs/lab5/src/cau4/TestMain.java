package cau4;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.Scanner;

public class TestMain {
    public static void main(String[] args) throws IOException {
        String pathToInput = "E:\\java\\th-pplthdt\\lab5\\src\\cau4\\test.txt";
        File file = new File(pathToInput);
        if (file.exists()) {
            if (file.isDirectory()) {
                System.out.println("The directory exists");
            } else {
                System.out.println("The file exists");
                System.out.println("Append text to an existing file");
                Files.write(Paths.get(pathToInput), "abc abcdef abcd".getBytes());

                String longestWord = "";
                String s;
                Scanner sc = new Scanner(file);
                while (sc.hasNext()) {
                    s = sc.next();
                    if (s.length() > longestWord.length()) {
                        longestWord = s;
                    }
                }
                System.out.println("The longest word in file is: " + longestWord);
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
