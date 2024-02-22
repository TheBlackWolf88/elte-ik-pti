public class Circle {
    double x,y, radius;

    public Circle(double x, double y, double r) {
        this.x = x;
        this.y = y;
        this.radius = r;
    }

    public void enlarge(double f){
        this.radius *= f;
    }

    public double getArea() {
        return r*r*Math.PI;
    }
}
