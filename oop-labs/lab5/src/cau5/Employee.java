package cau5;

public class Employee {
    public double basicSalary = 300;
    private String id;
    private String fullName;
    private double coefficientSalary;

    public Employee(String id, String fullName, double coefficientSalary) {
        this.id = id;
        this.fullName = fullName;
        this.coefficientSalary = coefficientSalary;
    }

    public String getId() {
        return id;
    }

    public String getFullName() {
        return fullName;
    }

    public void setId(String id) {
        this.id = id;
    }

    public void setFullName(String fullName) {
        this.fullName = fullName;
    }

    public double getSalary() {
        return basicSalary * coefficientSalary;
    }

    @Override
    public String toString() {
        return "Employee[id=" + id + ", fullName=" + fullName + ", coefficientSalary=" + coefficientSalary + ", salary=" + getSalary() + "]";
    }
}
