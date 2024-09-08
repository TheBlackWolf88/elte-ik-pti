namespace HydroCircle
{
    public class Area
    {
        private string name;
        public int wv { get; private set; }
        public Atmosphere? atmo {get;private set;}
        private AreaType? type;
        public Area(Atmosphere atmo, string name, int wv, AreaType? type)
        {
            this.atmo = atmo;
            this.name = name;
            this.wv = wv;
            this.type = type;
        }


        public override String ToString()
        {
            return "Area " + this.name + "; Type: " + this.type + "; Water volume: " + this.wv;
        }
        public void ReactToWeather(Weather w)
        {
            if (type == null) {
                System.Console.Error.WriteLine("Type was null: " + this);
                throw new Exception();
            }
            if (type is Plains) {
                w.Visit(type as Plains);
            }
            else if (type is Green) {
                w.Visit(type as Green);
            }
            else if (type is Swamp) {
                w.Visit(type as Swamp);
            }
            //else throw new Exception();


        }

        public void ChangeWv(int by)
        {
            wv += by;
        }

        public void ChangeType(AreaType t)
        {
            this.type = t;
        }
    }

}

