namespace HF7
{
    public class Center {
        private List<Bank> banks;

        public Center(List<Bank> banks)
        {
            this.banks = banks;
        }

        private bool FindBank(out Bank? b, string cNum) {
            b = null;
            foreach(var el in banks){
                if (el.CheckAccount(cNum)) {
                    b = el;
                    return true;
                }
                
            }
            return false;
        }

        public int GetBalance(string cNum) {
            if (FindBank(out Bank? b, cNum)) {
                return b!.GetBalance(cNum);
            }
            return -1;
        }
        public void Transaction(string cNum, int amount) {
            if (FindBank(out Bank? b, cNum)) {
                b!.Transaction(cNum, amount);
            }
        }
    }
}

