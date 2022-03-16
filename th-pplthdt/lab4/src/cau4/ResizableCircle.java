package cau4;

public class ResizableCircle extends Circle implements Resizable {
    public ResizableCircle(double radius) {
        super(radius);
    }

    @Override
    public void resize() {
    }

    public void resize(int percent) {
        setRadius(getRadius() * percent / 100);
    }
}