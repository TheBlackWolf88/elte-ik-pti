public class Print {
    public static void main(String[] args) {
        System.out.println("Adj meg ket szamot: ");
        String[] line = System.console().readLine().split(" ");
        int from = Integer.parseInt(line[0]);
        int to = Integer.parseInt(line[1]);

        double i = from;
        for(; i <= to; i++) {
            System.out.println(i/2);
        }
        i--;
        System.out.println("Kiirtam " + (int)i + " szamot");
    }
}
