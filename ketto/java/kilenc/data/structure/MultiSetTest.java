package data.structure;

import org.junit.Test;
import org.junit.jupiter.api.Assertions;

public class MultiSetTest {

    @Test
    public void multiSetInteger () {
        MultiSet<Integer> ms = new MultiSet<>();
        ms.add(1);
        ms.add(1);
        ms.add(1);
        ms.add(2);
        ms.add(2);
        ms.add(4);
        ms.add(2);
        ms.add(2);
        Assertions.assertEquals(3, ms.getCount(1));
        Assertions.assertEquals(4, ms.getCount(2));
        Assertions.assertEquals(1, ms.getCount(4));
    }

    @Test
    public void multiSetString() {
        MultiSet<String> ms = new MultiSet<>();
        ms.add("alma");
        ms.add("alma");
        ms.add("alma");
        ms.add("korte");
        ms.add("korte");
        ms.add("szilva");
        ms.add("korte");
        ms.add("korte");
        Assertions.assertEquals(3, ms.getCount("alma"));
        Assertions.assertEquals(4, ms.getCount("korte"));
        Assertions.assertEquals(1, ms.getCount("szilva"));
    }

    @Test
    public void testIntersect(){
        MultiSet<Integer> ms1 = new MultiSet<>();
        MultiSet<Integer> ms2 = new MultiSet<>();
        ms1.add(1);
        ms1.add(1);
        ms1.add(2);
        ms1.add(2);
        ms1.add(3);
        ms2.add(1);
        ms2.add(2);
        ms2.add(4);
        ms2.add(4);
        ms2.add(4);
        MultiSet<Integer> res = ms1.intersect(ms2);
        Assertions.assertEquals(1,res.getCount(1));
        Assertions.assertEquals(1,res.getCount(2));
        Assertions.assertEquals(0,res.getCount(4));
        Assertions.assertEquals(0,res.getCount(3));
    }

    @Test
    public void testCountExcept(){
        MultiSet<Integer> ms1 = new MultiSet<>();
        MultiSet<Integer> ms2 = new MultiSet<>();
        ms1.add(1);
        ms1.add(1);
        ms1.add(2);
        ms1.add(2);
        ms1.add(3);
        ms2.add(1);
        ms2.add(2);
        ms2.add(4);
        ms2.add(4);
        ms2.add(4);
        Assertions.assertEquals(11, ms1.countExcept(ms2));
        Assertions.assertEquals(13, ms2.countExcept(ms1));
    }
}
