package reader;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class Reader {
   public static void main(String[] args) {
       if (args.length == 1){
           try (Scanner sc = new Scanner(args[0])) {
               while (sc.hasNextLine()){
                   System.out.println(sc.nextLine());
               }
           }
       }
       if (args.length == 2){
           try (Scanner sc = new Scanner(new File(args[0]));
                FileWriter fw = new FileWriter(args[1]);) {
               while (sc.hasNextLine()) {
                   fw.write(sc.nextLine());
               }
           } catch (IOException e){
               throw new RuntimeException(e);
           }
       }
   } 
}
