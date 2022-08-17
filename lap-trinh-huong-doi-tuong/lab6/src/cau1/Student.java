package cau1;

public class Student {
	private String name;
	private String address;
	private String sex;
	private double score;
	
	public Student() {}
	
	public Student(String name, String address, String sex, double score) {
		this.name = name;
		this.address = address;
		this.sex = sex;
		this.score = score;
	}
	
	public String getName() {
		return name;
	}
	
	public String getAddress() {
		return address;
	}
	
	public String getSex() {
		return sex;
	}
	
	public double getScore() {
		return score;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public void setAddress(String address) {
		this.address = address;
	}
	
	public void setSex(String sex) {
		this.sex = sex;
	}
	
	public void setScore(double score) {
		this.score = score;
	}
	
	class StudentOperator {
		void print() {
			System.out.println("Student[" + name + ", " + address + ", " + sex + ", " + score + "]");
		}
		
		String type() {
			if (score > 8) {
				return "A";
			}
			if (score >= 5) {
				return "B";
			}
			return "C";
		}
	}
}
