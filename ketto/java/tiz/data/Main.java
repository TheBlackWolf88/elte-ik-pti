package data;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<Car> cars = new ArrayList<>();
        cars.add(new Car("black", "VW", 950));
        cars.add(new Van());
        cars.add(new Bus("blue", "Volvo", 3000, 55));
        cars.add(new Bus("yellow", "Volvo", 3000, 72));
        cars.add(new Van());
        for(Car c : cars) {
            if (c instanceof Bus) {
                System.out.println("Bus -- " + c);
            }
            else if (c instanceof Van) {
                System.out.println("Van -- " + c);
            } else {
                System.out.println("Car -- " + c);
            }

        }
    }
}
