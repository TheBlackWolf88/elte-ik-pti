package living.animal;

import living.Animal;
import living.Creature;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Dog extends Animal {
    private static final int DEFAULT_REP_TIME = 2;
    public Dog(int reproduceRate) {
        super(reproduceRate);
    }

    public Dog() {
        super(DEFAULT_REP_TIME);
    }

    @Override
    public List<Creature> reproduce() {
        ArrayList<Creature> res = new ArrayList<>();
        Random rand = new Random();
        for (int i = 0; i < reproduceRate; i++) {
            int newRate = rand.nextInt(3) -1;
            res.add(new Dog(newRate));
        }
        return res;
    }

    public void bark(){
        System.out.println("BARK");
    }
}
