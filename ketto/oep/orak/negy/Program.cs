namespace Map
{
    class Team {
        public string name;
        public int place;

        public Team(string name, int score)
        {
            this.name = name;
            this.place = score;
        }
    }

    public class DuplicateKeyException : Exception;
    public class NoSuchKeyException: Exception;

    class Map {
        private List<Team> seq;

        public Map()
        {
            this.seq = new List<Team>();
        }

        private bool LogSearch(int key, out int ind){
           bool l = false;
           int ah = 0;
           int fh = this.seq.Count;
           ind = 0;
           while (!l && ah <= fh) {
                ind = (ah+fh)/2;
                if (this.seq[ind].place == key) {
                    l = true;
                } else if (this.seq[ind].place > key){
                    fh = ind-1;
                } else {
                    ah = ind+1;
                }
           }
           if (!l) ind = ah;
           return l;
        }

        public void SetEmpty(){
            this.seq = new List<Team>();
        }

        public int Count() {
            return seq.Count();
        }

        public void Insert(Team e){
            int ind = 0;
            if (LogSearch(e.place, out ind)) throw new DuplicateKeyException(); 
            seq.Insert(ind, e);
        }

        public void Remove(int place) {
            int ind = 0;
            if (!LogSearch(place, out ind)) throw new NoSuchKeyException(); 
            seq.RemoveAt(ind);

        }

        public bool In(int place) {
            return LogSearch(place, out int ind);
        }

        public string this[int key] {
            get{ 
                if(!LogSearch(key, out int ind)) throw new NoSuchKeyException();
                return seq[ind].name;
            }
        }
    }

    public class Program {
        public static void Main (string[] args) {

        }
    }
    
}
