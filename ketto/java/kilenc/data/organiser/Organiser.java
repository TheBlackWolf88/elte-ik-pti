package data.organiser;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

public class Organiser<T> {
    private ArrayList<T> elems = new ArrayList<>();
    private ArrayList<Map.Entry<Integer,Integer>> swaps = new ArrayList<>();
    @SafeVarargs
    public Organiser(T... elems) {
        this.elems = new ArrayList<>(List.of(elems));
    }

    public ArrayList<T> get (){
        return new ArrayList<>(elems);
    }

    public T get(int i) {
        return elems.get(i);
    }

    public void addSwap(int i, int j) {
        swaps.add(Map.entry(i,j));
    }
    private void swap (int i, int j) {
        T el = elems.get(i);
        elems.set(i,elems.get(j));
        elems.set(j, el);

    }

    public void runSwaps(){
        for(Map.Entry<Integer,Integer> swap : swaps) {
            swap(swap.getKey(), swap.getValue());
        }
    }

    @Override
    public String toString() {
       return "[" + elems + "]";
    }
}
