using System;
using System.Text.RegularExpressions;
namespace Lesson2 {
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Kartyak");
            
            /*
            const int N = 8;
            string[] kartyak = new string[N] {"7","8", "9", "t", "a", "f","k","A"};
            int[] ertekek = new int[N] {7,8,9,10,2,3,4,11};
            
            string? kartya = "";

            while (true) {
                Console.Write("Adj meg egy kartyat: ");
                kartya = Console.ReadLine(); 
                if (kartyak.Contains(kartya)) break;
                else Console.Error.WriteLine("Nincs ilyen kartya a pakliban! (7,8, 9, t, a, f,k,A)");
            }
            int ertek = 0;
            for (int i = 0; i <= N-1; i++){
                if(kartyak[i] == kartya){
                    ertek = ertekek[i];
                }
            }

            Console.WriteLine("A kartya erteke: " + ertek);*/

            string[] cards = {"2", "3","4","5","6","7","8","9","t","j","q","k","a"};
//            string err = "Nincs ilyen kartya a pakliban! (" + string.Join(",", cards + ")");

            List<string> hand = new List<string>();

            Random rand = new Random();
            hand.Add(cards[rand.Next(0,cards.Length)]);
            hand.Add(cards[rand.Next(0,cards.Length)]);

            Console.WriteLine("Your hand: " + string.Join(", ", hand));

            Console.WriteLine("Sum of your cards: "
                + Program.getSum(hand));
        }
        static int getSum(List<string> hand){
            int sum = 0;
            for(int i = 0; i < hand.Count; i++){
                if(GetMatch(hand[i]) == true){
                    int a = 0;
                    int.TryParse(hand[i], out a);
                    sum += a;
                }else if(hand[i] != "A"){
                    sum += 10;
                } else {
                    sum +=11;
                }
            }
            return sum;
        }

        public static bool GetMatch(string input) {
        Match match = Regex.Match("[0-9]",input);
        if (match.Success) {
            return true;
        } else {
            return false;
        }
    }

    }
}
