import java.util.Scanner;
import java.util.StringTokenizer;

public class Ex2 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String s = sc.nextLine();
        StringTokenizer stok = new StringTokenizer(s);
        System.out.println(stok.countTokens());
        sc.close();
    }
}
