package string.utils;

public class IterLetter {
    private String data;
    private int atInd;

    public IterLetter(String s) {
        if (s == null) {
           throw new IllegalArgumentException(); 
        }
        this.data = s;
        this.atInd = 0;
    }
    public void printNext() {
        System.out.println(data.charAt(atInd));
        this.atInd++;
    }

    public void reset() {
        this.atInd = 0;
    }



}
