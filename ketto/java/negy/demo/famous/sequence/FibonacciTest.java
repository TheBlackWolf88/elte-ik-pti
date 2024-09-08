package famous.sequence;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import static org.junit.Assert.assertEquals;

import org.junit.jupiter.api.*;
import check.CheckThat;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

public class FibonacciTest {
    @Test
    public void test1() {
        assertEquals(1, Fibonacci.fib(1));
    }

    @ParameterizedTest(name = "fib({0}) ?= fib({1}) + fib({2})")
    @CsvSource(textBlock = """
        2, 0, 1
        2, 1, 0
        4, 3, 2
    """)
    public void paramTest(int n, int k, int m) {
        assertEquals(Fibonacci.fib(n), Fibonacci.fib(k) + Fibonacci.fib(m));
    }
}
