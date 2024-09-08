package main;

import living.Creature;
import living.animal.Cat;
import living.animal.Dog;

import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {
        List<Creature> list = new ArrayList<>();
        list.add(new Cat());
        list.add(new Cat());
        list.add(new Cat());
        list.add(new Dog());
        list.add(new Dog());
        list.add(new Dog());
        list.add(new Cat());

        for(Creature cr : list ){
            if (cr instanceof Cat) {
                ((Cat) cr).meow();
            } else if (cr instanceof Dog) {
                ((Dog) cr).bark();
            }
        }
    }
}
