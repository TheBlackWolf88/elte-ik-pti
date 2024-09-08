package data;

public class Bus extends Car {
    protected int seats;
    public Bus(String color, String brand, int weight, int seats) {
        super(color, brand, weight);
        this.seats= seats;
    }

    @Override
    public String toString() {
        return super.toString()+" ,seats:"+seats;
    }
}
