package loop;

import loop.iterator.GoAroundItearator;

import java.util.ArrayList;
import java.util.Arrays;

public class GoAround <T>{
    private int roundCount;
    private ArrayList<T> elements;

    public GoAround(int roundCount, T... elements) {
        this.roundCount = roundCount;
        this.elements.addAll(Arrays.asList(elements));
    }

    /*public GoAroundItearator iterator() {
        return new GoAroundIterator<T>(roundCount, elements);
    }*/
}
