namespace HF10
{
    public interface Size {
        int Multi();
    }

    public class S : Size
    {
        private static S? _instance;

        private S () {}

        public static S Instance() {
            if (_instance == null) _instance = new();
            return _instance;
        }

        public int Multi()
        {
            return 1;
        }
    }
    public class M : Size
    {
        private static M? _instance;

        private M () {}

        public static  M Instance() {
            if (_instance == null) _instance = new();
            return _instance;
        }
        public int Multi()
        {
            return 2;
        }
    }
    public class L : Size
    {
        private static L? _instance;

        private L () {}

        public static L Instance() {
            if (_instance == null) _instance = new();
            return _instance;
        }
        public int Multi()
        {
            return 3;
        }
    }
    public class XL : Size
    {
        private static XL? _instance;

        private XL () {}

        public static XL Instance() {
            if (_instance == null) _instance = new();
            return _instance;
        }
        public int Multi()
        {
            return 4;
        }
    }
}


