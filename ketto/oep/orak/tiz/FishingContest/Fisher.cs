namespace FishingContest
{
    public class AlreadyInListException : Exception;
    public class Fisher
    {
        private string name;
        private List<Catch> catches;

        public Fisher(string name)
        {
            this.name = name;
            catches = new List<Catch>();
        }

        public void Catch(DateTime t, Fish f, double w, Competition c)
        {
            Catch ca = new Catch(w, f, t, c);
            if (!catches.Contains(ca)) catches.Add(ca);
            else throw new AlreadyInListException();
        }

        public bool FH(Competition v) {
            foreach(var f in catches) {
                if (f.Competition == v && f.Fish is Harcsa) {
                    return true;
                }
            }
            return false;
        }
    }
}

