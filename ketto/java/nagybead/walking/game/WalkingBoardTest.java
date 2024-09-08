package walking.game;

import org.junit.Test;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import org.junit.jupiter.params.provider.ValueSource;
import walking.game.util.Direction;

public class WalkingBoardTest {
    @ParameterizedTest
    @ValueSource(ints = {1, 4, 5, 7})
    void testSimpleSize(int size) {
        WalkingBoard wb = new WalkingBoard(size);
        Assertions.assertEquals(size, wb.getTiles().length);
        for (int i = 0; i < size; i++) {
            Assertions.assertEquals(size, wb.getTiles()[i].length);
        }
        for (int[] line : wb.getTiles()){
            for(int el : line) {
                Assertions.assertEquals(WalkingBoard.BASE_TILE_SCORE, el);
            }
        }
    }

    @ParameterizedTest
    @CsvSource({"2,1,31", "1,2,23", "0,0,32"})
    public void testCustomInit(int x, int y, int expected){
        int[][] customInit = {{32,123,4,2},{123,2,31},{55,23}};
        WalkingBoard wb = new WalkingBoard(customInit);
        customInit[0][1] = 321;
        Assertions.assertNotEquals(321, wb.getTile(0,1));
        wb.getTiles()[y][x] = -1;
        Assertions.assertEquals(expected, wb.getTile(x,y));
    }

    @Test
    public void testMoves(){
        Direction[] moves = {Direction.RIGHT, Direction.DOWN, Direction.UP, Direction.DOWN, Direction.LEFT, Direction.DOWN};
        int[] values = {7,11,23,43,4, 9};
        WalkingBoard wb = new WalkingBoard(3);

        for(int i = 0; i < moves.length; i++){
            int oldX = wb.getPosition()[0];
            int oldY = wb.getPosition()[1];
            int oldValue = wb.moveAndSet(moves[i], values[i]);
            int newX = wb.getPosition()[0];
            int newY = wb.getPosition()[1];
            if (oldValue == 0) {
                Assertions.assertNotEquals(values[i], wb.getTile(newX, newY));
                Assertions.assertEquals(oldX, newX);
                Assertions.assertEquals(oldY, newY);
            } else {
                Assertions.assertEquals(values[i], wb.getTile(newX,newY));
            }

        }



    }
}
