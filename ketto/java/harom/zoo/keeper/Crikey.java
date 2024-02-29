package zoo.keeper;

import zoo.animal.Panda;

public class Crikey {
    public static void main(String[] args) {
        Panda p = new Panda("alma", "Uzbekistan");
        Panda p2 = new Panda(12, "Uzbekistan");
        p.happyBirthday(12);
        p2.happyBirthday(12);
    }
}
