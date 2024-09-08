package textfile;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Statistics {
    public static int numberOfCharacters (String filename) throws FileNotFoundException {
        int chars= 0;
        try (Scanner sc = new Scanner(new File(filename))) {
            while (sc.hasNextLine()) {
                String el = sc.nextLine().trim();
                chars+= el.length();
            }
        }
        return chars;
    }
    public static int numberOfLines (String filename) throws FileNotFoundException {
        int lines = 0;
        try (Scanner sc = new Scanner(new File(filename))) {
            while (sc.hasNextLine()) {
                lines++;
                sc.nextLine();
            }
        }
        return lines;
    }
}
