namespace Vaccine
{
    public class Patient {
        public string Taj {get; private set;}
        private List<Vaccination> vaccinations;

        public Patient(string taj)
        {
            Taj = taj;
            this.vaccinations = new List<Vaccination>();
        }
        public int cVaccinations () {
            return vaccinations.Count;
        }
    }
}

