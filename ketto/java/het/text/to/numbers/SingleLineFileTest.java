package text.to.numbers;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertThrows;

import org.junit.jupiter.api.*;
import check.CheckThat;

import java.io.IOException;

public class SingleLineFileTest {
    @Test
    void checkExceptions() {
        assertThrows(IOException.class, () -> SingleLineFile.addNumbers("alma.txt"));
        IllegalArgumentException thrown  = assertThrows(IllegalArgumentException.class, () -> SingleLineFile.addNumbers("ures.txt"));
        assertEquals("Empty file", thrown.getMessage());

    }

    @Test
    void forRealTest() throws IOException {
        assertEquals(-117, SingleLineFile.addNumbers("frTest.txt"));
    }
}
