package ex8;

public class Time {
    private int hour;
    private int minute;
    private int second;

    public Time(int hour, int minute, int second) {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public int getHour() {
        return hour;
    }

    public int getMinute() {
        return minute;
    }

    public int getSecond() {
        return second;
    }

    public void setHour(int hour) {
        this.hour = hour;
    }

    public void setMinute(int minute) {
        this.minute = minute;
    }

    public void setSecond(int second) {
        this.second = second;
    }

    public void setTime(int hour, int minute, int second) {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    @Override
    public String toString() {
        String sHour = hour < 10 ? "0" + hour : Integer.toString(hour);
        String sMinute = minute < 10 ? "0" + minute : Integer.toString(minute);
        String sSecond = second < 10 ? "0" + second : Integer.toString(second);
        return sHour + ":" + sMinute + ":" + sSecond;
    }

    public Time nextSecond() {
        second++;
        if (second == 60) {
            second = 0;
            if (minute == 59) {
                minute = 0;
                if (hour == 23) {
                    hour = 0;
                } else {
                    hour++;
                }
            } else {
                minute++;
            }
        }
        return this;
    }

    public Time previousSecond() {
        second--;
        if (second == -1) {
            second = 59;
            if (minute == 0) {
                minute = 59;
                if (hour == 0) {
                    hour = 23;
                } else {
                    hour--;
                }
            } else {
                minute--;
            }
        }
        return this;
    }
}
