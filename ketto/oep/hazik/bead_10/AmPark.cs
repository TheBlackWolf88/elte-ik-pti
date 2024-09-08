namespace HF10
{
    public class AmPark {
        private List<TargetShot> targetShots;
        private List<Guest> guests;
        public AmPark(List<TargetShot> targetShots)
        {
            if (targetShots.Count < 2) throw new Exception();
            this.targetShots = targetShots;
            this.guests = new();
        }

        public void Receives(Guest g) {
            if (guests.Contains(g)) throw new Exception();
            guests.Add(g);
        }

        public string Best(TargetShot t) {
            if (guests.Count == 0) throw new Exception();
            Guest elem = guests[0];
            foreach (Guest g in guests) {
                if (g.Result(t) > elem.Result(t)) {
                    elem = g;
                }
            }
            return elem.Name;
        }
    }
}

