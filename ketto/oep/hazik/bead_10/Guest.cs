namespace HF10
{
    public class Guest {
        public string Name {get;private set;}
        private List<Gift> prizes;

        public Guest(string name)
        {
            Name = name;
            prizes = new();
        }

        public void Wins(Gift g) {
            if (prizes.Contains(g)) throw new Exception();
            if (!g.targetShot!.gifts.Contains(g)) throw new Exception();
            g.targetShot.gifts.Remove(g);
            prizes.Add(g);
        } 

        public int Result(TargetShot t) {
            int sum = 0;
            foreach (Gift g in prizes) {
                if (g.targetShot == t) {
                    sum += g.Value();
                }
            }
            return sum;
        }

        public string getName()
        {
            return Name;
        }
    }
}

