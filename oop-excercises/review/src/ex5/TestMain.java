package ex5;

import java.util.Scanner;

public class TestMain {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int tu, mau;
		System.out.println("Nhap tu va mau cua phan so thu nhat: ");
		tu = sc.nextInt();
		mau = sc.nextInt();
		PhanSo ps1 = new PhanSo(tu, mau);
		System.out.println("Nhap tu va mau cua phan so thu hai: ");
		tu = sc.nextInt();
		mau = sc.nextInt();
		PhanSo ps2 = new PhanSo(tu, mau);
		
		int res1 = ps1.getTu() * ps2.getMau();
		int res2 = ps2.getTu() * ps1.getMau();
		if (res1 > res2) {
			System.out.println("Phan so " + ps1.getTu() + "/" + ps1.getMau() + " lon hon");
		} else if (res1 < res2) {
			System.out.println("Phan so " + ps2.getTu() + "/" + ps2.getMau() + " lon hon");
		} else {
			System.out.println("Hai phan so bang nhau");
		}
		
		sc.close();
	}

}
