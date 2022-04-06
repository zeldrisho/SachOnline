package cau3;

public class Test {
    public static void main(String[] args) {
        Movable m = new MovablePoint(3, 4, 5, 6);
        System.out.println(m.toString());
        m.moveUp();
        System.out.println(m.toString());
        m= new MovableCircle(4, 5, 6, 7, 8);
        System.out.println(m.toString());
        m.moveRight();
        System.out.println(m.toString());
    }
}

