class A {
    public int x = 10;
    public void display () {
        System.out.println(this.x);
    }
}

class B extends A {
    public int x = 20;
}

public class Quiz {
    public static void main(String[] args) {
        B b = new A();
        b.display ();
    }
}
