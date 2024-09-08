namespace HF9
{
    public class Starship
    {
        private string name;

        protected int shield;
        protected int armor;
        protected int guardian;
        private Planet? planet;

        public Starship(string name, int shield, int armor, int guardian)
        {
            this.name = name;
            this.shield = shield;
            this.armor = armor;
            this.guardian = guardian;
        }

        public int GetShield()
        {
            return shield;
        }

        public void StaysAtPlanet(Planet p)
        {
            if (planet != null){
                planet.Leaves(this);
            }
            planet = p;
            planet.Defends(this);



        }

        public void LeavesPlanet()
        {
            if (planet == null) throw new Exception();
            planet.Leaves(this);
            planet = null;
        }

        public virtual double FireP() { return 0; }

    }

    public class Wallbreaker : Starship
    {
        public Wallbreaker(string name, int shield, int armor, int guardian) : base(name, shield, armor, guardian)
        {
        }

        public override double FireP()
        {
            return armor/2;
        }
    }
    public class Landingship : Starship
    {
        public Landingship(string name, int shield, int armor, int guardian) : base(name, shield, armor, guardian)
        {
        }

        public override double FireP()
        {
            return guardian;
        }
    }
    public class Lasership : Starship
    {
        public Lasership(string name, int shield, int armor, int guardian) : base(name, shield, armor, guardian)
        {
        }

        public override double FireP()
        {
            return shield;
        }
    }
}

