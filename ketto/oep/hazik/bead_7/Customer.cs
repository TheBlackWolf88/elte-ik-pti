namespace HF7
{
    public class Customer
    {
        private string pin;
        private int withdraw;
        private List<Account> accounts;

        public Customer(string v1, int v2)
        {
            this.pin = v1;
            this.withdraw = v2;

            this.accounts = new List<Account>();
        }

        public void Withdrawal(ATM atm) {
            atm.Process(this);
        }

        public Card ProvidesCard() {
            return accounts[0].cards[0];
        }

        public string ProvidesPIN(){
            return pin;
        }

        public int RequestMoney() {
            return withdraw;
        }

        public void AddAccount(Account a){
            accounts.Add(a);
        }
    }
}

