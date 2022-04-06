package cau1;

public class TestMain {

	public static void main(String[] args) {
		Student outerObject = new Student("Trung", "Binh Duong", "nam", 10);
		Student.StudentOperator innerObject = outerObject.new StudentOperator();
		innerObject.print();
		System.out.println("Type: " + innerObject.type());
	}

}
