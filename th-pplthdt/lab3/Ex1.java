import java.util.Scanner;
import java.util.StringTokenizer;

public class Ex1 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String fullName = sc.nextLine();
        
        StringTokenizer stok = new StringTokenizer(fullName);
        String firstName = stok.nextToken();

        // StringBuilder middleName = new StringBuilder();
        String lastName = stok.nextToken();
        while (stok.hasMoreTokens()) {
            // middleName.append(lastName + " ");
            lastName = stok.nextToken();
        }

        System.out.println(firstName);
        // System.out.println(middleName.toString().trim());
        System.out.println(lastName);

        sc.close();
    }
}
