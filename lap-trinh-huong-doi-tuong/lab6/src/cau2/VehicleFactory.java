package cau2;

public class VehicleFactory {
	public Vehicle getVehicle(String type) {
		Vehicle vehicle = null;
		if (type == "car") {
			vehicle = new Car();
		} else if (type == "truck") {
			vehicle = new Truck();
		}
		return vehicle;
	}
}
