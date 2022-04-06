package cau2;

public class Truck implements Vehicle {
	@Override
	public void move() {
		System.out.println("Truck is moving");
	}
	
	class Vehicle {
		String getVehicle() {
			return "Truck";
		}
	}
}
