package plane;

public class PublicCircle {
   public double x, y, r;
   public PublicCircle() {
        this.x = 0;
        this.y = 0;
        this.r = 1;
   }

   public double getArea() {
        return this.r * this.r * Math.PI;
   }
}
