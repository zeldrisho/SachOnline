class Number {
    private int n = 10;
    public int add () {
        return n;
    }
}

class Interger extends Number {
    public int add (int n) {
        return super.add () + n;
    }
}

public class Hello {
    public static void main(String[] args) {
        Interger n = new Interger ();
         System.out.println(n.add ());
    }
}
