package walking.game;

import walking.game.player.MadlyRotatingBuccaneer;
import walking.game.player.Player;

import java.util.Arrays;

public class WalkingBoardWithPlayers extends WalkingBoard{

    private Player[] players;
    private int round;
    public static final int SCORE_EACH_STEP = 13;
    public WalkingBoardWithPlayers(int size, int playerCount) {
        super(size);
        initPlayers(playerCount);
    }

    public WalkingBoardWithPlayers(int[][] tiles,int playerCount) {
        super(tiles);
        initPlayers(playerCount);
    }

    private void initPlayers(int playerCount) {
        players = new Player[playerCount];
        if(playerCount < 2) throw new IllegalArgumentException();
        players[0] = new MadlyRotatingBuccaneer();
        for (int i = 1; i < playerCount; i++) {
            players[i] = new Player();
        }
    }

    public int[] walk(int... stepCounts){
        int stepsTillNow = 0;
        int[] points = new int[players.length];
        for (int i = 0; i < stepCounts.length; i++){
            Player p = players[i%players.length];
            p.turn();
            for (int j = 0; j < stepCounts[i]; j++) {
                int oldVal = moveAndSet(p.getDirection(), Math.min(stepsTillNow, SCORE_EACH_STEP));
                p.addToScore(oldVal);
                stepsTillNow++;
                }


        }
        for(int i = 0; i < players.length; i++) {
            points[i] = players[i].getScore();
        }
        return points;

    }

}
