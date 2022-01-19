import java.util.Scanner;

public class Lab1 {
    public static void info() {
        System.out.println("Name: Ho Sy Gia Trung");
        System.out.println("Dob: 20/12/2002");
        System.out.println("Id: 2024801030101");
    }

    public static void getAreaOfRectangle() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter width: ");
        int width = sc.nextInt();
        System.out.print("Enter height: ");
        int height = sc.nextInt();
        System.out.println("Area of a rectangle: " + width * height);
    }

    public static void convertFtoC() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter temperature in Fahrenheit: ");
        double fahrenheit = sc.nextDouble();
        double celsius = (fahrenheit - 32) / 1.8;
        System.out.println("Temperature in Celsius: " + celsius);
    }

    public static void checkLeapYear() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter year: ");
        int year = sc.nextInt();
        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
            System.out.println("This is a leap year");
        } else {
            System.out.println("This is not a leap year");
        }
    }

    public static void findMinOfThree() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter first number: ");
        int num1 = sc.nextInt();
        System.out.print("Enter second number: ");
        int num2 = sc.nextInt();
        System.out.print("Enter third number: ");
        int num3 = sc.nextInt();
        if (num1 < num2 && num1 < num3) {
            System.out.println("Min: " + num1);
        } else if (num2 < num1 && num2 < num3) {
            System.out.println("Min: " + num2);
        } else {
            System.out.println("Min: " + num3);
        }
    }



    public static void menu() {
        Scanner input = new Scanner(System.in);
        System.out.println("Choose exercise: Enter 1 - 15");
        System.out.println("Enter your choice: ");
	    int choice = input.nextInt();
	    switch (choice) {
            case 1:
                info();
                break;
            case 2:
                getAreaOfRectangle();
                break;
            case 3:
                convertFtoC();
                break;
            case 4:
                checkLeapYear();
                break;
            case 5:
                findMinOfThree();
                break;
            default:
                System.out.println("Invalid choice");
        }
    }

    public static void main(String[] args) {
        menu();
    }
}
