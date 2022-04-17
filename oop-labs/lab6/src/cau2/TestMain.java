package cau2;

public class TestMain {
	
	public static void main(String[] args) {
		String vehicleType = "truck";
		VehicleFactory vf = new VehicleFactory();
		Vehicle vehicle = vf.getVehicle(vehicleType);
		vehicle.move();
	}

}
