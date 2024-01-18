namespace Lesson5 {
    class Program {
        const int maxN = 100;
        struct Places {
            public string place;
            public int cAni;
            public string[] aniN;
        }

        static void Main (string[] args){
            //Console.WriteLine("Zoo");
            int db;
            Places[] places = new Places[maxN];
            
            beolvas(out db, out places);
            
            int sumAni ;
            int cMajom;
            string whereKacsa;
            
            sumAni = sumDb(db, places);
            dbMajom(db, places, out cMajom);
            whereKacsa = talaljKacsat(db, places);

            kiiras(sumAni,cMajom, whereKacsa);
        }

        static void kiiras(int sumAni, int dbMajom, string whereKacsa){
            Console.WriteLine(sumAni);
            Console.WriteLine(dbMajom);
            Console.WriteLine(whereKacsa);
        }


        static void beolvas(out int db, out Places[] teruletek){
            int.TryParse(Console.ReadLine(), out db);
            teruletek = new Places[db];
            for(int i = 0; i < db; i++){
                teruletek[i].place = Console.ReadLine()!;
                teruletek[i].cAni = int.Parse(Console.ReadLine()!);
                teruletek[i].aniN = Console.ReadLine()!.Split(";");
            }
        }

        static int sumDb(int db, Places[] places){
            int sum = 0;
            for (int i = 0; i < db; i++){
                sum += places[i].cAni;
            }
            return sum;
        }
        
        static bool vanBenne(string mi, int db, string[] hol){
            for(int i = 0; i < db; i++){
                if(hol[i] == mi) return true;
            }
            return false;
        }

        static void dbMajom(int db, Places[] places, out int cMajom){
            cMajom = 0;
            for(int i = 0; i < db; i++){
                if(vanBenne("majom", places[i].cAni, places[i].aniN)){
                    cMajom++;
                }
            }
        }

        static string talaljKacsat(int db, Places[] places){
            for(int i = 0; i < db; i++){
                if(vanBenne("kacsa", places[i].cAni, places[i].aniN)){
                    return places[i].place;
                }
            }
            return "";
        }
    }
}
