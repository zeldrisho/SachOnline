package cau2;

import java.io.*;

public class TestMain {
    public static void main (String[] args) throws IOException {
        try {
            FileReader reader = new FileReader("E:\\java\\th-pplthdt\\lab5\\src\\cau2\\input.txt");
            String result = "";
            int data;
            int data2;
            while ((data = reader.read()) != -1) {
                data2 = Character.toUpperCase(data);
                result += (char)data2;
            }
            reader.close();
            System.out.println("OK");
            FileWriter writer = new FileWriter("E:\\java\\th-pplthdt\\lab5\\src\\cau2\\output.txt");
            writer.write(result);
            writer.flush();
            writer.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
