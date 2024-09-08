namespace HF7
{
    public class Account {
        public string accNum;
        private int balance;
        public List<Card> cards;

        public Account(string accNum)
        {
            this.accNum = accNum;
            this.balance = 0;
            this.cards = new List<Card>();
        }

        public int GetBalance() {
            return balance;
        }

        public void Change(int a){
            this.balance += a;
        }
    }
}

