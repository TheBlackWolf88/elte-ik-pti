namespace Kerteszkedes
{
    //sealed disableeli a inheritancet
    public abstract class Plant
    {
        public readonly int RipeningTime { get; }

        public Plant(int ripeningTime)
        {
            RipeningTime = ripeningTime;
        }
    }

    public abstract class Flower : Plant
    {
        public Flower(int ripeningTime) : base(ripeningTime) { }
    }

    public class Tulip
    {
        private Tulip(int rt) : base(rt) { }

        private static Tulip instance;

        public static Tulip Instance()
        {
            if (instance == null)
            {
                instance = new Tulip(8);
            }
            return instance;
        }
    }
    public class Rose
    {
        private Rose(int rt) : base(rt) { }

        private static Rose instance;

        public static Rose Instance()
        {
            if (instance == null)
            {
                instance = new Rose(9);
            }
            return instance;
        }
    }

    public abstract class Vegetable : Plant
    {
        public Vegetable(int ripeningTime) : base(ripeningTime) { }
    }

    public class Potato : Vegetable
    {

        private Potato(int rt) : base(rt) { }

        private static Potato instance;

        public static Potato Instance()
        {
            if (instance == null)
            {
                instance = new Potato(9);
            }
            return instance;
        }
    }

}
