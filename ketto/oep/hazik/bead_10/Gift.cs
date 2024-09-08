namespace HF10
{
    public abstract class Gift {
        private Size size;
        public TargetShot? targetShot;

        protected Gift(Size size)
        {
            this.size = size;
        }

        public virtual int Point() {
            return 0;
        }

        public int Value() {
            return (size.Multi() * Point());    
        }
    }

    public class Ball : Gift
    {
        public Ball(Size size) : base(size)
        {
        }

        public override int Point()
        {
            return 1;
        }

    }
    public class Figure : Gift
    {
        public Figure(Size size) : base(size)
        {
        }

        public override int Point()
        {
            return 2;
        }

    }
    public class Plush : Gift
    {
        public Plush(Size size) : base(size)
        {
        }

        public override int Point()
        {
            return 3;
        }

    }
}

