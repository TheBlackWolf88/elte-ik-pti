namespace FishingContest
{
    public class Catch {
        private double weight;
        public Fish Fish {get;private set;}
        private DateTime idopont;
        public Competition Competition {get;}

        public Catch(double weight, Fish fish, DateTime idopont, Competition c)
        {
            this.Competition = c;
            this.weight = weight;
            this.Fish = fish;
            this.idopont = idopont;
        }

        public double Value() {
            return weight * Fish.Multiplier();
        }
    }
}

