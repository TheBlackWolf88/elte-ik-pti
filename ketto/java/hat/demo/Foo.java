public class Foo {
    private final int[] data;

	public int[] getData() {
		return data.clone();
	}

   public Foo(int[] data) {
        this.data = data.clone();
   } 
}
