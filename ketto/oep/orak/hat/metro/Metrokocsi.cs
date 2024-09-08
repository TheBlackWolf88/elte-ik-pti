
namespace Metro
{
    class Metrokocsi {
        public class CantEnterException : Exception;
        public class CantLeaveException : Exception;
        public Metroszerelveny? szerelveny;
        public int letszam;

        public Metrokocsi()
        {
            szerelveny = null;
            letszam = 0;
        }

        public void Beszall(Utas u) {
            if (szerelveny == null) throw new CantEnterException();
            if (letszam == 135) throw new CantEnterException();
            if (u.kocsi != null) throw new CantEnterException();
            u.kocsi = this;
            letszam++;

        }
        public void Leszall(Utas u) {
            if (u.kocsi != this) throw new CantLeaveException();
            u.kocsi = null;
            letszam--;

        }
    }
    
}

