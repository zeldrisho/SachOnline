package ex2;

import java.util.ArrayList;
import java.util.Scanner;

public class TestMain {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhap ma hoa don: ");
		String maHD = sc.nextLine();
		System.out.print("Nhap ten nguoi mua hang: ");
		String nguoiMuaHang = sc.nextLine();
		System.out.print("Nhap ngay lap hoa don: ");
		String ngayLapHD = sc.nextLine();
		
		ArrayList<MatHang> dsMatHang = new ArrayList<MatHang>();
		MatHang matHang;
		int choice;
		do {
        	System.out.print("Nhap ten hang: ");
        	String tenHang = sc.nextLine();
        	System.out.print("Nhap 1 la hang noi dia hoac 0 la hang nhap khau: ");
        	int loaiHang = sc.nextInt();
        	System.out.print("Nhap don gia: ");
        	double donGia = sc.nextDouble();
        	System.out.print("Nhap so luong: ");
        	int soLuong = sc.nextInt();
        	matHang = new MatHang(tenHang, loaiHang, donGia, soLuong);
        	dsMatHang.add(matHang);
        	System.out.print("Nhap 1 de tiep tuc hoac 0 de dung: ");
        	choice = sc.nextInt();
        	sc.nextLine(); // Add this between nextInt() and nextLine()
        } while (choice == 1);
        HoaDon hoaDon = new HoaDon(maHD, nguoiMuaHang, ngayLapHD, dsMatHang);
        System.out.println("Tong tien hoa don: " + hoaDon.getTongTienHD());
        
        sc.close();
	}

}
