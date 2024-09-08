package action.user;

import action.Scalable;
import action.Undoable;

import java.util.Arrays;
import java.util.Objects;

public class MultiDimensionalPoint implements Undoable, Scalable, Comparable<MultiDimensionalPoint> {

    private int[] coordinates;
    private int[] lastCoordinates;

    public MultiDimensionalPoint(int... coordinates) {
        this.coordinates = coordinates.clone();
        saveToLast();
    }

    public int get(int d) {
        return coordinates[d];
    }

    public void set(int d, int n) {
        saveToLast();
        coordinates[d]= n;
    }

    private void saveToLast() {
        lastCoordinates = coordinates.clone();
    }

    @Override
    public void scale(int a) {
        saveToLast();
        for(int i = 0;i < coordinates.length; i++) {
            coordinates[i] *= a;
        }
    }

    @Override
    public void undoLast() {
        int[] z = coordinates;
        coordinates = lastCoordinates;
        lastCoordinates = z;
    }

    @Override
    public boolean equals(Object that) {
        if (this == that) return true;
        if (that == null || getClass() != that.getClass()) return false;
        MultiDimensionalPoint thatActual = (MultiDimensionalPoint) that;
        return Arrays.equals(coordinates, thatActual.coordinates);
    }

    @Override
    public int hashCode() {
        return Objects.hash(coordinates);
    }

    @Override
    public int compareTo(MultiDimensionalPoint that) {
        if (this.coordinates.length == that.coordinates.length) {
            for (int i = 0; i < this.coordinates.length; i++) {
                if (this.coordinates[i] != that.coordinates[i]) {
                    return this.coordinates[i] - that.coordinates[i];
                }
            }
            return 0;
        } else {
            return this.coordinates.length - that.coordinates.length;
        }
    }
}
