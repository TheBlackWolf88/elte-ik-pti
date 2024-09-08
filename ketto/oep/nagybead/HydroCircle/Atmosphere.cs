namespace HydroCircle
{
    public class Atmosphere
    {
        private int humidity;
        public List<Area> areas;

        public Atmosphere(int h)
        {
            this.humidity = h;
            this.areas = new List<Area>();
        }

        public void AddArea(Area a)
        {
            if (this.areas.Contains(a)) throw new Exception();
            this.areas.Add(a);
        }

        public void VisitAreas(Weather w)
        {
            foreach (Area area in areas)
            {
                area.ReactToWeather(w);
                System.Console.WriteLine(area + "\n");
            }

        }

        public Weather Weather()
        {
            if (this.humidity > 70)
            {
                this.humidity = 30;
                return Rainy.Instance();
            }
            else if (this.humidity < 40)
            {
                return Sunny.Instance();
            }
            else
            {
                Random rand = new Random();
                int random = rand.Next(0, 101);
                if (random < ((this.humidity - 40) * 3.3))
                {
                    return Rainy.Instance();
                }
                else return Cloudy.Instance();
            }
        }

        public void IncreaseHumidity(int b)
        {
            this.humidity += b;
        }

        public bool MaxWaterVolume(out int max, out Area? a)
        {
            a = null;
            max = 0;
            foreach (Area area in areas)
            {
                if (a == null || area.wv > max)
                {
                    a = area;
                    max = a.wv;
                }

            }
            return a != null;
        }
    }

}

