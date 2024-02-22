namespace HF1
{
    enum Content
    {
        EMPTY,
        WALL,
        TREASURE,
        GHOST
    }

    class Labyrinth
    {
        private Content[,] map;

        private int rows { get { return map.GetLength(0); } }
        private int cols { get { return map.GetLength(1); } }


        public Labyrinth(Content[,] map)
        {
            this.map = map;
        }

        public Content WhatIsThere(int x, int y, Direction dir)
        {
            if ((x + dir.x < 0 && x + dir.x <= cols) && (y + dir.y < 0 && y + dir.y <= rows))
            {
                throw new Exception();
            }
            return this.map[x + dir.x, y + dir.y];
        }

        public void Collect(int x, int y)
        {
            if (this.map[x, y] != Content.TREASURE)
            {
                throw new Exception();
            }
            this.map[x, y] = Content.EMPTY;
        }
    }

    struct Direction
    {
        public int x;
        public int y;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            string[] separatedLine = Console.ReadLine()!.Split();
            n = int.Parse(separatedLine[0]);
            m = int.Parse(separatedLine[1]);
            Content[,] map = new Content[n, m];
            Content placeholder;
            for (int i = 0; i < n; i++)
            {
                separatedLine = Console.ReadLine()!.Split();
                for (int j = 0; j < m; j++)
                {
                    switch (separatedLine[j])
                    {
                        case "Üres":
                            placeholder = Content.EMPTY;
                            map[i, j] = placeholder;
                            break;
                        case "Fal":
                            placeholder = Content.WALL;
                            map[i, j] = placeholder;
                            break;
                        case "Kincs":
                            placeholder = Content.TREASURE;
                            map[i, j] = placeholder;
                            break;
                        case "Szellem":
                            placeholder = Content.GHOST;
                            map[i, j] = placeholder;
                            break;
                    }
                }
            }
            Labyrinth labyrinth = new Labyrinth(map);
            int x, y;
            try
            {
                separatedLine = Console.ReadLine()!.Split();
                x = int.Parse(separatedLine[0]);
                y = int.Parse(separatedLine[1]);
                labyrinth.Collect(x, y);
                Console.WriteLine("Sikerült begyűjteni");
            }
            catch (Exception e)
            {
                Console.WriteLine("Nem sikerült a begyűjtés");
            }
            try
            {
                separatedLine = Console.ReadLine()!.Split();
                x = int.Parse(separatedLine[0]);
                y = int.Parse(separatedLine[1]);
                Direction dir;
                separatedLine = Console.ReadLine()!.Split();
                dir.x = int.Parse(separatedLine[0]);
                dir.y = int.Parse(separatedLine[1]);
                Content result = labyrinth.WhatIsThere(x, y, dir);
                if (result == Content.TREASURE)
                    Console.WriteLine("Kincs");
                else if (result == Content.WALL)
                    Console.WriteLine("Fal");
                else if (result == Content.EMPTY)
                    Console.WriteLine("Üres");
                else
                    Console.WriteLine("Szellem");
            }
            catch (Exception e)
            {
                Console.WriteLine("Nem sikerült megtekinteni a tartalmat");
            }
        }
    }

}
