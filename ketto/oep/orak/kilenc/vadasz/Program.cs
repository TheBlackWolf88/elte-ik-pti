namespace Vadasz
{
    public enum Gender
    {
        MALE,
        FEMALE
    }
    public abstract class Animal
    {
        public double Weight { get; protected set; }
        public Gender Gender { get; protected set; }

        protected Animal(double weight, Gender gender)
        {
            Weight = weight;
            Gender = gender;
        }
    }

    public class Elephant : Animal
    {
        public double Right { get; private set; }
        public double Left { get; private set; }

        public Elephant(double right, double left, double Weight, Gender gender) : base(Weight, gender)
        {
            Right = right;
            Left = left;
        }
    }

    public class Rhino : Animal
    {
        public double Horn { get; private set; }

        public Rhino(double horn, double w, Gender g) : base(w, g)
        {
            Horn = horn;
        }
    }

    public class Lion : Animal
    {
        public Lion(double weight, Gender gender) : base(weight, gender)
        {
        }
    }

    public class Trophy
    {
        private string place;
        private string date;
        public Animal Animal { get; private set; }

        public Trophy(string place, string date, Animal ani)
        {
            this.Animal = ani;
            this.place = place;
            this.date = date;
        }
    }

    public class Hunter
    {
        private string name;
        private string bdate;
        private List<Trophy> trophies;

        public Hunter(string name, string bdate)
        {
            this.name = name;
            this.bdate = bdate;
            this.trophies = new List<Trophy>();
        }

        public void Capture(string where, string when, Animal what)
        {
            trophies.Add(new Trophy(where, when, what));
        }

        public int cMaleLion()
        {
            int res = 0;
            foreach (var el in trophies)
            {
                if (el.Animal is Lion && el.Animal.Gender == Gender.MALE) res++;
            }
            return res;
        }

        public bool maxHornWeight(out double weight, out Trophy? trophy)
        {
            trophy = null;
            weight = 0;
            foreach (var el in trophies)
            {
                if (el.Animal is Rhino)
                {
                    Rhino r = (Rhino)el.Animal;
                    if (r.Horn / r.Weight > weight)
                    {
                        weight = r.Horn / r.Weight;
                        trophy = el;
                    }
                }
            }

            return trophy == null;
        }

        public bool sameTuskLength()
        {
            foreach (var el in trophies)
            {
                if (el.Animal is Elephant)
                {
                    Elephant e = (Elephant)el.Animal;
                    if (e.Left == e.Right) return true;
                }
            }
            return false;
        }
    }



}
