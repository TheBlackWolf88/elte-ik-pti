class Muveletek {
    public static void main(String[] args){
        if (args.length < 2) {
            System.out.println("Kell ket parancssori argumentum, amik szamok!");
        }
        int x = Integer.parseInt(args[0]);
        int y = Integer.parseInt(args[1]);


        System.out.println("Osszeg: " + (x+y));
        System.out.println("Kulonbseg: " + (x-y));
        System.out.println("Szorzat: " + (x*y));
        if (y != 0){
            System.out.println("Osztas: " + (x/y));
            System.out.println("Osztasi maradek: " + (x%y));

        }


    }
}
