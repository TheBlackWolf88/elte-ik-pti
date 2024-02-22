namespace complex
{
    internal class Complex
    {
        private double x, y;

        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Complex Add(Complex a, Complex b)
        {
            return new Complex(a.x + b.x, a.y + b.y);
        }

        public static Complex operator +(Complex l, Complex r)
        {
            return new Complex(l.x + r.x, l.y + r.y);
        }
        public static Complex operator -(Complex l, Complex r)
        {
            return new Complex(l.x - r.x, l.y - r.y);
        }
        public static Complex operator *(Complex l, Complex r)
        {
            return new Complex(l.x * r.x - l.y * r.y, l.x * r.y + l.y * r.x );
        }
        public static Complex operator %(Complex l, Complex r)
        {
            if (r.x == 0 && r.y == 0) throw new Exception();
            return new Complex(l.x * r.x + l.y * r.y/(r.x*r.x + r.y*r.y), l.y * r.x - l.x * r.y/(r.x*r.x + r.y*r.y));
        }

        public override string ToString()
        {
            return this.x + " + " + this.y + "i";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {

            Complex a = new Complex(1,2);
            Complex b = new Complex(4,9);
            
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a%b);
        }

    }
}
