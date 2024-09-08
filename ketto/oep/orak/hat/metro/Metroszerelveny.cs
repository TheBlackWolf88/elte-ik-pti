
namespace Metro
{
    class Metroszerelveny {
        public class CantAttachException : Exception;
        public class CantDetachException : Exception;
        public class CantDestroyException : Exception;
        public List<Metrokocsi> kocsik;

        public Metroszerelveny(Metrokocsi[] mk)
        {
            if (mk.Length < 4 || mk.Length > 6) throw new ArgumentException();
            kocsik  = new List<Metrokocsi>();
            foreach (Metrokocsi k in mk)
            {
                if (k.szerelveny != null) throw new CantAttachException();
                
                kocsik.Add(k);
                k.szerelveny = this;
            }
            //this.kocsik = mk;
        }

        public void KocsitRakapcsol (Metrokocsi k, int i){
            if (kocsik.Count== 6) throw new CantAttachException();
            if (k.szerelveny != null) throw new CantAttachException();
            kocsik.Insert(i, k);
            k.szerelveny = this;
        }
        public void KocsitLekapcsol (Metrokocsi k){
            if (kocsik.Count== 4) throw new CantDetachException();
            if (k.letszam > 0) throw new CantDetachException();
            kocsik.Remove(k);
            k.szerelveny = null;
        }

/*        ~Metroszerelveny() {
           foreach(var k in kocsik){
                if (k.letszam > 0) throw new CantDestroyException();
           } 

        }*/


    }
    
}

