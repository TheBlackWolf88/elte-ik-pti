package action.user;

import org.junit.Test;
import org.junit.jupiter.api.Assertions;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class MultiDimensionalPointTest {

    @Test
    public void testInitUndo() {
        MultiDimensionalPoint p = new MultiDimensionalPoint(1,2);
        Assertions.assertEquals(1, p.get(0));
        Assertions.assertEquals(2, p.get(1));
        p.undoLast();
        Assertions.assertEquals(1, p.get(0));
        Assertions.assertEquals(2, p.get(1));
        p.undoLast();
        Assertions.assertEquals(1, p.get(0));
        Assertions.assertEquals(2, p.get(1));
    }

    @Test
    public void testSet() {

        MultiDimensionalPoint p = new MultiDimensionalPoint(1,2);
        p.set(0, 3);
        Assertions.assertEquals(3, p.get(0));
        Assertions.assertEquals(2, p.get(1));
        p.undoLast();
        Assertions.assertEquals(1, p.get(0));
        Assertions.assertEquals(2, p.get(1));
        p.undoLast();
        Assertions.assertEquals(3, p.get(0));
        Assertions.assertEquals(2, p.get(1));
    }

    @Test
    public void testScale() {

        MultiDimensionalPoint p = new MultiDimensionalPoint(1,2);
        p.scale(2);
        Assertions.assertEquals(2, p.get(0));
        Assertions.assertEquals(4, p.get(1));
        p.undoLast();
        Assertions.assertEquals(1, p.get(0));
        Assertions.assertEquals(2, p.get(1));
        p.undoLast();
        Assertions.assertEquals(2, p.get(0));
        Assertions.assertEquals(4, p.get(1));
    }

    @Test
    public void testEquality() {
        List<MultiDimensionalPoint> lmp1 = new ArrayList<>(List.of(new MultiDimensionalPoint(1,2), new MultiDimensionalPoint(2,3), new MultiDimensionalPoint(3,4)));
        List<MultiDimensionalPoint> lmp2 = new ArrayList<>(List.of(new MultiDimensionalPoint(4,5), new MultiDimensionalPoint(6,7), new MultiDimensionalPoint(7,8)));
        Assertions.assertEquals(false, lmp1.equals(lmp2));
    }

    @Test
    public void testOrdering() {
        List<MultiDimensionalPoint> lmp = new ArrayList<>(List.of(new MultiDimensionalPoint(1,2, 4), new MultiDimensionalPoint(6,3), new MultiDimensionalPoint(3,4)));
        Collections.shuffle(lmp);
        Collections.sort(lmp);
        List<MultiDimensionalPoint> list = new ArrayList<MultiDimensionalPoint>(List.of(new MultiDimensionalPoint(3,4), new MultiDimensionalPoint(6,3), new MultiDimensionalPoint(1,2,4)));
        Assertions.assertEquals(list, lmp);
    }
}
