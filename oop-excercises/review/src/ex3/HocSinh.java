package ex3;

public class HocSinh {
	private String maHS;
	private String tenHS;
	private String diaChi;
	private double diemToan;
	private double diemVan;
	
	public HocSinh() {}
	
	public HocSinh(String maHS, String tenHS, String diaChi, double diemToan, double diemVan) {
		this.maHS = maHS;
		this.tenHS = tenHS;
		this.diaChi = diaChi;
		this.diemToan = diemToan;
		this.diemVan = diemVan;
	}
	
	public double getDiemTB() {
		return (diemToan + diemVan) / 2;
	}
	
	@Override
	public String toString() {
		return "[maHS=" + maHS + ", tenHS=" + tenHS + ", diaChi=" + diaChi + ", diemToan=" + diemToan + ", diemVan=" + diemVan + ", diemTB=" + getDiemTB() + "]";
	}
}
