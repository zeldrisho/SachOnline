package ex2;

public class MatHang {
	private String tenHang;
	private int loaiHang;
	private double donGia;
	private int soLuong;
	
	public MatHang() {}
	
	public MatHang(String tenHang, int loaiHang, double donGia, int soLuong) {
		this.tenHang = tenHang;
		this.loaiHang = loaiHang;
		this.donGia = donGia;
		this.soLuong = soLuong;
	}
	
	public double getThanhTien() {
		if (loaiHang == 1) {
			return donGia * 1.05 * soLuong;
		}
		return donGia * 0.95 * soLuong;
	}
}
