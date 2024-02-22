class Faktorialis {
    static int fakt(int n){
        if (n == 0){
            return 1;
        }
        return n * fakt(n-1);
    }
    public static void main (String[] args) {
        if (args.length < 1) {
            System.out.println("Keves argumentum!");
            return;
        }

        int n = Integer.parseInt(args[0]);
        if(n < 0) {
            System.out.println("A negativ egeszekre nem ertelmezheto a faktorialis!");
            return;
        }
        System.out.println(n+ "! = " + fakt(n));


    }
}
