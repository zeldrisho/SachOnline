package cau6;

import cau5.Employee;

public class Manager extends Employee {
    private String position;
    private String department;
    private double salaryCoefficientPosition;

    public Manager() {
        super();
        position = "head";
        department = "administrative office";
        salaryCoefficientPosition = 5.0;
    }

    public Manager(String id, String fullName, double coefficientsSalary, String position, double salaryCoefficientPosition) {
        super(id, fullName, coefficientsSalary);
        this.position = position;
        this.salaryCoefficientPosition = salaryCoefficientPosition;
    }

    @Override
    public String considerEmulation() {
        return "A";
    }

    public double bonusByPosition() {
        return 1150 * salaryCoefficientPosition;
    }

    @Override
    public double getSalary() {
        double emulationCoefficient;
        if (considerEmulation().equals("A")) {
            emulationCoefficient = 1.0;
        } else if (considerEmulation().equals("B")) {
            emulationCoefficient = 0.75;
        } else if (considerEmulation().equals("C")) {
            emulationCoefficient = 0.5;
        } else {
            emulationCoefficient = 0.25;
        }
        return 1150 * salaryCoefficientPosition * emulationCoefficient + getSenioritySalary() + bonusByPosition();
    }
}
