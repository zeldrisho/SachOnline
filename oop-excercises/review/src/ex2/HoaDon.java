package ex2;

import java.util.ArrayList;

public class HoaDon extends MatHang {
	private String maHD;
	private String nguoiMuaHang;
	private String ngayLapHD;
	private ArrayList<MatHang> dsMatHang = new ArrayList<MatHang>();
	
	public HoaDon() {}
	
	public HoaDon(String maHD, String nguoiMuaHang, String ngayLapHD, ArrayList<MatHang> dsMatHang) {
		this.maHD = maHD;
		this.nguoiMuaHang = nguoiMuaHang;
		this.ngayLapHD = ngayLapHD;
		this.dsMatHang = dsMatHang;
	}
	
	public double getTongTienHD() {
		int n = dsMatHang.size();
		double sum = 0;
		for (int i = 0; i < n; i++) {
			sum += dsMatHang.get(i).getThanhTien();
		}
		return sum;
	}
}
