package cau3;

import java.io.*;
import java.lang.*;
import java.util.Scanner;

public class TestMain {
    public static void main (String[] args) throws IOException {
        try {
            FileReader reader = new FileReader("E:\\java\\th-pplthdt\\lab5\\src\\cau3\\input.txt");
            int data, sum = 0;
            Scanner myReader = new Scanner(reader);
            while (myReader.hasNextLine()) {
                data = myReader.nextInt();
                sum += data;
            }
            System.out.println("OK");
            FileWriter writer = new FileWriter("E:\\java\\th-pplthdt\\lab5\\src\\cau3\\output.txt");
            String res = Integer.toString(sum);
            writer.write(res);
            writer.flush();
            writer.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
