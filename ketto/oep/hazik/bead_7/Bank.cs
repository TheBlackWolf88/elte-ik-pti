
namespace HF7
{
    public class NoAccountWithThatNumberException : Exception;
    public class Bank
    {

        private List<Account> accounts;

        public Bank()
        {
            accounts = new List<Account>();
        }

        public void OpenAccount(string cNum, Customer c)
        {
            Account acc = new Account(cNum);
            accounts.Add(acc);
            c.AddAccount(acc);
        }

        public void ProvidesCard(string cNum)
        {
            if (FindAccount(out Account? acc, cNum))
            {
                acc!.cards.Add(new Card(cNum));
            }
            else throw new NoAccountWithThatNumberException();
        }

        public int GetBalance(string cNum)
        {
            if (FindAccount(out Account? acc, cNum))
            {
                return acc!.GetBalance();
            }
            else return -1;
        }

        public bool CheckAccount(string cNum)
        {
            return FindAccount(out _, cNum);
        }

        public void Transaction(string cNum, int amount)
        {
            if (FindAccount(out Account? acc, cNum))
            {
                acc!.Change(amount);
            }
            else throw new NoAccountWithThatNumberException();
        }

        private bool FindAccount(out Account? acc, string cNum)
        {
            acc = null;
            foreach (var el in accounts)
            {
                if (el.accNum == cNum)
                {
                    acc = el;
                    return true;
                }
            }
            return false;
        }
    }

}
