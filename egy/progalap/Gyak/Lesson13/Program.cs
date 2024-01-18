using System.Collections.Generic;
using System;
namespace Lesson13 {
    class Program {
        struct People {
            public string name;
            public List<int> felvSportok;

            public People(string name, List<int> a) {
                this.name = name;
                this.felvSportok = a;
            }
        }
        public static void Main (string[] args){
            System.Console.WriteLine("#");
            string[] line = Console.ReadLine()!.Split(" ");
            int sportagak = int.Parse(line[0]);
            int n = int.Parse(line[1]);
            int[] cSportok = new int[sportagak+1];
            List<People> data = new List<People>();

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine()!.Split(" ");
                int sport = int.Parse(line[1]);
                int volt = voltMar(data, line[0]);
                if( volt != -1){
                   data[volt].felvSportok.Add(sport);
                   cSportok[sport]++;
                } else {
                    People p1 = new People(line[0], new List<int>());
                    p1.felvSportok.Add(sport);
                    data.Add(p1);
                    cSportok[sport]++;
                }
                 
            }
            string egyreNevez = "";
            bool van = false;
            for (int i = 0; i < data.Count && !van; i++){
                if(data[i].felvSportok.Count == 1){
                    van = true;
                    egyreNevez = data[i].name;
                }
            }
            System.Console.WriteLine(egyreNevez);
            System.Console.WriteLine("#");

            string sokraNevezNev = "";
            int sokraNevezC = data[0].felvSportok.Count;
            for(int i = 1; i < data.Count; i++) {
                if(data[i].felvSportok.Count > sokraNevezC){
                    sokraNevezC = data[i].felvSportok.Count;
                    sokraNevezNev = data[i].name;
                }
            }

            System.Console.WriteLine(sokraNevezNev);
            System.Console.WriteLine("#");

            for (int i = 1; i <= sportagak; i++){
                int cSportEzMostJo = 0;
                for (int j = 0; j < data.Count; j++){
                    if(data[j].felvSportok.Contains(i)){
                        cSportEzMostJo++;
                    }
                }
                System.Console.Write(cSportEzMostJo+ " ");
            }
            System.Console.WriteLine("\n#");
//4es no.
            System.Console.WriteLine("#");
            for(int i = 0; i < data.Count; i++){
                List<string> veleTalalkozott = new List<string>();
                People kiv = data[i];
                for(int k = 0; k < kiv.felvSportok.Count; k++){
                    for(int j = 0; j < data.Count; j++){
                        if(data[j].felvSportok.Contains(kiv.felvSportok[k])){
                            if (!veleTalalkozott.Contains(data[j].name)) veleTalalkozott.Add(data[j].name);
                        }
                    }
                }
                System.Console.WriteLine(kiv.name +" "+ (veleTalalkozott.Count-1));

            }
        }

        static int voltMar(List<People> data, string nev){
            for (int i = 0; i < data.Count; i++){
                if(data[i].name == nev) return i;
            }
            return -1;
        }
    }
}
