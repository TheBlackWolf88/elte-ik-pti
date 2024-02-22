public class PointMain {
    public static void main(String[] args) {
        Point a = new Point();
        a.move(1.0, 2.3);
        a.print();
        a.mirror(0.0,0.0);        
        a.print();

        Point b = new Point(0.2, 9.3);

        System.out.println(b.distance(a));        
        b.mirror(a);
        b.print();
        System.out.println(b.distance(a));        
    }
}
