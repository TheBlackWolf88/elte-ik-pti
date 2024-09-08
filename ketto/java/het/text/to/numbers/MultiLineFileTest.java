package text.to.numbers;

import org.junit.jupiter.api.Test;

import java.io.IOException;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertThrows;

public class MultiLineFileTest {
    @Test
    void checkExceptions() {
        assertThrows(IOException.class, () -> MultiLineFile.addNumbers("alma.txt", ' '));

    }

    @Test
    void forRealTest() throws IOException {
        assertEquals(-351, MultiLineFile.addNumbers("frMultiTest.txt", ' '));
        assertEquals(-351, MultiLineFile.addNumbers("frMultiCommaTest.txt", ','));
    }
}
