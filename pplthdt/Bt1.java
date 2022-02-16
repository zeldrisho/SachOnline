import java.util.Scanner;

public class Bt1 {
    public static int getNumberWords(String s) {
        int cnt = 0, n = s.length();
        for (int i = 0; i < n; i++) {
            if (s.charAt(i) == ' ') {
                cnt++;
            }
        }
        return cnt + 1;
    }

    public static String getFirstName(String s) {
        int cnt = 0, n = s.length();
        for (int i = 0; i < n; i++) {
            if (s.charAt(i) != ' ' && s.charAt(i) != '\n' && s.charAt(i) != '\t') {
                cnt++;
            } else {
                break;
            }
        }
        return s.substring(0, cnt);
    }

    public static String getLastName(String s) {
        int cnt = 0, n = s.length();
        for (int i = n - 1; i >= 0; i--) {
            if (s.charAt(i) != ' ' && s.charAt(i) != '\n' && s.charAt(i) != '\t') {
                cnt++;
            } else {
                break;
            }
        }
        return s.substring(n - cnt);
    }

    public static String getMiddleName(String s) {
        int cnt = 0, n = s.length();
        for (int i = 0; i < n; i++) {
            if (s.charAt(i) != ' ' && s.charAt(i) != '\n' && s.charAt(i) != '\t') {
                cnt++;
            } else {
                break;
            }
        }
        int cnt2 = 0;
        for (int i = n - 1; i >= 0; i--) {
            if (s.charAt(i) != ' ' && s.charAt(i) != '\n' && s.charAt(i) != '\t') {
                cnt2++;
            } else {
                break;
            }
        }
        return s.substring(cnt + 1, n - cnt2);
    }

    public static String capitalizeWord(String message) {  
        char[] charArray = message.toCharArray();
        boolean foundSpace = true;
        //sử dụng vòng lặp for để duyệt các phần tử trong charArray
        for(int i = 0; i < charArray.length; i++) {
          // nếu phần tử trong mảng là một chữ cái
          if(Character.isLetter(charArray[i])) {
            // kiểm tra khoảng trắng có trước chữ cái
            if(foundSpace) {
              //đổi chữ cái thành chữ in hoa bằng phương thức toUpperCase()
              charArray[i] = Character.toUpperCase(charArray[i]);
              foundSpace = false;
            }
          }
          else {
            foundSpace = true;
          }
        }
        // chuyển đổi mảng char thành string
        message = String.valueOf(charArray); 
        return message;
    }  

    public static String formalizeName(String s) {
        return s.trim().replaceAll(" +", " ");
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String s = sc.nextLine();
        System.out.println("1.Number of words: " + getNumberWords(s));
        System.out.println("2. First name: " + getFirstName(s));
        System.out.println("3. Last name: " + getLastName(s));
        System.out.println("4. Middle name: " + getMiddleName(s));
        System.out.println("5. Capitalize word: " + capitalizeWord(s));
        System.out.println("6. Formalize name: " + formalizeName(s));
        sc.close();
    }
}

