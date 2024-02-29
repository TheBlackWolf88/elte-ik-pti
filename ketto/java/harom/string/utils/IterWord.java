package string.utils;

public class IterWord {
    private String data;
    private int atInd;

    public IterWord(String s) {
        if (s == null) {
           throw new IllegalArgumentException(); 
        }
        this.data = s;
        this.atInd = 0;
    }
    public void printNext() {
        System.out.println(data.split(" ")[atInd]);
        this.atInd++;
    }

    public void reset() {
        this.atInd = 0;
    }



}
