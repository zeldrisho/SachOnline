package ex4;

import java.util.ArrayList;
import java.util.Scanner;

public class TestMain {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		ArrayList<SinhVien> dsSV = new ArrayList<>();
		SinhVien sv;
		int choice, heDaoTao;
		String maSV, tenSV;
		double diemTB;
		
		do {
			System.out.print("Nhap ma sinh vien: ");
			maSV = sc.nextLine();
			System.out.print("Nhap ten sinh vien: ");
			tenSV = sc.nextLine();
			System.out.print("Nhap 0 la he cu nhan tai nang, 1 la he chinh quy, 2 la he chat luong cao: ");
			heDaoTao = sc.nextInt();
			System.out.print("Nhap diem trung binh: ");
			diemTB = sc.nextDouble();
			sv = new SinhVien(maSV, tenSV, heDaoTao, diemTB);
			dsSV.add(sv);
			System.out.print("Nhap 1 de tiep tuc, 0 de dung: ");
			choice = sc.nextInt();
			sc.nextLine();
		} while (choice == 1);
		
		int n = dsSV.size();
		double sum = 0;
		for (int i = 0; i < n; i++) {
			sum += dsSV.get(i).getHocBong();
		}
		System.out.print("Tong tien hoc bong: " + sum);
		
		sc.close();
	}

}
