import check.CheckThat;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;

import static check.CheckThat.Condition.*;
import static check.CheckThat.it;
import static check.CheckThat.withParams;

public class ListUtilStructureTest {
    @BeforeAll
    public static void init() {
        CheckThat.theClass("data.structure.ListUtil")
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL);
    }

    @Test
    public void methodDivisors() {
        it.hasMethod("divisors", withParams("int"))
            .thatIs(FULLY_IMPLEMENTED, USABLE_WITHOUT_INSTANCE, VISIBLE_TO_ALL)
            .thatReturns("java.util.ArrayList");
    }

    @Test
    public void methodWithSameStartEnd() {
        it.hasMethod("withSameStartEnd", withParams("ArrayList of String"))
            .thatIs(FULLY_IMPLEMENTED, USABLE_WITHOUT_INSTANCE, VISIBLE_TO_ALL)
            .thatReturns("ArrayList of String");
    }

    @Test
    public void methodMaxToFront() {
        it.hasMethod("maxToFront", withParams("ArrayList of String"))
            .thatIs(FULLY_IMPLEMENTED, USABLE_WITHOUT_INSTANCE, VISIBLE_TO_ALL)
            .thatReturnsNothing();
    }
}

