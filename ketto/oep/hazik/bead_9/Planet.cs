namespace HF9
{
    public class Planet
    {
        public string name;
        private List<Starship> ships;

        public Planet(string name)
        {
            this.name = name;
            this.ships = new List<Starship>();
        }

        public void Defends(Starship s)
        {
            if (ships.Contains(s)) throw new Exception();
            ships.Add(s);
        }
        public void Leaves(Starship s)
        {
            if (!ships.Contains(s)) throw new Exception();
            ships.Remove(s);
        }

        public int ShipCount()
        {
            return ships.Count;
        }

        public int ShieldSum()
        {
            int res = 0;
            foreach (var item in ships)
            {
                res += item.GetShield();
            }
            return res;
        }

        public (bool l, double fireP, Starship? s)  MaxFireP () {
            double fireP = 0;
            Starship? s = null;

            foreach (var item in ships)
            {
                if (item.FireP() > fireP) {
                    s = item;
                    fireP = item.FireP();
                }
                
            }

            return (s != null, fireP, s);
        }
    }
}

