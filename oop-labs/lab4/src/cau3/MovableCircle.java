package cau3;

public class MovableCircle extends MovablePoint {
    private int radius;
    private MovablePoint center;

    public MovableCircle(int x, int y, int xSpeed, int ySpeed, int radius) {
        super(x, y, xSpeed, ySpeed);
        this.radius = radius;
    }

    @Override
    public String toString() {
        return "MovableCircle[radius=" + radius + ",center=[" + super.toString();
    }

    @Override
    public void moveUp() {
        setY(getY() + getySpeed());
    }

    @Override
    public void moveDown() {
        setY(getY() - getySpeed());
    }

    @Override
    public void moveLeft() {
        setX(getX() - getxSpeed());
    }

    @Override
    public void moveRight() {
        setX(getX() + getxSpeed());
    }
}