package data.structure;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.List;

public class ListUtilTest {
    @Test
    public void testDivisors(){
        Assertions.assertEquals(new ArrayList<Integer>(), ListUtil.divisors(0));
        ArrayList<Integer> oneTest = new ArrayList<>(List.of(1));
        Assertions.assertEquals(oneTest ,ListUtil.divisors(1));
        ArrayList<Integer> sixtyFourTest = new ArrayList<>(List.of(1,2,4,8,16,32,64));
        Assertions.assertEquals(sixtyFourTest, ListUtil.divisors(64));
    }

    @Test
    public void testWSE(){
        ArrayList<String> tested = new ArrayList<>();
        ArrayList<String> shouldBe = new ArrayList<>();
        Assertions.assertEquals(shouldBe, ListUtil.withSameStartEnd(tested));
        tested.add("");
        Assertions.assertEquals(shouldBe, ListUtil.withSameStartEnd(tested));
        tested.add(null);
        Assertions.assertEquals(shouldBe, ListUtil.withSameStartEnd(tested));
        tested.add(" ");
        shouldBe.add(" ");
        Assertions.assertEquals(shouldBe, ListUtil.withSameStartEnd(tested));
        tested.add("x");
        shouldBe.add("x");
        Assertions.assertEquals(shouldBe, ListUtil.withSameStartEnd(tested));
        tested.add("");
        Assertions.assertEquals(shouldBe, ListUtil.withSameStartEnd(tested));
        tested.add("different start and end?");
        Assertions.assertEquals(shouldBe, ListUtil.withSameStartEnd(tested));
        tested.add("ends and starts the same");
        shouldBe.add("ends and starts the same");
        Assertions.assertEquals(shouldBe, ListUtil.withSameStartEnd(tested));
    }

    @Test
    public void testMTF(){
        ArrayList a = null;
        ListUtil.maxToFront(a);
        ArrayList b = new ArrayList();
        ListUtil.maxToFront(b);
        Assertions.assertEquals(new ArrayList<>(), b);
        ArrayList<String> c = new ArrayList<>(List.of("1"));
        ListUtil.maxToFront(c);
        Assertions.assertEquals(new ArrayList<>(List.of("1")), c);

    }
}
