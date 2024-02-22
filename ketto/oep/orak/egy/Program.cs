namespace adagolo
{
    internal class Adagolo
    {
        private int adag;
        private int akt;
        private int kap;

        public Adagolo(int adag, int kap)
        {
            this.adag = adag;
            this.kap = kap;
        }

        public void nyom()
        {
            this.akt = int.Max(this.akt - this.adag, 0);
        }

        public void feltolt()
        {
            this.akt = this.kap;
        }

        public int getAkt()
        {
            return this.akt;
        }

    }

    enum Type
    {
        Sima,
        Negyzetracsos,
        Vonalas
    }
    internal class Fuzet
    {
        private Type type;
        private List<string> lapok;

        public Fuzet(int n, Type t)
        {
            this.type = t;
            this.lapok = new List<string>();
            for (int i = 0; i < n; i++)
            {
                lapok.Add("");
            }

        }

        public int ures
        {
            get
            {
                int s = 0;
                foreach (string el in lapok)
                {
                    if (el.Equals("")) s++;
                }
                return s;
            }
        }

        public int lapDb()
        {
            return this.lapok.Count;
        }
        public int uresDb()
        {
            return this.ures;
        }

        public void Rair (int ind, string s) {
            ind--;
            if (0 <= ind && ind < lapok.Count){
                lapok[ind] = s;
            }
        }

        public void Kitep(int ind){
            ind--;
            lapok.RemoveAt(ind);
        }

        public (bool, int) Keres() {
            for(int i = 0; i < lapok.Count; i++){
                string el = lapok[i];
                if(el != ""){
                    return (true, ++i);
                }
            } 
            return (false, -1);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {

            Fuzet f = new Fuzet(5, Type.Vonalas); 
        }
    }
}
