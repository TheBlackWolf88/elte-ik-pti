namespace HydroCircle
{
    public abstract class AreaType
    {
        protected Area? area;

        protected AreaType(Area area)
        {
            this.area = area;
        }

        public abstract void ReactSunny();
        public abstract void ReactCloudy();
        public abstract void ReactRainy();
    }

    public class Plains : AreaType
    {
        public Plains(Area area) : base(area)
        {
        }

        public override void ReactSunny()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(3);
            area.ChangeWv(-3);
        }
        public override void ReactCloudy()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(3);
            area.ChangeWv(1);
            if (area.wv > 15)
            {
                area.ChangeType(new Green(area));
                area = null;
            }
        }

        public override void ReactRainy()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(3);
            area.ChangeWv(5);
            if (area.wv > 15)
            {
                area.ChangeType(new Green(area));
                area = null;
            }
        }


        public override string ToString()
        {
            return "Plains";
        }
    }

    public class Green : AreaType
    {
        public Green(Area area) : base(area)
        {
        }

        public override void ReactSunny()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(7);
            area.ChangeWv(-6);
            if (area.wv <= 15)
            {
                area.ChangeType(new Plains(area));
                area = null;
            }
        }
        public override void ReactCloudy()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(7);
            area.ChangeWv(2);
            if (area.wv > 50)
            {
                area.ChangeType(new Swamp(area));
                area = null;
            }
        }

        public override void ReactRainy()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(7);
            area.ChangeWv(10);
            if (area.wv > 50)
            {
                area.ChangeType(new Swamp(area));
                area = null;
            }
        }
        public override string ToString()
        {
            return "Green";
        }
    }
    public class Swamp : AreaType
    {
        public Swamp(Area area) : base(area)
        {
        }

        public override void ReactSunny()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(10);
            area.ChangeWv(-10);
            if (area.wv <= 50)
            {
                area.ChangeType(new Green(area));
                area = null;

            }
        }
        public override void ReactCloudy()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(10);
            area.ChangeWv(3);
        }

        public override void ReactRainy()
        {
            if (area == null || area.atmo == null) throw new Exception();
            area.atmo.IncreaseHumidity(10);
            area.ChangeWv(15);
        }

        public override string ToString()
        {
            return "Swamp";
        }
    }

}
