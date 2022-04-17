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
        double width = sc.nextDouble();
        System.out.print("Enter height: ");
        double height = sc.nextDouble();
        System.out.println("Area of a rectangle: " + width * height);
        sc.close();
    }

    public static void convertFtoC() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter temperature in Fahrenheit: ");
        double fahrenheit = sc.nextDouble();
        double celsius = (fahrenheit - 32) / 1.8;
        System.out.println("Temperature in Celsius: " + celsius);
        sc.close();
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
        sc.close();
    }

    public static void findMinOfThree() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter first number: ");
        double num1 = sc.nextDouble();
        System.out.print("Enter second number: ");
        double num2 = sc.nextDouble();
        System.out.print("Enter third number: ");
        double num3 = sc.nextDouble();
        if (num1 < num2 && num1 < num3) {
            System.out.println("Min: " + num1);
        } else if (num2 < num1 && num2 < num3) {
            System.out.println("Min: " + num2);
        } else {
            System.out.println("Min: " + num3);
        }
        sc.close();
    }

    public static void checkEvenOdd() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter number: ");
        double num = sc.nextDouble();
        if (num % 2 == 0) {
            System.out.println("Even");
        } else {
            System.out.println("Odd");
        }
        sc.close();
    }

    public static void checkAlphanumberic() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter string: ");
        char c = sc.next().charAt(0);
        if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= '9') {
            System.out.println("Alphanumeric");
        } else {
            System.out.println("Not alphanumeric");
        }
        sc.close();
    }

    public static void checkEdgesOfTriangle() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter first side: ");
        double side1 = sc.nextDouble();
        System.out.print("Enter second side: ");
        double side2 = sc.nextDouble();
        System.out.print("Enter third side: ");
        double side3 = sc.nextDouble();
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1) {
            System.out.println("Triangle");
        } else {
            System.out.println("Not a triangle");
        }
        sc.close();
    }

    public static void calculatePercentage() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter Physics mark: ");
        double physics = sc.nextDouble();
        System.out.print("Enter Chemistry mark: ");
        double chemistry = sc.nextDouble();
        System.out.print("Enter Biology mark: ");
        double biology = sc.nextDouble();
        System.out.print("Enter Mathematics mark: ");
        double mathematics = sc.nextDouble();
        System.out.print("Enter Computer mark: ");
        double computer = sc.nextDouble();
        double percentage = (physics + chemistry + biology + mathematics + computer) / 5;
        if (percentage > 0.9) {
            System.out.println("Grade A");
        } else if (percentage > 0.8) {
            System.out.println("Grade B");
        } else if (percentage > 0.7) {
            System.out.println("Grade C");
        } else if (percentage > 0.6) {
            System.out.println("Grade D");
        } else if (percentage > 0.4) {
            System.out.println("Grade E");
        } else {
            System.out.println("Grade F");
        }
        sc.close();
    }

    public static void findFirstAndLastDigit() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter numer: ");
        int num = sc.nextInt();
        int firstDigit = num;
        do {
            firstDigit /= 10;
        } while (firstDigit > 10);
        int lastDigit = num % 10;
        System.out.println("First digit: " + firstDigit);
        System.out.println("Last digit: " + lastDigit);
        sc.close();
    }

    public static void getSumAndProductOfDigits() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter numer: ");
        int num = sc.nextInt();
        int sum = 0;
        int product = 1;
        while (num > 0) {
            int digit = num % 10;
            sum += digit;
            product *= digit;
            num /= 10;
        }
        System.out.println("Sum: " + sum);
        System.out.println("Product: " + product);
        sc.close();
    }

    public static void getRemainderOfDivision() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter numer: ");
        int num = sc.nextInt();
        System.out.print("Enter divisor: ");
        int divisor = sc.nextInt();
        int remainder = num % divisor;
        System.out.println("Remainder: " + remainder);
        sc.close();
    }

    public static void countDigits() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter numer: ");
        int num = sc.nextInt();
        int count = 0;
        while (num > 0) {
            num /= 10;
            count++;
        }
        System.out.println("Number of digits: " + count);
        sc.close();
    }

    public static void reverseNumber() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter numer: ");
        int num = sc.nextInt();
        int reverse = 0;
        while (num > 0) {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num /= 10;
        }
        System.out.println("Reverse: " + reverse);
        sc.close();
    }

    public static void checkPalindrome() {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter numer: ");
        int num = sc.nextInt();
        int origin = num;
        int reverse = 0;
        while (num > 0) {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num /= 10;
        }
        if (origin == reverse) {
            System.out.println("Palindrome");
        } else {
            System.out.println("Not a palindrome");
        }
        sc.close();
    }

    public static void menu() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Choose exercise: Enter 1 - 15");
        System.out.print("Enter your choice: ");
	    int choice = sc.nextInt();
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
            case 6:
                checkEvenOdd();
                break;
            case 7:
                checkAlphanumberic();
                break;
            case 8:
                checkEdgesOfTriangle();
                break;
            case 9:
                calculatePercentage();
                break;
            case 10:
                findFirstAndLastDigit();
                break;
            case 11:
                getSumAndProductOfDigits();
                break;
            case 12:
                getRemainderOfDivision();
                break;
            case 13:
                countDigits();
                break;
            case 14:
                reverseNumber();
                break;
            case 15:
                checkPalindrome();
                break;
            default:
                System.out.println("Invalid choice");
        }
        sc.close();
    }

    public static void main(String[] args) {
        menu();
    }
}
