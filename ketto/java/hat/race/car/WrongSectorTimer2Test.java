package race.car;
import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import static org.junit.Assert.assertEquals;

import org.junit.jupiter.api.*;
import check.CheckThat;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import race.car.SectorTimer;

public class WrongSectorTimer2Test {
    @Test
    public void seemsGood(){
        int[] a = {1,2,3};
        SectorTimer st = new SectorTimer(a);

        st.getSectorTimes();
        st.setLapTimes(4,5,6);
        st.getSectorTimes();
    }
}
