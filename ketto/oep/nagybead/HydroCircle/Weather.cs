namespace HydroCircle
{
    public interface Weather
    {
        public void Visit(Plains? p);
        public void Visit(Green? g);
        public void Visit(Swamp? s);
    }

    public class Sunny : Weather
    {
        private static Sunny? _instance;
        private Sunny() { }
        public static Sunny Instance()
        {
            if (_instance == null) _instance = new();
            return _instance;
        }

        public void Visit(Plains? p)
        {
            if (p == null) throw new Exception();
            p.ReactSunny();
        }

        public void Visit(Green? g)
        {
            if (g == null) throw new Exception();
            g.ReactSunny();
        }

        public void Visit(Swamp? s)
        {
            if (s == null) throw new Exception();
            s.ReactSunny();
        }
    }
    public class Cloudy : Weather
    {
        private static Cloudy? _instance;
        private Cloudy() { }
        public static Cloudy Instance()
        {
            if (_instance == null) _instance = new();
            return _instance;
        }

        public void Visit(Plains? p)
        {
            if (p == null) throw new Exception();
            p.ReactCloudy();
        }

        public void Visit(Green? g)
        {
            if (g == null) throw new Exception();
            g.ReactCloudy();
        }

        public void Visit(Swamp? s)
        {
            if (s == null) throw new Exception();
            s.ReactCloudy();
        }
    }
    public class Rainy : Weather
    {
        private static Rainy? _instance;
        private Rainy() { }
        public static Rainy Instance()
        {
            if (_instance == null) _instance = new();
            return _instance;
        }

        public void Visit(Plains? p)
        {
            if (p == null) throw new Exception();
            p.ReactRainy();
        }

        public void Visit(Green? g)
        {
            if (g == null) throw new Exception();
            g.ReactRainy();
        }

        public void Visit(Swamp? s)
        {
            if (s == null) throw new Exception();
            s.ReactRainy();
        }
    }

}

