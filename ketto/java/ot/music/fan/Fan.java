package music.fan;

public class Fan {
    private final String name;
    private final music.recording.Artist favourite;

    public int getMoneySpent() {
        return moneySpent;
    }

    private int moneySpent;

    public music.recording.Artist getFavourite() {
        return this.favourite;
    }

    public String getName() {
        return this.name;
    }

    public Fan(String name, music.recording.Artist favourite) {
        this.name = name;
        this.favourite = favourite;
    }

    public int buyMerchandise(int basePrice, Fan... friends) {
        if (friends.length == 1) {
            basePrice = (int) Math.round(basePrice * 0.9);
            friends[0].buyMerchandise((int) basePrice);
            moneySpent += basePrice;
            favourite.getLabel().gotIncome((int) 2 * basePrice);
        } else if (friends.length > 1) {
            basePrice = (int) Math.round(basePrice * 0.8);
            for(Fan f : friends){
                f.buyMerchandise((int) basePrice);
            }
            moneySpent += basePrice;
            favourite.getLabel().gotIncome((int) (friends.length+1) * basePrice);
        } else {
            moneySpent += basePrice;
            favourite.getLabel().gotIncome(basePrice);
        }
        return basePrice;
    }

    public boolean favesAtSameLabel(Fan other) {
        return other.favourite == this.favourite;
    }

    public String toString1(){
        return "";
    }
    public String toString2(){
        return "";
    }
    public String toString3(){
        return "";
    }
    public String toString4(){
        return "";
    }

}
