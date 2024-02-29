package plane;

public class Circle {
   private double x, y, r;
   public Circle() {
        this.x = 0;
        this.y = 0;
        this.r = 1;
   }
    
   public Circle(double x, double y, double r) {
        this.x = x;
        this.y = y;
        this.r = r;
   }
   public double getX() { return this.x; };
   public double getY() { return this.y; };
   public double getR() { return this.r; };

    public void setX(double x) {
        this.x = x;
    }
    public void setY(double y) {
        this.y = y;
    }

    public void setR (double r) {
        if (r <= 0) {
            throw new IllegalArgumentException();
        } 

        this.r = r;
    }

   public double getArea() {
        return this.r * this.r * Math.PI;
   }
}
