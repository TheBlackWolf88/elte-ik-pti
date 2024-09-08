namespace AM
{
    class AM
    {
        private double[] a = [];
        public int size;
        public AM(int size)
        {
            this.size = size;
            this.a = new double[2 * this.size - 1];
        }
        //sorfolytonos rep
        //
        // 1 0 0 0 1
        // 0 1 0 1 0
        // 0 0 1 0 0 
        // 0 1 0 1 0
        // 1 0 0 0 1
        private int ind(int i, int j)
        {
            if (i == j) return i * 2 - 2;
            else if (i + j == this.size + 1)
            {
                if (i > j) return i * 2 - 3;
                return i * 2 - 1;
            }
            else return -1;
        }
        public double getAt(int i, int j)
        {
            if (i == j || i + j == this.size + 1) return a[ind(i, j)];
            else return 0;
        }
        public void setAt(int i, int j, double e)
        {
            if (i == j || i + j == this.size + 1) a[ind(i, j)] = e;
            else throw new Exception();
        }

        public void printMatrix()
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    System.Console.Write(getAt(i, j) + "\t");
                }
                System.Console.WriteLine();

            }
        }

        public static AM operator *(AM a, AM b)
        {
            if (a.size != b.size) throw new ArgumentException();
            AM c = new AM(a.size);
            for (int i = 1; i <= c.size; i++)
            {
                for (int j = 1; j <= c.size; j++)
                {
                    System.Console.WriteLine(c.ind(i, j) + " " + c.ind(i, c.size));
                    if (c.ind(i,j) != -1 && c.ind(i, c.size) != -1 && c.ind(c.size, j) != -1) c.a[c.ind(i,j)] = a.a[c.ind(i, j)] * b.a[c.ind(i, j)] + a.a[c.ind(i, c.size)] * b.a[c.ind(c.size, j)];
                    }
            }
            return c;
        }



    }
    class Program
    {

        public static void Main(string[] args)
        {
            AM am = new AM(3);
            am.setAt(1, 1, 1);
            am.setAt(1, 3, 2);
            am.setAt(2, 2, 3);
            am.setAt(3, 1, 4);
            am.setAt(3, 3, 5);
            am.printMatrix();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            AM bm = new AM(3);
            bm.setAt(1, 1, 5);
            bm.setAt(1, 3, 4);
            bm.setAt(2, 2, 3);
            bm.setAt(3, 1, 2);
            bm.setAt(3, 3, 1);
            bm.printMatrix();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            (am * bm).printMatrix();
        }
    }

}
