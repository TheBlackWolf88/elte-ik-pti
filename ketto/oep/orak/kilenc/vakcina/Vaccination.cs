namespace Vaccine
{
    public class Vaccination
    {
        public DateTime Date { get; private set; }
        public Vaccine Vaccine { get; private set; }

        public Vaccination(DateTime date, Vaccine vaccine)
        {
            Date = date;
            Vaccine = vaccine;
        }
    }
}

