package ex1;

import java.util.Scanner;

public class TestMain {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Nhap toa do dinh thu nhat: ");
		double x = sc.nextDouble();
		double y = sc.nextDouble();
		Point a = new Point(x, y);
		System.out.println("Nhap toa do dinh thu hai: ");
		x = sc.nextDouble();
		y = sc.nextDouble();
		Point b = new Point(x, y);
		System.out.println("Nhap toa do dinh thu ba: ");
		x = sc.nextDouble();
		y = sc.nextDouble();
		Point c = new Point(x, y);
		Triangle triangle = new Triangle(a, b, c);
		
		if (triangle.isTriangle()) {
			System.out.println("Day la tam giac");
		} else {
			System.out.println("Day khong phai tam giac");
		}
		
		sc.close();
	}

}
