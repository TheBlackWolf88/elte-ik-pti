package data;

public class Van extends Car{
    protected int length;
    private static final String DEFAULT_BRAND = "VW";
    private static final String DEFAULT_COLOR= "black";
    private static final int DEFAULT_WEIGHT = 2200;
    private static final int DEFAULT_LENGTH = 5500;
    public Van(String color, String brand, int weight, int length) {
        super(color, brand, weight);
        this.length = length;
    }
    public Van(){
        super(DEFAULT_COLOR, DEFAULT_BRAND, DEFAULT_WEIGHT);
        this.length = DEFAULT_LENGTH;
    }

    @Override
    public String toString() {
        return super.toString()+" ,length:"+length;
    }
}
