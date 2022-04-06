package cau1;

import java.util.Scanner;

public class TestMain {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        try {
            int a = sc.nextInt();
            int b = sc.nextInt();
            Calculator cal = new Calculator();
            System.out.println(cal.divide(a, b));
        } catch (ArithmeticException e) {
            System.out.println("divide by zero");
        };
    }
}

