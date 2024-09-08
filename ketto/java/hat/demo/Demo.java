public class Demo {

    public static void printTomb (int[] tomb) {
        for (int var : tomb) {
            System.out.print(var + " ");
            
        }
        System.out.println();
    }

    public static void main(String[] args) {
        int[] tomb = {1, 2, 3};

        Foo foo = new Foo(tomb);

        printTomb(foo.getData());


    }    
}
