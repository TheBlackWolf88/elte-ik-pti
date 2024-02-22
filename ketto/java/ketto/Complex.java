
public class Complex {
    private double re, im;

    public Complex(double re, double im) {
        this.re = re;
        this.im = im;
    }

    public double abs() {
        return Math.sqrt(this.re * this.re + this.im * this.im);
    }

    public void add(Complex c) {
        this.re += c.re;
        this.im += c.im;
    }

    public void sub(Complex c) {
        this.re -= c.re;
        this.im -= c.im;
    }

    public void mul(Complex c) {
        this.re = c.re * this.re - c.im * this.im;
        this.im = c.re * this.im + c.im * this.re;
    }

}
