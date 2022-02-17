import java.util.Scanner;

public class Ex2B {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String s1 = sc.nextLine();
        String s2 = sc.nextLine();
        StringBuilder sb1 = new StringBuilder(s1);
        StringBuilder sb2 = new StringBuilder(s2);
        StringBuilder sb = sb1.append(sb2);
        System.out.println(sb.toString());
        sc.close();
    }
}
