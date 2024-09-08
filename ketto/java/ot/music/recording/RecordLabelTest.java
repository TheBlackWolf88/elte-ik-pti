package music.recording;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import static org.junit.Assert.assertEquals;

import org.junit.jupiter.api.*;
import check.CheckThat;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import music.recording.RecordLabel;

public class RecordLabelTest {
    
    @Test
    public void test1() {
        RecordLabel testLabel = new RecordLabel("123 Kiado", 123);
        assertEquals(testLabel.getName(), "123 Kiado");
        assertEquals(testLabel.getCash(), 123);
        testLabel.gotIncome(100);
        assertEquals(testLabel.getCash(), 173);
    }
}
