namespace HF10
{
    public class TargetShot{
        private string site;
        public List<Gift> gifts {get; private set;}

        public TargetShot(string site)
        {
            this.site = site;
            this.gifts = new();
        }

        public void Shows(Gift g) {
            if (g.targetShot != null) throw new Exception();
            if (gifts.Contains(g)) throw new Exception();
            g.targetShot = this;
            gifts.Add(g);
        }

        public List<Gift> GetGifts()
        {
            return gifts;
        }
    }
}

