package music.fan;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import static org.junit.Assert.assertEquals;

import org.junit.jupiter.api.*;
import check.CheckThat;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import music.recording.*;

public class FanTest {
    @Test
    public void test1() {
        RecordLabel testLabel = new RecordLabel("Alma Kiado", 420);
        Artist testArtist  = new Artist("Jozsi bacsi", testLabel);
        Fan testFan = new Fan("Gizella", testArtist);
        Fan testFan2 = new Fan("Peter", testArtist);

        assertEquals(testFan.favesAtSameLabel(testFan2), true);
        assertEquals(testFan.getMoneySpent(), 0);
        testFan.buyMerchandise(100);
        assertEquals(testFan.getMoneySpent(), 100);
        testFan.buyMerchandise(100, testFan2);
        assertEquals(testFan.getMoneySpent(), 190);
        testFan.buyMerchandise(100, testFan2, testFan2);
        assertEquals(testFan.getMoneySpent(), 270);

    }
}
