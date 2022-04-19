package ex1;

public class Triangle extends Point {
	private Point a;
	private Point b;
	private Point c;
	
	public Triangle() {}
	
	public Triangle(Point a, Point b, Point c) {
		this.a = a;
		this.b = b;
		this.c = c;
	}
	
	public double getAB() {
		return Math.sqrt(Math.pow(a.getX() - b.getX(), 2) + Math.pow(a.getY() - b.getY(), 2));
	}
	
	public double getBC() {
		return Math.sqrt(Math.pow(b.getX() - c.getX(), 2) + Math.pow(b.getY() - c.getY(), 2));
	}
	
	public double getAC() {
		return Math.sqrt(Math.pow(a.getX() - c.getX(), 2) + Math.pow(a.getY() - c.getY(), 2));
	}
	
	public boolean isTriangle() {
		if (getAB() + getBC() <= getAC()) {
			return false;
		}
		if (getBC() + getAC() <= getAB()) {
			return false;
		}
		if (getAB() + getAC() <= getBC()) {
			return false;
		}
		return true;
	}
}
