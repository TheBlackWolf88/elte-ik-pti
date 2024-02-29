package point2d;
public class Point {
    double x, y;

    public Point() {
    }

    public Point(double x, double y) {
        this.x = x;
        this.y = y;
    }

    public void move(double dx, double dy) {
        this.x += dx;
        this.y += dy;
    }

    public void print() {
        System.out.println("x:" + this.x + "\ty:" + this.y);
    }

    public void mirror(double cx, double cy) {
        double dx = this.x - cx;
        double dy = this.y - cy;

        this.x = cx - dx;
        this.y = cy - dy;
    }

    public void mirror(Point p) {
        double dx = this.x - p.x;
        double dy = this.y - p.y;

        this.x = p.x - dx;
        this.y = p.y - dy;
    }

    public double distance(Point p) {
        return Math.sqrt(Math.pow(p.x-this.x, 2.0) + Math.pow(p.y - this.y,2.0));
    }
}
