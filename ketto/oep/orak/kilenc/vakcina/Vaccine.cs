namespace Vaccine
{
    public abstract class Vaccine
    {
        public DateTime ExpirationDate { get; private set; }
        protected Vaccine()
        {
            ExpirationDate = DateTime.Now.AddYears(1);
        }

        public abstract string Name();
        public abstract int Repeat();



    }

    public class Pfizer : Vaccine
    {
        public Pfizer(): base()
        {
        }


        public override string Name()
        {
            return "Pfizer";
        }

        public override int Repeat()
        {
            return 28;
        }

    }
    public class Moderna : Vaccine
    {
        public Moderna(): base()
        {
        }


        public override string Name()
        {
            return "Moderna";
        }

        public override int Repeat()
        {
            return 21;
        }

    }
    public class Astrzeneca : Vaccine
    {
        public Astrzeneca(): base()
        {
        }


        public override string Name()
        {
            return "Astrzeneca";
        }

        public override int Repeat()
        {
            return 81;
        }

    }

}
