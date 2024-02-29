using TextFile;
namespace Bag
{

    public class Pair
    {
        public string data;
        public int count;

        public Pair(string d, int c)
        {
            data = d;
            count = c;
        }

        public override string ToString()
        {
            return "(" + data + "," + count + ")";
        }
    }

    public class BagEmptyException : Exception;
    public class DataNotInBagException : Exception;

    public class Bag
    {
        private List<Pair> seq;
        private int maxind;

        public Bag()
        {
            seq = new List<Pair>();
        }

        public void setEmpty()
        {
            seq.Clear();
        }

        public bool Empty()
        {
            return seq.Count == 0;
        }

        public int Multiple(string data)
        {
            bool l = LogSearch(data, out int ind);
            if (l)
            {
                return seq[ind].count;
            }
            else return 0;
        }

        public string Max()
        {
            if (seq.Count > 0) return seq[maxind].data;
            else throw new BagEmptyException();
        }

        public void Insert(string e)
        {
            bool l = LogSearch(e, out int ind);

            if (l)
            {
                seq[ind].count++;
                if (seq[ind].count > seq[maxind].count) maxind = ind;
            }
            else
            {
                seq.Insert(ind, new Pair(e, 1));
                if (seq.Count == 1) maxind = 1;
                else if (maxind > ind) maxind++;
            }
        }

        public void Remove(string e)
        {

            bool l = LogSearch(e, out int ind);
            if (!l) throw new DataNotInBagException();

            if (seq[ind].count == 1)
            {
                seq.RemoveAt(ind);
            }
            else
            {
                seq[ind].count--;
            }
            if (seq.Count > 0)
            {
                for (int i = 0; i < seq.Count; i++)
                {
                    if (seq[i].count > seq[maxind].count)
                    {
                        maxind = i;
                    }
                }
            }
        }

        private bool LogSearch(string e, out int ind)
        {
            ind = 0;
            bool l = false;
            int ah = 0;
            int fh = seq.Count - 1;

            while (!l && ah < fh)
            {
                ind = (ah + fh) / 2;
                if (String.Compare(seq[ind].data, e) > 0)
                {
                    fh = ind - 1;
                }
                else if (String.Compare(seq[ind].data, e) == 0)
                {
                    l = true;
                }
                else if (String.Compare(seq[ind].data, e) < 0)
                {
                    ah = ind + 1;
                }
            }

            if (!l) ind = ah;
            return l;
        }

        public override string ToString()
        {
            string output = "[";
            foreach (Pair el in seq)
            {
                output += el.ToString();
            }
            return output + "]";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                TextFileReader tf = new TextFileReader("input.txt");
                Bag bag = new Bag();
                while (tf.ReadString(out string word))
                {
                    bag.Insert(word);
                }
                Console.WriteLine(bag);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File not found!");
            }
            catch (BagEmptyException)
            {
                Console.Error.WriteLine("Empty Bag!");
            }

        }
    }
}
