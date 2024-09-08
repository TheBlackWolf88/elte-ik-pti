namespace FishingContest
{
    public abstract class Fish
    {
        public abstract int Multiplier();
    }

    public class Ponty : Fish
    {
        private static Ponty? _instance;
        public Ponty Instance()
        {
            if (_instance == null)
            {
                _instance = new Ponty();
            }
            return _instance;
        }

        private Ponty()
        {
        }

        public override int Multiplier()
        {
            return 1;
        }
    }
    public class Keszeg : Fish
    {
        private static Keszeg? _instance;
        public Keszeg Instance()
        {
            if (_instance == null)
            {
                _instance = new Keszeg();
            }
            return _instance;
        }

        private Keszeg()
        {
        }

        public override int Multiplier()
        {
            return 2;
        }
    }
    public class Harcsa : Fish
    {
        private static Harcsa? _instance;
        public Harcsa Instance()
        {
            if (_instance == null)
            {
                _instance = new Harcsa();
            }
            return _instance;
        }

        private Harcsa()
        {
        }

        public override int Multiplier()
        {
            return 3;
        }
    }
}

