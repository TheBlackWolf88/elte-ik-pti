import java.util.ArrayList;
import java.util.List;

public class Distance {
    public static void main(String[] args) {
        if (args.length % 2 != 0)
            return;
        double distance = 0.0;
        ArrayList<Point> data = new ArrayList<Point>();
        for (int i = 0; i < args.length; i+=2) {
            data.add(new Point(Double.parseDouble(args[i]), Double.parseDouble(args[i + 1])));
        } 
        for (int i = 0; i < data.size() - 1; i++) {
            distance += data.get(i).distance(data.get(i + 1));
        }

        System.out.println(distance);
    }
}
