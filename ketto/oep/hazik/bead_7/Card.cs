namespace HF7
{
    public class Card {
        public string cNum;
        private string pin;

        public Card(string cNum)
        {
            this.cNum = cNum;
            this.pin = "1234";
        }

        public Card(string cNum, string PIN)
        {
            this.cNum = cNum;
            this.pin = PIN;
        }
        public bool CheckPIN(string p) {
            return pin == p;
        } 

        public void SetPIN(string p) {
            pin = p;
        }
    }
}

