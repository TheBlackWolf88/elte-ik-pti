package math.operation.textual;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import static org.junit.Assert.assertEquals;

import org.junit.jupiter.api.*;
import check.CheckThat;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import math.operation.textual.Adder;

public class AdderTest {
    @Test
    public void testAtZero() {
        Adder adder = new Adder();
        assertEquals("12", adder.addAsText("12", "0"));
    }

    @Test
    public void testTwoNegs() {
        Adder adder = new Adder();
        assertEquals("-42", adder.addAsText("-20", "-22"));
    }
    @Test
    public void testOneNeg() {
        Adder adder = new Adder();
        assertEquals("-2", adder.addAsText("20", "-22"));
    }
    @Test
    public void easyMaths() {
        Adder adder = new Adder();
        assertEquals("4", adder.addAsText("2", "2"));
        assertEquals("3", adder.addAsText("4", "-1"));
    }
}
