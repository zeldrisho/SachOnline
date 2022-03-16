package cau2;

public class Test {
    public static void main(String[] args) {
        Shape s = new Rectangle(3, 4);
        System.out.println(s.toString());
        System.out.println("Area = " + s.getArea());
        s = new Circle(4);
        System.out.println(s.toString());
        System.out.println("Area = " + s.getArea());
        s = new Square(5);
        System.out.println(s.toString());
        System.out.println("Area = " + s.getArea());
    }
}
