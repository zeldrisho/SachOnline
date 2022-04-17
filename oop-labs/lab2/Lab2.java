import java.util.Scanner;

public class Lab2 {
    public static void createArray(int[] arr, int n) {
        Scanner sc = new Scanner(System.in);
        for (int i = 0; i < n; i++) {
            System.out.print("Enter arr[" + i + "]: ");
            arr[i] = sc.nextInt();
        }
    }

    public static void printArray(int[] arr, int n) {
        for (int i = 0; i < n; i++) {
            System.out.print(arr[i] + " ");
        }
    }

    public static int getIndex(int[] arr, int n, int x) {
        for (int i = 0; i < n; i++) {
            if (arr[i] == x) {
                return i;
            }
        }
        return -1;
    }

    public static void removeElementAndPrint(int[] arr, int n, int x) {
        int index = getIndex(arr, n, x);
        if (index == -1) {
            System.out.println("Element not found");
        } else {
            for (int i = index; i < n - 1; i++) {
                arr[i] = arr[i + 1];
            }
            System.out.print("Array after removing " + x + ": ");
            printArray(arr, n - 1);
        }
    }

    public static void insertElementAndPrint(int[] arr, int n, int x, int k) {
        n++;
        for (int i = n - 1; i > k; i--) {
            arr[i] = arr[i - 1];
        }            
        arr[k] = x;
        System.out.print("Array after inserting " + x + ": ");
        printArray(arr, n);
    }

    public static void menuExcercise1() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Choose part of exercise: Enter a - f");
        System.out.print("Enter your choice: ");
        char c = sc.next().charAt(0);
        System.out.print("Enter size of array: ");
        int n = sc.nextInt(), x;
        int[] arr = new int[n];
        createArray(arr, n);
        switch (c) {
            case 'a':
                System.out.print("Enter number to find index: ");
                x = sc.nextInt();
                System.out.println("Index of " + x + " is: " + getIndex(arr, n, x));
                break;
            case 'b':
                System.out.print("Enter number to remove: ");
                x = sc.nextInt();
                removeElementAndPrint(arr, n, x);
                break;
            case 'c':
                System.out.print("Enter number to insert: ");
                x = sc.nextInt();
                System.out.print("Enter index to insert: ");
                int k = sc.nextInt();
                insertElementAndPrint(arr, n, x, k);
                break;
            default:
                System.out.println("Invalid choice");
        }
        sc.close();
    }

    public static void menu() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Choose exercise: Enter 1 - 5");
        System.out.print("Enter your choice: ");
	    int choice = sc.nextInt();
	    switch (choice) {
            case 1:
                menuExcercise1();
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
