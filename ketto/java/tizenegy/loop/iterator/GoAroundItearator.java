package loop.iterator;

import java.util.ArrayList;
import java.util.List;

public class GoAroundItearator<T> implements java.util.Iterator<T> {
    private int idx;
    private int round;
    private int roundCount;
    List<T> elements;

    public GoAroundItearator(int roundCount, List<T> elements) {
        this.idx = 0;
        this.round = 0;
        this.roundCount = roundCount;
        this.elements = new ArrayList<>(elements);
    }

    @Override
    public boolean hasNext() {
        return idx+2 < elements.size();
    }

    @Override
    public T next() {
        T elem = elements.get(idx);
        idx = idx + 1 % elements.size();
        if (idx == 0) round++;
        return elem;
    }


}
