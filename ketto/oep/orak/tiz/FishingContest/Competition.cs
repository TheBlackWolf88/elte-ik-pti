namespace FishingContest
{
    public class Competition
    {
        public string Place { get; private set; }
        public DateTime Start { get; private set; }
        private Guild guild;
        private List<Fisher> fishers;
        private List<Catch> catches;

        public Competition(string place, DateTime start, Guild guild)
        {
            Place = place;
            Start = start;
            this.guild = guild;
            fishers = new();
            catches = new();
        }

        public void Register(Fisher f)
        {
            if (!fishers.Contains(f))
            {
                fishers.Add(f);
            }
        }

        public void Authorize(Catch f)
        {
            if (!catches.Contains(f)) catches.Add(f);
        }

        public bool MFH()
        {
            bool l = true;
            foreach (var h in fishers)
            {
                l = l && h.FH(this);
            }
            return l;
        }

        public double Summarize()
        {
            double sum = 0;
            foreach (var item in catches)
            {
                sum += item.Value();

            }
            return sum;
        }


    }
}

