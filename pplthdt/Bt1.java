import java.util.Scanner;

public class Hello {
    public static int getNumberWords(String s) {
        int cnt = 0;
        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) == ' ') {
                cnt++;
            }
        }
        return cnt + 1;
    }

    public static String getFirstName(String s) {
        int cnt = 0;
        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) != ' ' && s.charAt(i) != '\n' && s.charAt(i) != '\t') {
                cnt++;
            } else {
                break;
            }
        }
        return s.substring(0, cnt);
    }

    public static String getLastName(String s) {
        int cnt = 0;
        for (int i = s.length() - 1; i >= 0; i--) {
            if (s.charAt(i) != ' ' && s.charAt(i) != '\n' && s.charAt(i) != '\t') {
                cnt++;
            } else {
                break;
            }
        }
        return s.substring(s.length() - cnt);
    }

    public static String getMiddleName(String s) {
        int cnt = 0;
        for (int i = 0; i < s.length(); i++) {
            if (s.charAt(i) != ' ' && s.charAt(i) != '\n' && s.charAt(i) != '\t') {
                cnt++;
            } else {
                break;
            }
        }
        int cnt2 = 0;
        for (int i = s.length() - 1; i >= 0; i--) {
            if (s.charAt(i) != ' ' && s.charAt(i) != '\n' && s.charAt(i) != '\t') {
                cnt2++;
            } else {
                break;
            }
        }
        return s.substring(cnt + 1, s.length() - cnt2);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String s = sc.nextLine();
        System.out.println("Number of words: " + getNumberWords(s));
        System.out.println("First name: " + getFirstName(s));
        System.out.println("Middle name: " + getMiddleName(s));
        System.out.println("Last name: " + getLastName(s));
    }
}

