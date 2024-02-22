class Welcome {
    public static void main (String[] args){
        String name;
        if (args.length > 0) {
            name = args[0];
        } else {
            name = System.console().readLine();
        }
        System.out.println("Welcome "+ name +"!");
    }
}
