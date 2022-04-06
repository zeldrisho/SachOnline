package cau2;

public class Car implements Vehicle {
	@Override
	public void move() {
		System.out.println("Car is moving");
		
	}
	
	class Vehicle {
		String getVehicle() {
			return "Car";
		}
	}
}
