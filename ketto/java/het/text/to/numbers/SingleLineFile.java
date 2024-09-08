package text.to.numbers;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class SingleLineFile {
    public SingleLineFile() {
    }

    public static int addNumbers (String filename) throws IOException {
        int sum = 0;
        try (Scanner sc = new Scanner(new File(filename));
             FileWriter fw = new FileWriter("wrong." + filename);
        ) {
            if (!sc.hasNextLine()) throw new IllegalArgumentException("Empty file");
            String[] line = sc.nextLine().split(" ");
            for (String el : line) {
                try {
                    sum += Integer.parseInt(el);
                } catch (NumberFormatException e) {
                    System.err.println(el);
                    fw.append(el).append("\n");
                }
            }
        }
        return sum;
    }
}
