package cau2;

public class Square extends Rectangle{
    public Square() {}

    public Square(double side) {
        setWidth(side);
        setLength(side);
    }

    public Square(double side, String color, boolean filled) {
        super(side, side, color, filled);
    }

    public double getSide() {
        return getWidth();
    }

    public void setSide(double side) {
        setWidth(side);
        setLength(side);
    }

    @Override
    public void setWidth(double side) {
        super.setWidth(side);
    }

    @Override
    public void setLength(double side) {
        super.setLength(side);
    }

    @Override
    public boolean equals(Shape s) {
        return super.equals(s);
    }

    @Override
    public double getLength() {
        return super.getLength();
    }

    @Override
    public String toString() {
        return "Square[" + super.toString() + "]";
    }
}
