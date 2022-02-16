package cau6;

import cau5.Employee;

public class Entry {
    public static void main(String[] args) {
        Employee manager = new Manager();
        System.out.println(manager.getSalary());
    }
}
