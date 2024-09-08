package walking.game;

import walking.game.util.Direction;

import java.util.Arrays;

public class WalkingBoard {
    private int[][] tiles;
    private int x;
    private int y;
    public static final int BASE_TILE_SCORE = 3;
    public int[][] getTiles() {
        int[][] res = new int[tiles.length][];
        for (int i = 0; i < tiles.length; i++) {
            res[i] = Arrays.copyOf(tiles[i], tiles[i].length);
        }
        return res;
    }
    public WalkingBoard(int size) {
        tiles = new int[size][size];
        for (int i = 0; i < size; i++ ){
            for (int j = 0; j < size; j++){
                tiles[i][j] = BASE_TILE_SCORE;
            }
        }
    }

    public WalkingBoard(int[][] tiles){
        for (int i = 0; i < tiles.length; i++) {
            for (int j = 0; j < tiles[i].length; j++) {
                tiles[i][j] = Math.max(tiles[i][j], 3);
            }
        }
        this.tiles = tiles.clone();
    }

    public int[] getPosition() {
        return new int[]{x, y};
    }

    public boolean isValidPosition(int x, int y){
        try {
            int el = tiles[y][x];
            return true;
        } catch (IndexOutOfBoundsException e) {
            return false;
        }
    }

    public int getTile(int x, int y) {
        if (isValidPosition(x,y)){
            return tiles[y][x];
        } else {
            throw new IllegalArgumentException();
        }
    }

    public static int getXStep (Direction dir) {
        return switch (dir) {
            case UP, DOWN -> 0;
            case LEFT -> -1;
            case RIGHT -> 1;
        };
    }


    public static int getYStep (Direction dir) {
        return switch (dir) {
            case LEFT, RIGHT -> 0;
            case UP -> -1;
            case DOWN -> 1;
        };
    }

    public int moveAndSet(Direction dir, int newValue){
        if(!isValidPosition(x + getXStep(dir), y + getYStep(dir))) return 0;
        x += getXStep(dir);
        y += getYStep(dir);
        int oldValue = getTile(x, y);
        tiles[y][x] = newValue;
        return oldValue;
    }


}
