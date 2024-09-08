package data;

public class Car implements Vehicle{
    protected final String color;
    protected final String brand;
    protected final int weight;

    public Car(String color, String brand, int weight) {
        this.color = color;
        this.brand = brand;
        this.weight = weight;
    }

    @Override
    public String getColor() {
        return color;
    }

    @Override
    public String getBrand() {
        return brand;
    }

    @Override
    public int getWeight() {
        return weight;
    }

    @Override
    public String toString() {
        String s = brand + ':' + color + ", weight:" + weight;
        return s;
    }
}
