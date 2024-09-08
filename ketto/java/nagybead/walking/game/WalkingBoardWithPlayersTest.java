package walking.game;

import org.junit.Test;
import org.junit.jupiter.api.Assertions;

public class WalkingBoardWithPlayersTest {
    @Test
    public void walk1(){
        WalkingBoardWithPlayers wb = new WalkingBoardWithPlayers(3, 2);
        int[] idealPoints = {6,12};
        int[] actualPoints = wb.walk(8, 3, 12, 6, 10, 5);
        int[][] idealMap = {{3,8,9}, {3,3,13}, {13,13,13}};
        int[][] actualMap = wb.getTiles();
        Assertions.assertArrayEquals(idealMap, actualMap);
        Assertions.assertArrayEquals(idealPoints, actualPoints);
    }

    @Test
    public void walk2(){
        WalkingBoardWithPlayers wb = new WalkingBoardWithPlayers(5, 4);
        int[] idealPoints = {6,15,12,3};
        int[] actualPoints = wb.walk(1, 2, 1, 1, 2, 2, 2, 1, 2, 1, 1, 2);
        int[][] idealMap = {{3,1,2,3,4}, {3,3,3,3,7}, {3,3,3,3,8},{3,3,3,3,9}, {13,13,13,12,10}};
        int[][] actualMap = wb.getTiles();
        Assertions.assertArrayEquals(idealMap, actualMap);
        Assertions.assertArrayEquals(idealPoints, actualPoints);
    }
}
