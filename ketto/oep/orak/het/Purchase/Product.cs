namespace Purchase
{
    class Product
    {
        public string Name { get; }
        public int Price { get; }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

    }

}

