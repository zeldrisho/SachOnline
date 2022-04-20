package ex4;

public class SinhVien {
	private String maSV;
	private String tenSV;
	private int heDaoTao;
	private double diemTB;
	
	public SinhVien() {}
	
	public SinhVien(String maSV, String tenSV, int heDaoTao, double diemTB) {
		this.maSV = maSV;
		this.tenSV = tenSV;
		this.heDaoTao = heDaoTao;
		this.diemTB = diemTB;
	}
	
	public double getHocBong() {
		if (diemTB >= 9) {
			if (heDaoTao == 0) {
				return 1500000;
			}
			if (heDaoTao == 1) {
				return 2000000;
			}
			return 2500000;
		}
		if (diemTB >= 8) {
			if (heDaoTao == 0) {
				return 1000000;
			}
			if (heDaoTao == 1) {
				return 1500000;
			}
			return 2000000;
		}
		return 0;
	}
}
