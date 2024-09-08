package famous.sequence;

public class TriangularNumbers {
    public static int getTriangularNumberAlternative(int n) {
        return (n * (n+1)) /2 ;
    }

    public static int getTriangularNumber(int n) {
        int sum = 0;
        for(int i = 0; i <= n; i++) {
            sum += i;
        } 
        return sum;
    }
}
