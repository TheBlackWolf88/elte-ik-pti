package living.animal;

import living.Animal;
import living.Creature;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Cat extends Animal {
    private static final int DEFAULT_REP_TIME = 3;
    public Cat(int reproduceRate) {
        super(reproduceRate);
    }

    public Cat() {
        super(DEFAULT_REP_TIME);
    }

    @Override
    public List<Creature> reproduce() {
        ArrayList<Creature> res = new ArrayList<>();
        Random rand = new Random();
        for (int i = 0; i < reproduceRate; i++) {
            int newRate = rand.nextInt(3) -1;
            res.add(new Cat(newRate));
        }
        return res;
    }

    public void meow(){
        System.out.println("MEOW");
    }
}
