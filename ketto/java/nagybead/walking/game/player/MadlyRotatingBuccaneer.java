package walking.game.player;

public class MadlyRotatingBuccaneer extends Player{
    private int turnCount = 0;
    @Override
    public void turn() {
        for (int i = 0; i < turnCount%4; i++) {
           super.turn();
        }
        turnCount++;
    }
}
