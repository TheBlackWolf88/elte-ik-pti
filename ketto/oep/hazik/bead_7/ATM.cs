namespace HF7
{
    public class WrongPinException : Exception;
    public class NoMoneyException : Exception;

    public class ATM
    {
        public string site;
        private Center center;

        public ATM(string site, Center center)
        {
            this.site = site;
            this.center = center;
        }

        public void Process(Customer c)
        {
            Card card = c.ProvidesCard();
            if (card.CheckPIN(c.ProvidesPIN()))
            {
                int a = c.RequestMoney();
                if (center.GetBalance(card.cNum) >= a)
                {
                    center.Transaction(card.cNum, -a);
                }
            }
        }
    }
}

