namespace Lesson4 {
    class Program {
        struct Book {
            public string title;
            public string author;
            public int pages;
            public Book (string title, string author, int pages) {
                this.title = title;
                this.author = author;
                this.pages = pages;
            }
        }
        static void Main(string[] args){
            Console.WriteLine("Library");
            
            int N;
            do {
                Console.WriteLine("How many books?");
            }
            while(!int.TryParse(Console.ReadLine(), out N));
            Book[] lib = new Book[N];

            for (int i = 0; i < N; i++){
                Console.WriteLine("Gimme a book (title;author;pages): ");
                string[] data = Console.ReadLine().Split(";");
                Book book = new Book(data[0], data[1], 0);
                if(!int.TryParse(data[2], out book.pages)){
                    Console.Error.WriteLine("NaN! Setting page to 0");
                    book.pages = 0;
                }
                lib[i] = book; 
            }

            //cJokai
            int cJokai = 0;
            for (int i = 0; i < N; i++){
                Book el = lib[i];
                if(el.author.Equals("Jókai Mór")){
                    cJokai += 1;
                }
            }

            Console.WriteLine("cJokai = " + cJokai);

            int sOldal = 0;
            for (int i = 0; i < N; i++){
                Book el = lib[i];
                sOldal += el.pages;
            }

            Console.WriteLine("sOldal= " + sOldal);

            int maxi = 0;
            for(int i = 1; i < N; i++){
                if (lib[i].pages > lib[maxi].pages){
                    maxi = i;
                }
            }
            Console.WriteLine("lhCíme= " + lib[maxi].title);
            
            //van-e haboru es beke
            bool vanEHabBeke = false;
            int indHabBeke = 0;
            for (int i = 0; i < N; i++) {
                Console.WriteLine(lib[i].title);
                if (lib[i].title.Equals("Haboru es Beke")){
                    vanEHabBeke = true;
                    indHabBeke = i;
                    break;
                }
            }
            Console.WriteLine("vanEHabBeke= " + vanEHabBeke);
            if (vanEHabBeke) Console.WriteLine("indHabBeke= " + indHabBeke);

            //van-e 42 oldalas konyv
            bool van42 = false;
            for(int i = 0; i < N; i++){
                if(lib[i].pages == 42){
                    van42 = true;
                    break;
                }
            }

            Console.WriteLine("van42= " + van42);
        }
    }
}
