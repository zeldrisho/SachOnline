package cau4;

public class Test {
    public static void main(String[] args) {
        GeometricObject g = new Circle(3);
        System.out.println(g);
        System.out.println(g.getPerimeter());
        System.out.println(g.getArea());

        Resizable r = new ResizableCircle(4);
        System.out.println(r);
        r.resize(150);
        System.out.println(r);
    }
}