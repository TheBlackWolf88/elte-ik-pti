package walking.game.player;

import walking.game.util.Direction;

public class Player {
    protected Direction direction = Direction.UP;
    private int score;

    public int getScore() {
        return score;
    }

    public Direction getDirection() {
        return direction;
    }

    public Player(){}

    public void addToScore(int score) {
        this.score += score;
    }

    public void turn() {
        direction = direction.next();
    }

}
