namespace HF9
{
    public class Solarsystem
    {
        public List<Planet> planets;

        public Solarsystem()
        {
            planets = new List<Planet>();
        }

        public (bool, Starship?) MaxFireP()
        {
            Starship? s = null;
            foreach (var item in planets)
            {
                if (s == null) (_, _, s) = item.MaxFireP();
                (_, double w, Starship? s1) = item.MaxFireP();
                if (s != null && s!.FireP() < w)
                {
                    s = s1;
                }
            }
            return (s != null, s);
        }

        public List<Planet> Defenseless()
        {
            List<Planet> ps = new List<Planet>();

            foreach (var item in planets)
            {
                if (item.ShipCount() == 0) ps.Add(item);

            }
            return ps;
        }
    }
}

