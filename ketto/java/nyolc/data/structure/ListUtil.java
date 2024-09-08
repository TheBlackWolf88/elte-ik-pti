package data.structure;

import java.util.ArrayList;
import java.util.Collections;

public class ListUtil {
    public static ArrayList<Integer> divisors (int num) {
        ArrayList<Integer> res = new ArrayList<>();
        for (int i = 1; i <= num; i++) {
            if (num % i == 0) res.add(i);
        }
        System.out.println(res);
        return res;
    }

    public static ArrayList<String> withSameStartEnd(ArrayList<String> in) {
        ArrayList<String> res = new ArrayList<>();
        for (String el : in) {
            if (el == null || el.isEmpty()) continue;
            if (el.charAt(0) == el.charAt(el.length()-1)) res.add(el);
        }
        return res;
    }

    public static void maxToFront(ArrayList<String> in){
        if (in == null || in.isEmpty()) return;
        String max = Collections.max(in);
        int ind = in.indexOf(max);
        Collections.swap(in, ind, 0);
    }
}
