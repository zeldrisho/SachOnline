package ex3;

import java.util.ArrayList;
import java.util.Scanner;

public class TestMain {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		ArrayList<HocSinh> dsHocSinh = new ArrayList<>();
		HocSinh hs;
		int choice;
		String maHS, tenHS, diaChi;
		double diemToan, diemVan;
		
		do {
			System.out.print("Nhap ma hoc sinh: ");
			maHS = sc.nextLine();
			System.out.print("Nhap ten hoc sinh: ");
			tenHS = sc.nextLine();
			System.out.print("Nhap dia chi: ");
			diaChi = sc.nextLine();
			System.out.print("Nhap diem toan: ");
			diemToan = sc.nextDouble();
			System.out.print("Nhap diem van: ");
			diemVan = sc.nextDouble();
			hs = new HocSinh(maHS, tenHS, diaChi, diemToan, diemVan);
			dsHocSinh.add(hs);
			System.out.print("Nhap 1 de tiep tuc hoac 0 de dung: ");
			choice = sc.nextInt();
			sc.nextLine();
		} while (choice == 1);
		
		int n = dsHocSinh.size(), k = 0;
		double max = dsHocSinh.get(0).getDiemTB();
		for (int i = 1; i < n; i++) {
			if (dsHocSinh.get(i).getDiemTB() > max) {
				max = dsHocSinh.get(i).getDiemTB();
				k = i;
			}
		}
		System.out.println("Hoc sinh co diem trung binh cao nhat: " + dsHocSinh.get(k));
		
		sc.close();
	}

}
