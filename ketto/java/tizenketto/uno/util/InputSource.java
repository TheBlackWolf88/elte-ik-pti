package uno.util;

import java.io.BufferedReader;
import java.io.InputStreamReader;

public class InputSource {
    public boolean isInteractive;
    private BufferedReader br;
    private int[] inputs;
    private int inputIdx;
    public static final int DONE = -1;

    public InputSource(boolean isInteractive, int... inputs) {
        this.isInteractive = isInteractive;
        if (isInteractive) br = new BufferedReader(new InputStreamReader(System.in));
        else this.inputs = inputs;
    }

}
