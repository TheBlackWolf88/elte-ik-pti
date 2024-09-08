using TextFile;

namespace Purchase
{
    class Customer
    {
        public string Name { get; }
        private List<string> list;
        public List<Product> cart;

        public Customer(string filename)
        {
            list = new List<string>();
            cart = new List<Product>();
            TextFileReader reader = new TextFileReader(filename);
            Name = reader.ReadString();
            while (reader.ReadString(out string str))
            {
                list.Add(str);
            }

        }

        public void Buy(Product p, Department d)
        {
            d.Stock.Remove(p);
            cart.Add(p);
        }

        private bool Search(out Product? product, string name, Department dep)
        {
            product = null;
            foreach (Product el in dep.Stock)
            {
                if (el.Name == name)
                {
                    product = el;
                    return true;
                }
            }
            return false;
        }

        private bool CheapSearch(out Product? product, string name, Department dept)
        {
            int minPrice = 0;
            product = null;
            foreach (Product el in dept.Stock)
            {
                if (el.Name == name && el.Price < minPrice)
                {
                    minPrice = el.Price;
                    product = el;
                }
            }
            return product != null;
        }

        public void PurchaseItems (Store s) {
            foreach (var item in list)
            {
                if (Search(out Product? pro, item, s.Foods)) Buy(pro!, s.Foods);
            }
            foreach (var item in list)
            {
                if (CheapSearch(out Product? pro, item, s.Tech)) Buy(pro!, s.Tech);
            }
        }


    }

}

