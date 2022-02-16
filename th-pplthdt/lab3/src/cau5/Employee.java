package cau5;

import java.time.Year;

public class Employee {
    private String id;
    private String fullName;
    private int yearJoined;
    private double coefficientsSalary;
    private int numDaysOff;

    public Employee() {
        id = "0";
        fullName = "";
        yearJoined = 2020;
        coefficientsSalary = 1.0;
        numDaysOff = 0;
    }

    public Employee(String id, String fullName, double coefficientsSalary) {
        this.id = id;
        this.fullName = fullName;
        this.coefficientsSalary = coefficientsSalary;
        yearJoined = 2020;
        numDaysOff = 0;
    }

    public Employee(String id, String fullName, double coefficientsSalary, int yearJoined, int numDaysOff) {
        this.id = id;
        this.fullName = fullName;
        this.coefficientsSalary = coefficientsSalary;
        this.yearJoined = yearJoined;
        this.numDaysOff = numDaysOff;
    }

    public double getSenioritySalary() {
        double yearWork = 2022 - yearJoined;
        if (yearWork >= 5) {
            return yearWork * 1150 / 100;
        }
        return 0;
    }

    public String considerEmulation() {
        if (numDaysOff <= 1) {
            return "A";
        }
        if (numDaysOff == 2) {
            return "B";
        }
        if (numDaysOff == 3) {
            return "C";
        }
        return "D";
    }

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
        return 1150 * coefficientsSalary * emulationCoefficient;
    }
}
