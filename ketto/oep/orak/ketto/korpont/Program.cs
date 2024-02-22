namespace ketto
{
    internal class Circle
    {
        public class NegativeRadiusException : Exception { }
        private Point k;
        private double r;

        public Circle(Point p, double r)
        {
            if (r <= 0)
            {
                throw new NegativeRadiusException();
            }
            this.k = p;
            this.r = r;
        }

        public bool Tartalmaz(Point p)
        {
            return this.k.Tav(p) < r;
        }

    }
    internal class Point
    {
        private double x, y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Tav(Point p)
        {
            return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Point p = new Point(5, 5);
                Circle kor = new Circle(p, -4);

            }
            catch (Circle.NegativeRadiusException)
            {
                Console.WriteLine("NegativeRadiusException");
            }
            Console.WriteLine("End");

        }
    }
}
