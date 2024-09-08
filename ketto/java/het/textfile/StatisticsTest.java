package textfile;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;
import java.io.IOException;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertThrows;

public class StatisticsTest {
    @Test
    void test() throws FileNotFoundException {
        assertEquals(14,Statistics.numberOfLines("statTest.txt"));
        assertEquals(2042,Statistics.numberOfCharacters("statTest.txt"));
    }
}
