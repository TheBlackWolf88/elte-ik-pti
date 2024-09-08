package data.structure;

import java.util.HashMap;
import java.util.Map;

public class MultiSet <E>{
    private HashMap<E, Integer> elemToCount = new HashMap<>();

    @SafeVarargs
    public MultiSet(E... es) {
        for(E e : es) {
            if (elemToCount.containsKey(e)) {
               elemToCount.replace(e, elemToCount.get(e)+1);
            } else {
                elemToCount.put(e, 1);
            }

        }
    }

    public int add(E e) {

        if (elemToCount.containsKey(e)) {
            elemToCount.replace(e, elemToCount.get(e)+1);
        } else {
            elemToCount.put(e, 1);
        }
        return elemToCount.get(e);
    }

    public int getCount(E e) {
       return elemToCount.getOrDefault(e,0);
    }

    public MultiSet<E> intersect(MultiSet<E> es) {
        MultiSet<E> res = new MultiSet<>();
        for (Map.Entry<E, Integer> e1 : elemToCount.entrySet()) {
            for(Map.Entry<E, Integer> e2 : es.elemToCount.entrySet()) {
                if (e1.getKey() == e2.getKey()) {
                    res.elemToCount.put(e1.getKey(), Math.min(e1.getValue(), e2.getValue()));
                }
            }
        }
        return res;
    }

    public int size() {
        int res = 0;
        for (int i : elemToCount.values()){
            res += i;

        }
        return res;
    }

    public int countExcept (MultiSet<E> mse) {
        int res = 0;
        for(Map.Entry<E, Integer> elem: elemToCount.entrySet()) {
            for(Map.Entry<E, Integer> eleme : mse.elemToCount.entrySet()) {
            if (elem.getKey() != eleme.getKey()) res += elem.getValue();
        }}
        return res;
    }
}
