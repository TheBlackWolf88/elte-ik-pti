namespace FishingContest
{
    public class Guild
    {
        private List<Fisher> members;
        private List<Competition> competitions;
        public Guild()
        {
            members = new();
            competitions = new();
        }
        public void Enter(Fisher f) {
            if (!members.Contains(f)) members.Add(f);
        }
        
        public void Rendez(string place, DateTime start) 
        {
            Competition c = new Competition(place, start, this);
            if (!competitions.Contains(c)) competitions.Add(c);
        }
        public bool IsMember(Fisher f) {
            return members.Contains(f);
        }
    }
}

