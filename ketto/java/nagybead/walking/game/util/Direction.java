package walking.game.util;

public enum Direction {
    UP,
    RIGHT,
    DOWN,
    LEFT;
    //for memoization
    private static final Direction[] dirs = values();

    public Direction next() {
        return dirs[(this.ordinal()+1) % dirs.length];
    }
}
