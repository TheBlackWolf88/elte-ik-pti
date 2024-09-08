namespace Vaccine
{

    public class VaccinationSite{
        private string place;
        private List<Vaccine> vaccines;
        private List<Patient> patients;

        public VaccinationSite(string place)
        {
            this.place = place;
            this.vaccines = new List<Vaccine>();
            this.patients = new List<Patient>();
        }

        public void Acquire(Vaccine v) {
            vaccines.Add(v);
        }

        public void Register(Patient p) {
            if (patients.Contains(p)) throw new Exception();
            patients.Add(p);
        }

        public void Vaccinate(Patient p, string vName) {
            Vaccine? v = null;
            foreach (var item in vaccines)
            {
                if ((item.Name() == vName) && item.ExpirationDate < DateTime.Now) {
                   v = item; 
                }
            } 
            if (v == null) throw new Exception();
            Patient? v = null;
            foreach (var item in patients)
            {
                if ((item.Name() == vName) && item.ExpirationDate < DateTime.Now) {
                   v = item; 
                }
            } 
            if (v == null) throw new Exception();
        }
    }


    class Program { }
}
