package cau2;

public class Rectangle extends Shape {
    protected double length;
    protected double width;

    public Rectangle() {}

    public Rectangle(double length, double width) {
        this.length = length;
        this.width = width;
    }

    public Rectangle(double length, double width, String color, boolean filled) {
        super(color, filled);
        this.length = length;
        this.width = width;
    }

    public double getWidth() {
        return width;
    }

    public double getLength() {
        return length;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public void setLength(double length) {
        this.length = length;
    }

    @Override
    public double getArea() {
        return this. length * this.width;
    }

    public double getPerimeter() {
        return (this.length + this.width) * 2.0;
    }

    @Override
    public boolean equals() {
        return false;
    }

    public boolean equals(Shape s) {
        if (s instanceof Rectangle) {
            Rectangle rec = (Rectangle) s;
            return (this.getWidth() == rec.getWidth()) && (this.getLength() == rec.getLength());
        }
        return false;
    }

    public String toString() {
        return "Rectangle[" + super.toString() + ",width=" + width + ",length=" + length + "]";
    }
}

