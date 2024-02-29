package zoo.animal;

public class Panda {
    private String name;
    private String country;
    private int age;

    public Panda (String name, String country) {
        this.name = name;
        this.country = country;
        this.age = 0;
    }
    public Panda (int age, String country) {
        this.name = age + " years old foundling from "+country;
        this.country = country;
        this.age = age;
    }

    public void happyBirthday(int limitYear) {
        this.age++;
        System.out.println(this.name + " " + this.country + " " + this.age);
        if (this.age > limitYear) System.out.println(this.name + " was moved back to China");
    }
}
