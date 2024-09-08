package famous.sequence;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import static org.junit.Assert.assertEquals;

import org.junit.jupiter.api.*;
import check.CheckThat;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

public class TriangularNumbersTest {
    
   @Test
   public void testIt() {
       assertEquals(TriangularNumbers.getTriangularNumber(0), 0);
       assertEquals(TriangularNumbers.getTriangularNumber(100), 5050);
       assertEquals(TriangularNumbers.getTriangularNumber(-1), 0);
       assertEquals(TriangularNumbers.getTriangularNumber(-10), 0);
    
   }
}
