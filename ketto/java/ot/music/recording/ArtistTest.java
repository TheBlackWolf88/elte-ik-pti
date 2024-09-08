package music.recording;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import static org.junit.Assert.assertEquals;

import org.junit.jupiter.api.*;
import check.CheckThat;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import music.recording.Artist;
import music.recording.RecordLabel;

public class ArtistTest {
    public void test1(){
        RecordLabel testL1 = new RecordLabel("A", 1);

        Artist testA1 = new Artist("Bela", testL1);

        assertEquals(testA1.getName(), "Bela");
        assertEquals(testA1.getLabel(), testL1);
    }
}
